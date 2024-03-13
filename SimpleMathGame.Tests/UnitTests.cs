using NumberGenerationAndAssignment;
namespace SimpleMathGame.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(333)]
        [InlineData(1000)]
        public void TestAddition(int numberLimit)
        {
            // Checks that the result isn't higher than the number limit (maximum range of the math problems).
            NumbersGenerator generateNumbers = new NumbersGenerator(numberLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignedNumbersAndResult additionProblem = generateNumbers.GenerateAdditionProblem();
                Assert.True(additionProblem.Number1 + additionProblem.Number2 == additionProblem.Result);
                Assert.True(additionProblem.Result <= generateNumbers.NumberLimit);
            }
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(333)]
        [InlineData(1000)]
        public void TestSubtraction(int numberLimit)
        {
            // Checks that the result isn't negative.
            NumbersGenerator generateNumbers = new NumbersGenerator(numberLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignedNumbersAndResult subtractionProblem = generateNumbers.GenerateSubtractionProblem();
                Assert.True(subtractionProblem.Number1 - subtractionProblem.Number2 == subtractionProblem.Result);
                Assert.True(subtractionProblem.Result >= 0);
            }
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(333)]
        [InlineData(1000)]
        public void TestMultiplication(int numberLimit)
        {
            // Checks that the result isn't higher than the number limit (mximum range of the math problems).
            NumbersGenerator generateNumbers = new NumbersGenerator(numberLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignedNumbersAndResult multiplicationProblem = generateNumbers.GenerateMultiplicationProblem();
                Assert.True(multiplicationProblem.Number1 * multiplicationProblem.Number2 == multiplicationProblem.Result);
                Assert.True(multiplicationProblem.Result <= generateNumbers.NumberLimit);
            }
        }
        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(333)]
        [InlineData(1000)]
        public void TestDivision(int numberLimit)
        {
            // Checks that the result is an integer and that the dividend is divisible by the divisor.
            NumbersGenerator generateNumbers = new NumbersGenerator(numberLimit);
            for (int i = 0; i < 100; i++)
            {
                AssignedNumbersAndResult divisionProblem = generateNumbers.GenerateDivisionProblem();
                Assert.True(divisionProblem.Number1 / divisionProblem.Number2 == divisionProblem.Result);
                Assert.True(divisionProblem.Number1 % divisionProblem.Number2 == 0);
            }
        }
    }
}