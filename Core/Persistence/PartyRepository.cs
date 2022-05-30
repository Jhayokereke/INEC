using Core.Contracts;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence
{
    public class PartyRepository : IPartyRepository
    {
        private readonly Database _database;

        public PartyRepository(Database database)
        {
            _database = database;
        }
        public Party Add(Party entity)
        {
            entity.CreatedOn = DateTime.UtcNow;

            _database.PartyTable.Add(entity);

            return new Party(entity.Id)
            {
                Name = entity.Name,
                Candidates = new List<Candidate>()
            };
        }

        public async Task<Party> AddAsync(Party entity)
        {
            entity.CreatedOn = DateTime.UtcNow;

            await Task.Run(() => _database.PartyTable.Add(entity));

            return new Party(entity.Id)
            {
                Name = entity.Name,
                Candidates = new List<Candidate>()
            };
        }

        public bool Delete(Party entity)
        {
            var party = GetById(entity.Id);

            if (party == null)
            {
                return false;
            }

            _database.PartyTable.Remove(party);
            return true;
        }

        public Task<bool> DeleteAsync(Party entity)
        {
            var party = GetById(entity.Id);

            if (party == null)
            {
                return Task.FromResult(false);
            }

            _database.PartyTable.Remove(party);
            return Task.FromResult(true);
        }

        public IQueryable<Party> GetAll()
        {
            return _database.PartyTable.AsQueryable();
        }

        public async Task<IQueryable<Party>> GetAllAsync()
        {
            return await Task.Run(() => _database.PartyTable.AsQueryable());
        }

        public Party GetById(string id)
        {
            var party = _database.PartyTable.Where(party => party.Id == id).FirstOrDefault();

            return party;
        }

        public async Task<Party> GetByIdAsync(string id)
        {
            var party = _database.PartyTable.Where(party => party.Id == id).FirstOrDefault();

            return await Task.FromResult(party);
        }

        public bool Update(Party entity)
        {
            var party = GetById(entity.Id);

            if (party == null)
            {
                return false;
            }

            party.Name = entity.Name;
            party.ModifiedOn = DateTime.UtcNow;

            return true;
        }

        public async Task<bool> UpdateAsync(Party entity)
        {
            var party = GetById(entity.Id);

            if (party == null)
            {
                return await Task.FromResult(false);
            }

            party.Name = entity.Name;
            party.ModifiedOn = DateTime.UtcNow;

            return await Task.FromResult(true);
        }
    }
}
