using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPICore.Generics;
using TestAPICore.Models;
using TestAPICore.UseCases;

namespace TestAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController:ControllerBase
    {
        private readonly ILogger<AuthorsController> _logger;
        readonly IGenericService<Author> _authorServices;
        public AuthorsController(IGenericService<Author> authorServices, ILogger<AuthorsController> logger)
        {
            _authorServices = authorServices; 
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAuthors()
        {
            var listOfAuthorsFromDb =await  _authorServices.GetAll();
            return listOfAuthorsFromDb==null ? NotFound() :  Ok(listOfAuthorsFromDb);
        }
    }
}
