using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Generics;
using TestAPICore.Models;

namespace TestAPICore.UseCases
{
    public class AuthorRepository : GenericRepository<Author>
    {
        AppDbContext db;
        public AuthorRepository(AppDbContext dbContext) : base(dbContext)
        {
            db = dbContext;
        }

    }
}
