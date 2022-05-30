using Core.DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IRegistrationService
    {
        Task<Voter> RegisterNewVoter(VoterRegDTO model);
        Task<Candidate> RegisterNewCandidate(CandidateRegDTO model);
        Task<Party> RegisterNewParty(PartyRegDTO model);
    }
}
