using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Models;

namespace TestAPICore.Generics
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _db;
        private readonly DbSet<TEntity> _DbSet;
        public GenericRepository(AppDbContext dbContext)
        {
            _db = dbContext;
            _DbSet = dbContext.Set<TEntity>();
        }

        #region CRD Operation
        public async Task<long> Add(TEntity entity)
        {
            try
            {
                await _DbSet.AddAsync(entity);
                var id = await _db.SaveChangesAsync();
                return id;

            }
            catch (Exception e)
            {

                throw;
            }

        }

        public async Task<long> Update(TEntity entity)
        {
            //_DbSet.Update(entity);
            var result = await _db.SaveChangesAsync();
            return result;
        }

        public async Task<long> Delete(TEntity entity)
        {

            _DbSet.Remove(entity);
            var id = await _db.SaveChangesAsync();
            return id;
        }



        #endregion
        public async Task<TEntity> Get(long? Id)
        {
            try
            {
                var entity = await _DbSet.FindAsync(Id);

                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {

            var result = await _DbSet.AsNoTracking().ToListAsync();
            return result;
        }


        public Task<IEnumerable<TEntity>> GetAllByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetOneByQuery(string query)
        {
            throw new NotImplementedException();
        }


    }
}
