using Microsoft.AspNetCore.Mvc;
using Monolith.Data;
using Monolith.Models;

namespace MonolithicAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly ILogger<AuthorsController> _logger;
        private readonly Repository _repository;

        public AuthorsController(ILogger<AuthorsController> logger, Repository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Author> Get() => _repository.GetAuthors();
    }
}
