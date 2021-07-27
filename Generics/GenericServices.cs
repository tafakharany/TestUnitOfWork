using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Models;

namespace TestAPICore.Generics
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly AppDbContext _dbConnection;
        private readonly GenericRepository<TEntity> _repository;
        //private readonly IRepositoryManager<TEntity> _repository;

        public GenericService(AppDbContext dbConnection) //, IRepositoryManager manager)
        {
            _dbConnection = dbConnection;
            _repository = new GenericRepository<TEntity>(_dbConnection);
            //_repository = manager;
        }

        #region CRD Operation
        public async Task<long> Add(TEntity entity)
        {

            return await _repository.Add(entity);
        }

        public virtual async Task<long> Update(TEntity entity)
        {
            return await _repository.Update(entity);
        }


        public async Task<long> Delete(TEntity entity)
        {

            return await _repository.Delete(entity);

        }




        #endregion



        public async Task<TEntity> Get(long? Id)
        {
            try
            {
                return await _repository.Get(Id);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public async Task<IEnumerable<TEntity>> GetAll()
        {

            return await _repository.GetAll();

        }



        public async Task<IEnumerable<TEntity>> GetAllByQuery(string query)
        {
            var list = await _repository.GetAllByQuery(query);
            return list;
        }

        public async Task<TEntity> GetOneByQuery(string query)
        {

            var one = await _repository.GetOneByQuery(query);
            return one;
        }


    }
}
