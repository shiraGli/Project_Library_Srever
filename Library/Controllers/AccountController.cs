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
    public class AccountController : ControllerBase
    {
        private readonly IAccountServise _accountServise;
        private readonly IMapper _mapper;
        public AccountController(IAccountServise accountServise,IMapper mapper)

        {
            _accountServise = accountServise;
            _mapper = mapper;   
        }
        
      
       
            // GET: api/<AccountController>
        [HttpGet]
        public ActionResult<AccountDto>Get()
        {
                var list = _accountServise.GetAccount();
                var listDto = _mapper.Map<IEnumerable<AccountDto>>(list);
            return Ok(listDto);
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public ActionResult<AccountDto> Get(int id)
            {
            var account = _accountServise.GetIdAccount(id);
            var accountDto = _mapper.Map<AccountDto>(account);
                if (account != null)
                   return accountDto;
            return NotFound();
             }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] AccountPostModel a)
        
        {
            var account = _mapper.Map<Account>(a);
            _accountServise.AddAccount(account);
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public Account Put(int id, [FromBody] Boolean flag)
        {
            //var accoun = _accountServise.GetIdAccount(id);
            //book.Count = count;
            return _accountServise.updateAccount(id, flag);
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _accountServise.DeleteAccount(id);
        }
    }
    }
       
//        public Account ConvertAccount2lToAccount(Account2 cm)
//        {
//            return new Account()
//            {
//                Id = cm.Id,
//                pay = cm.pay,
//                Month = cm.Month,
//                CustomerId = cm.CustomerId
//            };
//        }

//        public Account2 ConvertAccountToAccount2(Account c)
//        {
//            return new Account2()
//            {
//                Id = c.Id,
//                pay = c.pay,
//                Month = c.Month,
//                CustomerId = c.CustomerId
//            };
//        }

//        public List<Account> ConvertListAccount2ToListAccount(List<Account2> lc)
//        {
//            List<Account> list = new List<Account>();
//            foreach (Account2 item in lc)
//            {
//                list.Add(ConvertAccount2lToAccount(item));
//            }
//            return list;
//        }
//        public List<Account2> ConvertListClientToListModel(List<Account> lc)
//        {
//            List<Account2> list = new List<Account2>();
//            foreach (Account item in lc)
//            {
//                list.Add(ConvertAccountToAccount2(item));
//            }
//            return list;
//        }

//    }
//}
