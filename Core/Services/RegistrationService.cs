using Core.Contracts;
using Core.DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IVoterRepository _voterRepo;

        public RegistrationService(IVoterRepository voterRepository)
        {
            _voterRepo = voterRepository;
        }

        public async Task<Voter> RegisterNewVoter(VoterRegDTO model)
        {
            Voter newVoter = new Voter()
            {
                DateOfBirth = model.DateOfBirth,
                Firstname = model.Firstname,
                Middlename = model.Middlename,
                Lastname = model.Lastname,
                PollingUnit = new PollingUnit("ABS")
            };

            try
            {
                return await _voterRepo.AddAsync(newVoter);
            }
            catch (Exception)
            {
                //_logger.Error(ex.Message);
            }

            return null;
        }
    }

    public class RegistrationServiceMock : IRegistrationService
    {
        public Task<Voter> RegisterNewVoter(VoterRegDTO model)
        {
            return Task.Run(() => new Voter()
            {
                Firstname = "Ifunnanya",
                Middlename = "George",
                Lastname = "Ikemefuna",
                DateOfBirth = new DateTime(1974, 3, 31).ToString("dd/MM/yyyy"),
                Gender = Commons.Enums.Gender.Male,
                PollingUnit = new PollingUnit("ABS")
            });
        }
    }
}
