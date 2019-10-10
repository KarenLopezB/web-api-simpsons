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
                LastName = "Simpson",
                Age = 34
                Gender = "Masculino",
                BirthDate = "12 de Mayo de 1956",
                Ocupation = "Inspector de seguridad de la planta de energía nuclear de Springfield.",
                Description = "Esposo de Marge y padre de Bart, Lisa y Maggie Simpson.",
                Photo = "http://static.t13.cl/images/sizes/1200x675/1455720735-19-homer.jpg",
            },
        

            new Character{
                FirstName = "Marjorie", 
                SecondName = "Bouvier", 
                LastName = "Simpson",
                NickName = "Marge",
                Age = 36, 
                Gender = "Femenino",
                BirthDate = "19 de Noviembre de 1954",
                Ocupation = "Ama de casa",
                Description = "Esposa de Homero, Madre de la familia Simpson.",
                Photo = "http://pluspng.com/img-png/marge-simpson-hd-png-marge-simpson-2-png-1220.png"         
            },

            new Character{
                FirstName = "Bartholomeo", 
                SecondName = "Jorge", 
                LastName = "Simpson"
                NickName = "Bart",
                Age = 10, 
                Gender = "Masculino",
                BirthDate = "13 de Diciembre de 1981",
                Ocupation = "Estudiante de la escuela primaria (cuarto grado) de Springfield.",
                Description = "Hermano de Lisa y Maggie Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png"         
            },

            new Character{
                FirstName = "Lisa", 
                SecondName = "Marie", 
                LastName = "Simpson",
                Age = 8, 
                Gender = "Femenino",
                BirthDate = "1984",
                Ocupation = "Estudiante de la escuela primaria de Springfield.",
                Description = "Hermana de Bart y Maggie Simpsons.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Lisa_Simpson.png/220px-Lisa_Simpson.png"         
            },

            new Character{
                FirstName = "Margaret", 
                SecondName = "Abigail", 
                LastName = "Simpson",
                NickName = "Maggie",
                Age = 1, 
                Gender = "Femenino",
                BirthDate = "1991",
                Description = "Hermana de Bart y Lisa Simpson.",
                Photo = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Maggie_Simpson.png/220px-Maggie_Simpson.png"         
            },

            new Character{
                FirstName = "Charles", 
                SecondName = "Montgomery",
                LastName = "Burns",
                NickName = "Sr. Burns",
                Gender = "Masculino",
                BirthDate = "1903",
                Ocupation = "Dueño de la Central nuclear de Springfield.",
                Description = "Es el ciudadano más rico, poderoso y anciano de Springfield, propietario de la Planta de energía nuclear de Springfield y por lo tanto jefe de Homero Simpson.",
                Photo = ""         
            },

            new Character{
                FirstName = "Milhouse", 
                SecondName = "Mussolini", 
                LastName = "Van Houten",
                Age = 10, 
                Gender = "Marculino",
                Ocupation = "Estudiante de la escuela primaria (cuarto grado) de Springfield.",
                Description = "Es compañero de Bart Simpson en la clase de la profesora Edna Krabappel y secretamente está muy enamorado de Lisa y sueña llegar a adulto y cortejarla para luego casarse.",
                Photo = ""         
            },

            new Character{
                FirstName = "", 
                SecondName = "", 
                LastName = "",
                NickName = "",
                Age = , 
                Gender = "",
                BirthDate = "",
                Ocupation = "",
                Description = "",
                Photo = ""         
            },

            new Character{
                FirstName = "", 
                SecondName = "", 
                LastName = "",
                NickName = "",
                Age = , 
                Gender = "",
                BirthDate = "",
                Ocupation = "",
                Description = "",
                Photo = ""         
            },

            new Character{
                FirstName = "", 
                SecondName = "", 
                LastName = "",
                NickName = "",
                Age = , 
                Gender = "",
                BirthDate = "",
                Ocupation = "",
                Description = "",
                Photo = ""         
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