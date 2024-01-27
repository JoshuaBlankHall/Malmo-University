using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Hello from the Pet Class!");
            Console.WriteLine();

            ReadPetData();
            DisplayPetData();
        }
        private void ReadPetData()
        {
            //Here I will ask the user for his pets name and save it into a variable (string)

            Console.WriteLine("What's your pets name? ");
            name = Console.ReadLine();

            //Here I will ask the user for his pets age and save it into a variable (int)

            Console.WriteLine("What's " + name + "'s age?" + " Enter only numbers");
            string ageInString = Console.ReadLine();
            age = int.Parse(ageInString);

            //Here I will take ask the user for his pets gender and save his input into a variable to later use it as a bool

            Console.WriteLine("Is " + name + " female? Answer in (y/n) ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim().ToLower();
            char response = strGender[0];
 
            //Here I will create and If statement in which I ask the user 

            if ((response == 'y'))
                isFemale = true;
            else
                isFemale = false;
        }
        private void DisplayPetData()
        {
            Console.WriteLine();
            string textOut = "Name: " + name + " Age: " + age;
            Console.WriteLine(textOut);
            if (isFemale)
                Console.WriteLine(name + ": She is such a wonderful puppy!");
            else
                Console.WriteLine(name + ": He is such a wonderful puppy!");

        }
    }
}
