using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepTakes
{
    public class Manager
    {
        interface IManager
        {
            string firstName();
            string lastName();
            string email();
            string adress();
            string registrationNumber();

            string FirstName { get; set; }
            string LastName { get; set; }
            string Email { get; set; }
            string Adress { get; set; }
            string RegistrationNumber { get; set; }
        }
    }

}
