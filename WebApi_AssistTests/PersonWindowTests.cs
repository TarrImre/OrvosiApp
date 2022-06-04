using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApi_Client.Tests
{
    [TestClass()]
    public class PersonWindowTests
    {
        [TestMethod()]
        public void ValidatePerson_Name()
        {
            //Lehetséges jók
            Assert.IsTrue(PersonWindow.regexName.IsMatch("Tarr Imre"));
            Assert.IsTrue(PersonWindow.regexName.IsMatch("Végvári Richárd Sándor"));
            Assert.IsTrue(PersonWindow.regexName.IsMatch("Ifj. Nagy Béla"));

            //Lehetséges rosszak
            Assert.IsFalse(PersonWindow.regexName.IsMatch("Tarr Imre "));
            Assert.IsFalse(PersonWindow.regexName.IsMatch(" Tarr Imre"));
            Assert.IsFalse(PersonWindow.regexName.IsMatch("123"));
            Assert.IsFalse(PersonWindow.regexName.IsMatch("  "));
            Assert.IsFalse(PersonWindow.regexName.IsMatch(""));
            Assert.IsFalse(PersonWindow.regexName.IsMatch("?"));
        }

        [TestMethod()]
        public void ValidatePerson_Cardnum()
        {
            //Lehetséges jók
            Assert.IsTrue(PersonWindow.regexCardNum.IsMatch("123 456 789"));
            Assert.IsTrue(PersonWindow.regexCardNum.IsMatch("000 000 000"));

            //Lehetséges rosszak
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch("000 000 000 "));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch(" 000 000 000"));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch(" "));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch(""));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch("??"));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch("Teszt"));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch("a000 000 000"));
            Assert.IsFalse(PersonWindow.regexCardNum.IsMatch("000 000 000a"));
        }

        [TestMethod()]
        public void ValidatePerson_StreetHouse()
        {
            //Lehetséges jók
            Assert.IsTrue(PersonWindow.regexStreetHouse.IsMatch("Széchenyi 17"));
            Assert.IsTrue(PersonWindow.regexStreetHouse.IsMatch("Széchenyi 18."));
            Assert.IsTrue(PersonWindow.regexStreetHouse.IsMatch("Széchenyi út 19"));
            Assert.IsTrue(PersonWindow.regexStreetHouse.IsMatch("Széchenyi út 20/B"));
            Assert.IsTrue(PersonWindow.regexStreetHouse.IsMatch("Széchenyi 21/B"));

            //Lehetséges rosszak
            Assert.IsFalse(PersonWindow.regexStreetHouse.IsMatch("22"));
            Assert.IsFalse(PersonWindow.regexStreetHouse.IsMatch("Széchenyi"));
            Assert.IsFalse(PersonWindow.regexStreetHouse.IsMatch("??"));
            Assert.IsFalse(PersonWindow.regexStreetHouse.IsMatch(""));
            Assert.IsFalse(PersonWindow.regexStreetHouse.IsMatch(" "));
        }
    }
}