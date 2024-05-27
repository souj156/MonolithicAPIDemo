using Microsoft.AspNetCore.Mvc;
using Monolith.Data;
using Monolith.Models;

namespace MonolithicAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly Repository _repository;

        public BooksController(ILogger<BooksController> logger, Repository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Book> Get() => _repository.GetBooks();
    }
}
