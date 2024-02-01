using SomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SomeWork.Tests
{
    public class DataAccessTest
    {
        [Fact]
        public void AddPerson_ShouldWork()
        {
            List<PersonModel> people = new List<PersonModel>();
            PersonModel model = new PersonModel() { FirstName = "Ak", LastName = "Jp" };

            DataAccess.AddPersonToPeopleList(people, model);

            Assert.True(people.Count() > 0);
            Assert.Contains(model, people);
        }

        [Theory]
        [InlineData("Jim", "", "LastName")]
        [InlineData("", "Peery", "FirstName")]
        public void AddPerson_ShouldFail(string firstname, string lastnaem, string param)
        {
            List<PersonModel> people = new List<PersonModel>();
            PersonModel model = new PersonModel() { FirstName = firstname, LastName = lastnaem };


            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, model));
        }

    }
}
