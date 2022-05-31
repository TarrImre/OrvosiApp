using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Person.tests
{
    [TestClass]
    public class ProjectUnitTest
    {
       
        [TestMethod]

        public void TestMethod()

        {

            //Arrange test

            testClass objtest = new testClass();

            Boolean result;



            //Act test

            result = objtest.testFunction();



            //Assert test

            Assert.AreEqual(true, result);



        }
    }
}