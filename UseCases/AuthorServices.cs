using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Generics;
using TestAPICore.Models;

namespace TestAPICore.UseCases
{
    public class AuthorServices : IGenericService<Author>
    {
        readonly IRepositoryManager _manager;
        public AuthorServices(IRepositoryManager manager) 
        {
            _manager = manager;
        }

        public Task<long> Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Get(long? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _manager.AuthorRepository.GetAll();
        }

        public Task<IEnumerable<Author>> GetAllByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetOneByQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
