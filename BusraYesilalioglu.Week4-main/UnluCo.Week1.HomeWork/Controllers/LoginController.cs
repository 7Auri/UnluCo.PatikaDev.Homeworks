
using Microsoft.AspNetCore.Mvc;
using UnluCo.Week1.HomeWork.Models;

namespace UnluCo.Week1.HomeWork.Controllers
{
    /* {"personname":"busra",
       "email":"test@test.com",
       "password":"test",
       "confirmpassword":"test" }*/
    //Login'den tokeni almak için body'e girileceklerdir.


    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TokenGenerator _tokenGenerator;
        public LoginController(TokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost]
        public Token Login([FromBody] Person person)
        {
            Token token = new Token();
            if (person.Password == "test" && person.Email == "test@test.com")
            {
                token = _tokenGenerator.CreateToken(person);
            }

            return token;
        }
    }
}
