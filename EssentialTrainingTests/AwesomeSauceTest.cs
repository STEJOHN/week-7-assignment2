using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //expect to pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            //expect false
            Assert.IsTrue(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
