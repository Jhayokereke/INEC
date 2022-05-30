using Core.Contracts;
using Data;
using Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Persistence
{
    public class PollingUnitRepository : IPollingUnitRepository
    {
        private readonly Database _database;

        public PollingUnitRepository(Database database)
        {
            _database = database;
        }

        public PollingUnit Add(PollingUnit entity)
        {
            entity.CreatedOn = DateTime.UtcNow;
            _database.PollingUnitTable.Add(entity);
            return new PollingUnit(entity.LocalGovernment, entity.Unit_No, entity.Id)
            {
                CreatedOn = entity.CreatedOn,
                Voters = entity.Voters
            };
        }

        public bool Delete(PollingUnit entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PollingUnit> GetAll()
        {
            return _database.PollingUnitTable.AsQueryable();
        }

        public PollingUnit GetById(string id)
        {
            return _database.PollingUnitTable.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(PollingUnit entity)
        {
            throw new NotImplementedException();
        }
    }
}
