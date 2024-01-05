using System;
using TechTalk.SpecFlow;
using Calculator;

namespace SpecFlowProjectAssessment.StepDefinitions
{
    [Binding]
    public class Calculator1StepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly CalcOperations calculator;
        private int result;

        public Calculator1StepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new CalcOperations();

        }
        [Given(@"The first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calculator.Fnum = p0;
        }

        [Given(@"The second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            calculator.Snum =p0;
        }

        [When(@"The two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calculator.Sub();
        }

        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(p0);
        }

        [When(@"The two numbers are Multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            result = calculator.Mul();
        }

        [When(@"The two numbers are Divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Div();
        }
    }
}
