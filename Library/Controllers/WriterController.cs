using AutoMapper;
using Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterServise _writerServise;
        private readonly IMapper _mapper;
        public WriterController(IWriterServise writerServise,IMapper mapper)
        {
            _writerServise = writerServise;
            _mapper = mapper;   
        }
        // GET: api/<WriterController>
        [HttpGet]
        public ActionResult<WriterDto> Get()
        {
            var list = _writerServise.GetWriter();
            var listDto = _mapper.Map < IEnumerable < WriterDto >>(list);
            return Ok(listDto);
        }

        // GET api/<WriterController>/5
        [HttpGet("{id}")]
        public ActionResult<WriterDto> Get(int id)
        {
            var writer=_writerServise.GetIdWriter(id);
            var writerDto=_mapper.Map<WriterDto>(writer);   
            if (writer != null)
                return writerDto;
            return NotFound();
        }

        // POST api/<WriterController>
        [HttpPost]
        public void Post([FromBody] WriterPostModel w)
        {
            var writer=_mapper.Map<Writer>(w);
            _writerServise.AddWriter(writer);
        }

        // PUT api/<WriterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WriterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _writerServise.DeleteWriter(id);    
        }
        //    public Writer ConvertModelToClient(Writer2 cm)
        //    {
        //        return new Writer()
        //        {
        //            id = cm.id,
        //            name = cm.name
        //        };
        //    }

        //    public Writer2 ConvertClientToModel(Writer c)
        //    {
        //        return new Writer2()
        //        {
        //            id = c.id,
        //            name = c.name
        //        };
        //    }

        //    public List<Writer> ConvertListModelToListClient(List<Writer2> lc)
        //    {
        //        List<Writer> list = new List<Writer>();
        //        foreach (Writer2 item in lc)
        //        {
        //            list.Add(ConvertModelToClient(item));
        //        }
        //        return list;
        //    }
        //    public List<Writer2> ConvertListClientToListModel(List<Writer> lc)
        //    {
        //        List<Writer2> list = new List<Writer2>();
        //        foreach (Writer item in lc)
        //        {
        //            list.Add(ConvertClientToModel(item));
        //        }
        //        return list;
        //    }

        //}
    }
}