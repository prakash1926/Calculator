Feature: Calculator1
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectAssessment/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag


	Scenario: Subtract two numbers
	Given The first number is 70
	And The second number is 50
	When The two numbers are Subtracted
	Then The result should be 20

	Scenario: Multiple two numbers
	Given The first number is 5
	And The second number is 10
	When The two numbers are Multiply
	Then The result should be 50

	Scenario: Divid two numbers
	Given The first number is 36
	And The second number is 6
	When The two numbers are Divided
	Then The result should be 6