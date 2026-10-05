using AutoMapper;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.REPOs.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork db;
        private readonly IMapper map;
        private readonly ICustomRepo<Book> cust;
        public BooksController(IUnitOfWork _db, IMapper _map, ICustomRepo<Book> _cust)
        {
            db = _db;
           map = _map;
            cust = _cust;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public IActionResult GetAll()
        {
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            
        }

        // POST api/<BooksController>
        [HttpPost]
        public IActionResult Create()
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public IActionResult Put()
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
