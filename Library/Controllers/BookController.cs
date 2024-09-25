using AutoMapper;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServise _bookServise;
        private readonly IMapper _mapper;
        public BookController(IBookServise bookServise, IMapper mapper)
        {
            _bookServise = bookServise;
            _mapper = mapper;
        }
        // GET: api/<BookController>
        [HttpGet]
        public ActionResult<Book> Get()
        {
            var list = _bookServise.GetBook();
            var listDto = _mapper.Map<IEnumerable<BookDto>>(list);
            return Ok(_bookServise.GetBook());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult<BookDto> Get(int id)
        {
            var book = _bookServise.GetIdBook(id);
            var bookDto = _mapper.Map<BookDto>(book);

            if (book != null)
                return bookDto;
            return NotFound();
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] BookPostModel b)
        {
            var book = _mapper.Map<Book>(b);
            _bookServise.AddBook(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public Book Put(int id, [FromBody] int count)
        {
            var book = _bookServise.GetIdBook(id);
            book.Count = count;
            return _bookServise.updateBook(id,count);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookServise.DeleteBook(id);
        }
    }
}