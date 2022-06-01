using NUnit.Framework;
using Core;
using Core.Contracts;
using Core.DTOs;
using Models;
using System.Threading.Tasks;
using System;
using Core.Services;
using Moq;

namespace Test.CoreTest.ServicesTest
{
    public partial class RegistrationServiceTest
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

            regServMock.Setup(s => s.RegisterNewCandidate(It.IsAny<CandidateRegDTO>()))
                        .Returns(Task.Run(() => new Candidate()
                        {
                            Name = "Ifunnanya William"
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
            var candidateRepo = new Mock<ICandidateRepository>();
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

            RegistrationService regServ = new RegistrationService(_voterRepo, candidateRepo.Object);

            //Act
            var actual = await regServ.RegisterNewVoter(new VoterRegDTO());

            //Assert
            voterRepoMock.Verify(v => v.AddAsync(It.IsAny<Voter>()), Times.Once);
        }

        [Test]
        public async Task RegisterNewVoter_ShouldReturnNullWhenErrorIsThrown()
        {
            //Arrange
            var candidateRepo = new Mock<ICandidateRepository>();
            var voterRepoMock = new Mock<IVoterRepository>();
            voterRepoMock.Setup(v => v.AddAsync(It.IsAny<Voter>()))
                .Throws(() => new Exception());
            _voterRepo = voterRepoMock.Object;
            

            RegistrationService regServ = new RegistrationService(_voterRepo, candidateRepo.Object);

            //Act
            var actual = await regServ.RegisterNewVoter(new VoterRegDTO());

            //Assert
            Assert.That(actual, Is.Null);
        }
    }

    public partial class RegistrationServiceTest
    {
        //Candidate
        [Test]
        public async Task RegisterNewCandidate_ShouldReturnTaskofCandidate()
        {
            var actual = await _regServ.RegisterNewCandidate(
                new CandidateRegDTO());

            Assert.That(actual, Is.TypeOf<Candidate>());
            Assert.That(actual.Name, Is.EqualTo("Ifunnanya William"));
        }
    }

    public partial class RegistrationServiceTest
    {
        //Party
    }
}
