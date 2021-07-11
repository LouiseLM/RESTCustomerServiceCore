using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTCustomerServiceCore.Controllers;
using RESTCustomerServiceCore.Models;
using System.Collections.Generic;

namespace UnitTestCustService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetAll()
        {
            CustomerController cc = new CustomerController();
            List<Customer> cList = cc.Get();
            Assert.AreEqual(3, cList.Count);
        }

        [TestMethod]
        public void TestGetOne()
        {
            CustomerController cc = new CustomerController();
            Customer c1 = cc.Get(1);
            Assert.AreEqual(c1.ID, 1);
            Assert.AreEqual(c1.FirstName, "Peter");

            Customer c2 = cc.Get(3);
            Assert.IsNull(c2);
        }

        [TestMethod]
        public void TestPost()
        {
            CustomerController cc = new CustomerController();
            List<Customer> cList = cc.Get();
            int preCount = cList.Count;

            Customer c = new Customer("Ny", "Ny", 1955);
            cc.InsertCustomer(c);


            Assert.AreEqual(preCount + 1, cList.Count);
        }

        [TestMethod]
        public void TestDelete()
        {
            CustomerController cc = new CustomerController();
            cc.DeleteCustomer(1);
            Customer c1 = cc.Get(1);
            Assert.IsNull(c1);
            //Slet Customer
            //Hent Customer
            //Is Null?
        }


    }
}
