using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using ClassLibrary1;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count());
            }
        } 
        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }

        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void SimulateDatabaseChangeConflict()
        {   
            using(CompanyContext contexte1 = GetContext())
            {
                using(CompanyContext contexte2 = GetContext())
                {
                    var client1 = contexte1.Customers.First();
                    var client2 = contexte2.Customers.First();

                    client1.AccountBalance += 10;
                    contexte1.SaveChanges();
                    client2.AccountBalance += 20;
                    contexte2.SaveChanges();
                }
            }
            GetContext().Customers.First().AccountBalance += 10;
            GetContext().SaveChanges();
        }
        public CompanyContext GetContext()
        {
            return new CompanyContext();
        }
    }
}
