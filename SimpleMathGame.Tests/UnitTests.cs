using NumberGenerationAndAssignment;
namespace SimpleMathGame.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        [InlineData(333, 5)]
        [InlineData(1000, 5)]
        public void TestAddition(int numberLimit, int timeLimit)
        {
            // Checks that the result isn't higher than the number limit (mximum range of the math problems).
            GenerateNumbers generateNumbers = new GenerateNumbers(numberLimit, timeLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignNumbersAndResult additionProblem = generateNumbers.GenerateAdditionProblem();
                Assert.True(additionProblem.Number1 + additionProblem.Number2 == additionProblem.Result);
                Assert.True(additionProblem.Result <= generateNumbers.NumberLimit);
            }
        }
        [Theory]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        [InlineData(333, 5)]
        [InlineData(1000, 5)]
        public void TestSubtraction(int numberLimit, int timeLimit)
        {
            // Checks that the result isn't negative.
            GenerateNumbers generateNumbers = new GenerateNumbers(numberLimit, timeLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignNumbersAndResult subtractionProblem = generateNumbers.GenerateSubtractionProblem();
                Assert.True(subtractionProblem.Number1 - subtractionProblem.Number2 == subtractionProblem.Result);
                Assert.True(subtractionProblem.Result >= 0);
            }
        }
        [Theory]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        [InlineData(333, 5)]
        [InlineData(1000, 5)]
        public void TestMultiplication(int numberLimit, int timeLimit)
        {
            // Checks that the result isn't higher than the number limit (mximum range of the math problems).
            GenerateNumbers generateNumbers = new GenerateNumbers(numberLimit, timeLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignNumbersAndResult multiplicationProblem = generateNumbers.GenerateMultiplicationProblem();
                Assert.True(multiplicationProblem.Number1 * multiplicationProblem.Number2 == multiplicationProblem.Result);
                Assert.True(multiplicationProblem.Result <= generateNumbers.NumberLimit);
            }
        }
        [Theory]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        [InlineData(333, 5)]
        [InlineData(1000, 5)]
        public void TestDivision(int numberLimit, int timeLimit)
        {
            // Checks that the result is an integer and that the dividend is divisible by the divisor.
            GenerateNumbers generateNumbers = new GenerateNumbers(numberLimit, timeLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignNumbersAndResult divisionProblem = generateNumbers.GenerateDivisionProblem();
                Assert.True(divisionProblem.Number1 / divisionProblem.Number2 == divisionProblem.Result);
                Assert.True(divisionProblem.Number1 % divisionProblem.Number2 == 0);
            }
        }
    }
}