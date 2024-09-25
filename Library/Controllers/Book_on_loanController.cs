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
    public class Book_on_loanController : ControllerBase
    {
        private readonly IBook_on_loanServise _book_On_LoanServise;
        private readonly IMapper _mapper;

        public Book_on_loanController(IBook_on_loanServise book_On_LoanServise,IMapper mapper)
        {
            _book_On_LoanServise = book_On_LoanServise;
            _mapper = mapper;
        }
        // GET: api/<Book_on_loanController>
        [HttpGet]
        public ActionResult<Books_on_loan> Get()
        {
            var list=_book_On_LoanServise.GetBooks_on_loan();
            var listDto=_mapper.Map<IEnumerable<BookOnLoanDto>>(list);
            return Ok(listDto);
        }

        // GET api/<Book_on_loanController>/5
        [HttpGet("{id}")]
        public ActionResult<BookOnLoanDto> Get(int id)
        {
            var bookOnLoan = _book_On_LoanServise.GetIdBoookOnLoan(id);
            var bookOnLoanDto = _mapper.Map<BookOnLoanDto>(bookOnLoan);
            if (bookOnLoan != null)
                return bookOnLoanDto;
            return NotFound();
        }

        // POST api/<Book_on_loanController>
        [HttpPost]
        public int Post([FromBody] BookOnLoanPostModel books)
        {
            var bookOnLoan = _mapper.Map<Books_on_loan>(books);
            _book_On_LoanServise.AddBookOnLoan(bookOnLoan);
            return bookOnLoan.Id;
        }

        // PUT api/<Book_on_loanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] int count)
        {

        }

        // DELETE api/<Book_on_loanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _book_On_LoanServise.DeleteBookOnLoan(id);
        }
        //    public Books_on_loan ConvertBooks_on_loan2ToBooks_on_loan(Books_on_loan2 cm)
        //    {

        //        return new Books_on_loan()
        //        {
        //            Id = cm.Id,
        //            BookId = cm.BookId,
        //            LendId = cm.LendId,
        //        };
        //    }

        //    public Books_on_loan2 ConvertBooks_on_loanToBooks_on_loan2(Books_on_loan c)
        //    {
        //        return new Books_on_loan2()
        //        {
        //            Id = c.Id,
        //            BookId = c.BookId,
        //            LendId = c.LendId,
        //        };
        //    }

        //    public List<Books_on_loan> ConvertListModelToListClient(List<Books_on_loan2> lc)
        //    {
        //        List<Books_on_loan> list = new List<Books_on_loan>();
        //        foreach (Books_on_loan2 item in lc)
        //        {
        //            list.Add(ConvertBooks_on_loan2ToBooks_on_loan(item));
        //        }
        //        return list;
        //    }
        //    public List<Books_on_loan2> ConvertListBooks_on_loanToListBooks_on_loan2(List<Books_on_loan> lc)
        //    {
        //        List<Books_on_loan2> list = new List<Books_on_loan2>();
        //        foreach (Books_on_loan item in lc)
        //        {
        //            list.Add(ConvertBooks_on_loanToBooks_on_loan2(item));
        //        }
        //        return list;
        //    }

        //}
    }
}
