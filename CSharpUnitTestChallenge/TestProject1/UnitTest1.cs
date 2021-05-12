using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpUnitTestChallenge.Library;
using CSharpUnitTestChallenge.Library.Validations;
using CSharpUnitTestChallenge;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidate()
        {
            
            try
            {
                ValidateMonthlyBudget valMonBud = new CSharpUnitTestChallenge.Library.Validations.ValidateMonthlyBudget();
                MonthlyBudget actual = Input.ActualValues();
                Tuple<bool, MonthlyBudget> expected;
                expected = valMonBud.Validate(actual.FirstName,actual.LastName,actual.DateOfBirth.ToString(),actual.PetFoodCost.ToString(),actual.NumberOfPets.ToString());
                Assert.AreEqual(expected.Item1, true);
                Assert.IsNotNull(expected);                               
            }
            catch(AssertFailedException)
            {               
                    throw new AssertFailedException();
               
             }
        }
        [TestMethod]
        public void TestAdapt()
        {
            try
            {
                MonthlyBudget actual = Input.ActualValues();
                actual.Adapt();
                Assert.AreEqual("110", actual.AvergeCostPerPet.ToString());
            }
            catch (AssertFailedException)
            {
                throw new AssertFailedException();
            }
        }                    
    }
}
