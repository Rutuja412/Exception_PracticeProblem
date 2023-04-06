using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exception_Handlind;

namespace CategoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_For_Children_Age_Group()
        {
           
            int age = 3;
            string expected = "Children";
           
            string actual = ValidateAge.CheckCategory(age);
           
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_For_Youth_Age_Group()
        {
            int age = 16;
            string expected = "Youth";

            string actual = ValidateAge.CheckCategory(age);

            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Test_For_Adults_Age_Group()
        {
            int age = 38;
            string expected = "Adults";

            string actual = ValidateAge.CheckCategory(age);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_For_Seniors_Age_Group()
        {
            int age = 75;
            string expected = "Seniors";

            string actual = ValidateAge.CheckCategory(age);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_For_Invalid_Age()
        {
          
            int age = -1;
            string expected = "Error : Age should not be less than 1";

            string actual = ValidateAge.CheckCategory(age);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
