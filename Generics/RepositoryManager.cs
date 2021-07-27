using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Models;
using TestAPICore.UseCases;

namespace TestAPICore.Generics
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private AuthorRepository _authorRepository;
        public RepositoryManager(AppDbContext db)
        {
            _context = db;
        }
        public AuthorRepository AuthorRepository
        {
            get
            {
                if (_authorRepository == null) _authorRepository = new AuthorRepository(_context);
                return _authorRepository;
            }
}

    }
}
