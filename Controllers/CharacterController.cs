using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web_api_simpsons.Modules; //Ligar al caracter y ligar a la interfase
using web_api_simpsons.Dependencies;
using Microsoft.AspNetCore.Cors;

namespace web_api_simpsons.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacters => new List<Character>
        {
            new Character
            {
                FirstName = "Homero",
                SecondName = "Jay",
                LastName = "Simpsons",
                Age = 34
            },
        

            new Character{
                FirstName = "Margory", 
                SecondName = "Simpson", 
                Age = 36, 
                Description = "Esposa de Homero, Madre de la familia Simpson.",
                Photo = "http://pluspng.com/img-png/marge-simpson-hd-png-marge-simpson-2-png-1220.png"         
            },

            new Character{
                FirstName = "Bart", 
                SecondName = "Simpson", 
                Age = 10, 
                Description = "Hermano de Lisa y Maggie Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png"         
            },

            new Character{
                FirstName = "Lisa", 
                SecondName = "Simpson", 
                Age = 9, 
                Description = "Hermana de Bart y Maggie Simpsons.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Lisa_Simpson.png/220px-Lisa_Simpson.png"         
            },

            new Character{
                FirstName = "Maggie", 
                SecondName = "Simpson", 
                Age = 2, 
                Description = "Hermana de Bart y Lisa Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Maggie_Simpson.png/220px-Maggie_Simpson.png"         
            },
        };

        [HttpGet("{id}")]

        public Character GetCharacter(int id)
        {
            return listOfCharacters[id];
        }

        [HttpGet]

        public List<Character> GetCharacterList()
        {
            return listOfCharacters;
        }

    }
}