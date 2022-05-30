using Core.Contracts;
using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Persistence
{
    public class VoterRepository : IVoterRepository
    {
        private readonly Database _database;

        public VoterRepository(Database database)
        {
            _database = database;
        }

        public Voter Add(Voter entity)
        {
            entity.CreatedOn = DateTime.UtcNow;
            _database.VoterTable.Add(entity);
            Thread.Sleep(5000);
            return new Voter(entity.Registration_No, entity.Id)
            {
                HasVoted = entity.HasVoted,
                CreatedOn = entity.CreatedOn,
                DateOfBirth = entity.DateOfBirth,
                Firstname = entity.Firstname,
                Middlename = entity.Middlename,
                Lastname = entity.Lastname,
                PollingUnit = entity.PollingUnit
            };
        }

        public async Task<Voter> AddAsync(Voter entity)
        {
            entity.CreatedOn = DateTime.UtcNow;
            _database.VoterTable.Add(entity);

            await Task.Delay(30000);

            return new Voter(entity.Registration_No, entity.Id)
            {
                HasVoted = entity.HasVoted,
                CreatedOn = entity.CreatedOn,
                ModifiedOn = entity.ModifiedOn,
                DateOfBirth = entity.DateOfBirth,
                Firstname = entity.Firstname,
                Middlename = entity.Middlename,
                Lastname = entity.Lastname,
                PollingUnit = entity.PollingUnit
            };
        }

        public bool Delete(Voter entity)
        {
            var voterToDelete = GetById(entity.Id);

            if (voterToDelete != null)
            {
                _database.VoterTable.Remove(voterToDelete);
                return true;
            }
            return false;
        }

        public Task<bool> DeleteAsync(Voter entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Voter> GetAll()
        {
            return _database.VoterTable.AsQueryable();
        }

        public Task<IQueryable<Voter>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Voter GetById(string id)
        {
            return _database.VoterTable.Where(Filter).FirstOrDefault();
        }

        private bool Filter(Voter voter)
        {
            return true;
        }

        public Task<Voter> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Voter entity)
        {
            var voterToUpdate = GetById(entity.Id);

            if (voterToUpdate != null)
            {
                #region UpdateRecord
                voterToUpdate.HasVoted = entity.HasVoted;
                voterToUpdate.Gender = entity.Gender;
                voterToUpdate.DateOfBirth = entity.DateOfBirth;
                voterToUpdate.Firstname = entity.Firstname;
                voterToUpdate.Lastname = entity.Lastname;
                voterToUpdate.Middlename = entity.Middlename;
                voterToUpdate.PollingUnit = entity.PollingUnit;
                voterToUpdate.ModifiedOn = DateTime.UtcNow;
                #endregion

                return true;
            }
            return false;
        }

        public Task<bool> UpdateAsync(Voter entity)
        {
            throw new NotImplementedException();
        }
    }
}
