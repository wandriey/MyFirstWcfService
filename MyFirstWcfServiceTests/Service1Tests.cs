using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWcfService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void getMyEmailTest()
        {
            //Arrange
            var service1 = new Service1();

            //act
            string email = service1.getMyEmail();

            //Assert
            Assert.AreEqual("jonasmanley@hotmail.com", email);
        }

        [TestMethod()]
        public void getMyNameTest()
        {
            Assert.Fail();
        }
    }
}