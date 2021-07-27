using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPICore.Generics
{
    
        public interface IGenericRepository<TEntity> where TEntity : class
        {
            Task<TEntity> Get(long? Id);
            Task<IEnumerable<TEntity>> GetAll();
            Task<IEnumerable<TEntity>> GetAllByQuery(string query);
            Task<TEntity> GetOneByQuery(string query);
            Task<long> Add(TEntity entity);
        }
    }

