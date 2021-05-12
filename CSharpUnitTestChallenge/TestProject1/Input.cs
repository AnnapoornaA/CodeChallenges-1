using System;
using System.Collections.Generic;
using System.Text;
using CSharpUnitTestChallenge.Library;
using CSharpUnitTestChallenge.Library.Validations;
using CSharpUnitTestChallenge;


namespace TestProject1
{
    public static class Input
    {
        public static MonthlyBudget ActualValues()
        {
            MonthlyBudget actual=new MonthlyBudget();
            actual.FirstName = "Anna";
            actual.LastName = "Phelange";
            actual.DateOfBirth = Convert.ToDateTime("01/01/1984");
            actual.PetFoodCost = 1100;
            actual.NumberOfPets = 10;
            return actual;

        }
    }
}
