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
    public class CandidateRepository : ICandidateRepository
    {
        private readonly Database _database;

        public CandidateRepository(Database database)
        {
            _database = database;
        }

        public Candidate Add(Candidate entity)
        {
            if (entity is null)
                return null;
            _database.CandidateTable.Add(entity);

            return new Candidate(entity.Id)
            {
                CreatedOn = entity.CreatedOn,
                ElectionContested = entity.ElectionContested,
                ModifiedOn = entity.ModifiedOn,
                Name = entity.Name,
                Party = entity.Party,
                Votes = entity.Votes
            };

        }

        public async Task<Candidate> AddAsync(Candidate entity)
        {
            if (entity is null)
                return null;

            await Task.Run(() => _database.CandidateTable.Add(entity));

            var newEntity = new Candidate(entity.Id)
            {
                CreatedOn = entity.CreatedOn,
                ElectionContested = entity.ElectionContested,
                ModifiedOn = entity.ModifiedOn,
                Name = entity.Name,
                Party = entity.Party,
                Votes = entity.Votes
            };
            return await Task.FromResult(newEntity);
        }

        public bool Delete(Candidate entity)
        {
            if (!_database.CandidateTable.Any(x => x.Id == entity.Id))
                return false;

            _database.CandidateTable.Remove(entity);
            return true;
        }

        public async Task<bool> DeleteAsync(Candidate entity)
        {
            var check = await Task.Run(() => _database.CandidateTable.Any(x => x.Id == entity.Id));
            if (!check)
                return await Task.FromResult(false);
            await Task.Run(() => _database.CandidateTable.Remove(entity));
            return await Task.FromResult(true);
        }

        public IQueryable<Candidate> GetAll()
        {
            return (IQueryable<Candidate>)_database.CandidateTable;
        }

        public async Task<IQueryable<Candidate>> GetAllAsync()
        {
            return (IQueryable<Candidate>)await Task.FromResult(_database.CandidateTable);
        }

        public Candidate GetById(string id)
        {
            if (!_database.CandidateTable.Any(x => x.Id == id))
                return null;
            return _database.CandidateTable.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Candidate> GetByIdAsync(string id)
        {
            var check = await Task.Run(() => _database.CandidateTable.Any(x => x.Id == id));
            if (!check)
                return null;

            return await Task.Run(() => _database.CandidateTable.FirstOrDefault(x => x.Id == id));
        }

        public bool Update(Candidate entity)
        {
            var theEntity = _database.CandidateTable.FirstOrDefault(x => x.Id == entity.Id);
            if (theEntity is null)
                return false;
            theEntity.Name = entity.Name;
            theEntity.Party = entity.Party;
            theEntity.Votes = entity.Votes;
            theEntity.ModifiedOn = entity.ModifiedOn;
            theEntity.ElectionContested = entity.ElectionContested;

            return true;
        }

        public async Task<bool> UpdateAsync(Candidate entity)
        {
            var theEntity = await Task.Run(() => _database.CandidateTable.FirstOrDefault(x => x.Id == entity.Id));

            if (theEntity is null)
                return false;
            theEntity.Name = entity.Name;
            theEntity.Party = entity.Party;
            theEntity.Votes = entity.Votes;
            theEntity.ModifiedOn = entity.ModifiedOn;
            theEntity.ElectionContested = entity.ElectionContested;

            return await Task.FromResult(true);
        }
    }
}

