using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    internal class PhoneBookSabitler
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public PhoneBookSabitler(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public PhoneBookSabitler()
        {

        }       
    }
}
