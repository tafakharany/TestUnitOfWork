using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.UseCases;

namespace TestAPICore.Generics
{
    public interface IRepositoryManager
    {
        public AuthorRepository AuthorRepository { get; }
    }
}
