using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskName
{
    public class Person : PersonManager
    {
        public Guid Id { get; set; }

        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (CheckCharacter(value) == true)
                {

                    _firstName = value;
                    Console.WriteLine($" {MaskName(_firstName)} has successfully been added");
                }
                else
                {
                    Console.WriteLine("Please enter valid information for all fields. Please enter only letters and at least 2 letters.");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (CheckCharacter(value) == true)
                {
                    _lastName = value;
                    Console.WriteLine($" {MaskName(_lastName)} has successfully been added");
                }
                else
                {
                    Console.WriteLine("Surname is not valid. Please enter only letters.");
                }
            }
        }


    }
}
