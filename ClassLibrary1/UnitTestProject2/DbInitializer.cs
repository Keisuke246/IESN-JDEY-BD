using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                AccountBalance = 742.84,
                AdressLine1 = "Rue des Prés, 47",
                City = "Namur",
                Country = "Belgium",
                EMail = "bertrand.duchene@gmail.com",
                Id = 75849,
                Name = "Bertrand Duchêne",
                PostCode = "5000"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
