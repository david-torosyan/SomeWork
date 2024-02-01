using SomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonModel model = new PersonModel()
            {
                FirstName = "Name",
                LastName = "Surname"
            };

            DataAccess.AddNewPerson(model);
        }
    }
}
