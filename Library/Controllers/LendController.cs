using AutoMapper;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Servise;
using Solid.Servise;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendController : ControllerBase
    {
        private readonly ILendServise _lendServise;
        private readonly IMapper _mapper;

        public LendController(ILendServise lendServise,IMapper mapper)
        {
            _lendServise = lendServise;
            _mapper = mapper;   
        }
        // GET: api/<LendController>
        [HttpGet]
        public ActionResult<Lend> Get()
        {
            var list=_lendServise.GetLend();
            var listDto = _mapper.Map<IEnumerable<LendDto>>(list);
            return Ok(listDto);
        }
        // GET api/<LendController>/5
        [HttpGet("{id}")]
        public ActionResult<LendDto>Get(int id)
        {
            var lend = _lendServise.GetIdLend(id);
            var lendDto = _mapper.Map<LendDto>(lend);
            if (lend != null)
                return lendDto;
            return NotFound();
        }

        // POST api/<LendController>
        [HttpPost]
        public int Post([FromBody] LendPostModel l)
        {
            var lend = _mapper.Map<Lend>(l);
            _lendServise.addLend(lend);
            return lend.Id;
        }
        //public void Post([FromBody] CustomerPostModel c,DateTime d)
        //{
        //    var customer = _mapper.Map<Customer>(c);
        //    _lendServise.addLend(customer,d);
        //}

        // PUT api/<LendController>/5
        [HttpPut("{id}")]
        public Lend Put(int id, [FromBody] int counter)
        {
            //var lend = _lendServise.GetIdLend(id);
            //lend.Count_Book = counter;
            return _lendServise.updatelend(id, counter);
        }

        // DELETE api/<LendController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _lendServise.DeleteLend(id);
        }
        
    }
}
