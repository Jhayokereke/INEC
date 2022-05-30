using NUnit.Framework;
using Core;
using Core.Contracts;
using Core.Persistence;
using Data;
using Core.DTOs;
using Models;
using System.Threading.Tasks;
using System;
using Commons.Enums;
using Core.Services;
using Moq;

namespace Test.CoreTest.ServicesTest
{
    public class RegistrationServiceTest
    {
        IVoterRepository _voterRepo;
        IRegistrationService _regServ;
        [SetUp]
        public void Setup()
        {
            var regServMock = new Mock<IRegistrationService>();
            regServMock.Setup(s => s.RegisterNewVoter(It.IsAny<VoterRegDTO>()))
                .Returns(Task.Run(() => new Voter()
                {
                    Firstname = "Ifunnanya",
                    Middlename = "George",
                    Lastname = "Ikemefuna",
                    DateOfBirth = new DateTime(1974, 3, 31).ToString("dd/MM/yyyy"),
                    Gender = Commons.Enums.Gender.Male,
                    PollingUnit = new PollingUnit("ABS")
                }));

            _regServ = regServMock.Object;
        }

        [Test]
        public async Task RegisterNewVoter_ShouldReturnTaskofVoter()
        {
            var actual = await _regServ.RegisterNewVoter(
                new VoterRegDTO());

            Assert.That(actual, Is.TypeOf<Voter>());
            Assert.IsTrue(!actual.HasVoted);
            Assert.That(actual.PollingUnit.LocalGovernment, Is.EqualTo("ABS"));
            Assert.That(actual.DateOfBirth, Is.EqualTo("31/03/1974"));
        }

        [Test]
        public async Task RegisterNewVoter_ShouldReturnTaskofVoter_UsingMoq()
        {

            var actual = await _regServ.RegisterNewVoter(It.IsAny<VoterRegDTO>());


            Assert.That(actual, Is.TypeOf<Voter>());
        }

        [Test]
        public async Task RegisterNewVoter_ShouldCallVoterRepoAddAsyncMethod()
        {
            //Arrange
            var voterRepoMock = new Mock<IVoterRepository>();
            voterRepoMock.Setup(v => v.AddAsync(It.IsAny<Voter>()))
                .Returns(Task.Run(() => new Voter()
                {
                    Firstname = "Ifunnanya",
                    Middlename = "George",
                    Lastname = "Ikemefuna",
                    DateOfBirth = new DateTime(1974, 3, 31).ToString("dd/MM/yyyy"),
                    Gender = Commons.Enums.Gender.Male,
                    PollingUnit = new PollingUnit("ABS")
                }));
            _voterRepo = voterRepoMock.Object;

            RegistrationService regServ = new RegistrationService(_voterRepo);

            //Act
            var actual = await regServ.RegisterNewVoter(new VoterRegDTO());

            //Assert
            voterRepoMock.Verify(v => v.AddAsync(It.IsAny<Voter>()), Times.Once);
        }

        [Test]
        public async Task RegisterNewVoter_ShouldReturnNullWhenErrorIsThrown()
        {
            //Arrange
            var voterRepoMock = new Mock<IVoterRepository>();
            voterRepoMock.Setup(v => v.AddAsync(It.IsAny<Voter>()))
                .Throws(() => new Exception());
            _voterRepo = voterRepoMock.Object;

            RegistrationService regServ = new RegistrationService(_voterRepo);

            //Act
            var actual = await regServ.RegisterNewVoter(new VoterRegDTO());

            //Assert
            Assert.That(actual, Is.Null);
        }
    }
}
