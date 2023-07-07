using System;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;

namespace newproject.Steps
{
    
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        
       CalculatorApp calc = new CalculatorApp();

       int number1, number2;
       int output;

       [Given("the first number is (.*)")]
       public void GivenTheFirstNumberIs(int num1)
       {
           number1 = num1;
       }

       [Given("the second number is (.*)")]
       public void GivenTheSecondNumberIs(int num2)
       {
           number2 = num2;
        }
        
       [When("the two numbers are added")]
       public void WhenTheTwoNumbersAreAdded()
       {
           output = calc.add(number1, number2);
       }

       [Then("the result should be (.*)")]
       public void ThenTheResultShouldBe(int result)
       {
          Assert.AreEqual(result, output);
       }
    }
}
