using System;

namespace web_api_simpsons.Modules
{

    public class Character
    {
        Int64 id;

        string firstName;
        string secondName;
        string lastName;
        string nickName;
        int age;
        //int height;
        //int weight;
        string gender;
        string birthDate;
        string ocupation;
        string description;

        public Character(){}

        public Character(Int64 id, string firstName, string secondName, string lastName, string nickName, int age, string gender, string birthDate, string photo, string ocupation, string description)
        {
            this.id = id;
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.nickName = nickName;
            this.age = age;
            this.gender = gender;
            this.birthDate = birthDate;
            this.ocupation = ocupation;
            this.description = description;
        }

        public string FirstName 
        { 
            get => firstName; 
            set => firstName = value; 
        }
        public string SecondName 
        { 
            get => secondName; 
            set => secondName = value; 
        }
        public string LastName 
        { 
            get => lastName; 
            set => lastName = value; 
        }
         public string NickName 
        { 
            get => nickName; 
            set => nickName = value; 
        }
        public int Age 
        { 
            get => age; 
            set => age = value; 
        }
        public string Gender 
        { 
            get => gender; 
            set => gender = value; 
        }
        public string BirthDate 
        { 
            get => birthDate; 
            set => birthDate = value; 
        }
        public string Ocupation 
        { 
            get => ocupation; 
            set => ocupation = value; 
        }
        public string Description      
        { 
            get => description; 
            set => description = value; 
        }
        public Int64 Id 
        { 
            get => id; 
            set => id = value; 
        }

    }


}