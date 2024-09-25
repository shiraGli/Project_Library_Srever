using Library.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Servise;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
        
    {
        private readonly ICustomerServise _customerServise;
        public LoginController(ICustomerServise customerServise)
        {
            _customerServise = customerServise; 
        }
        [HttpPost]   
        public Customer login([FromBody] loginPostModel model)
        {
            var user = _customerServise.GetNameAndPassord(model.Name, model.Password);
            if(user == null)
            {
                return null;
            }
            if (user.Password == "manager")
                return user;
            else
            {
                return user;
            }
        }
    }
}
