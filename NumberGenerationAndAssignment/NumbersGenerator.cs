using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerationAndAssignment
{
    public class NumbersGenerator
    {
        public int NumberLimit; // Defines the range of the math problems.
        public int TimeLimit; // Sets the time limit in seconds.
        Random randomNumberGenerator = new Random();
        public NumbersGenerator(int numberLimit, int timeLimit)
        {
            NumberLimit = numberLimit;
            TimeLimit = timeLimit;
        }
        public NumbersGenerator() : this(100, 15)
        {
            // Deafult game goes up to 100 and has a time limit of 15 seconds.
        }
        public AssignedNumbersAndResult GenerateAdditionProblem()
        {
            int number1Min = 1; // The minimum is included in the random number generator range.
            int number1Max = NumberLimit; // The maximum is not included in the random number generator range. Also sets the maximum result (100).
            int number2Min = 1;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2 = randomNumberGenerator.Next(number2Min, number1Max - number1 + 1);
            int result = number1 + number2;
            AssignedNumbersAndResult setNumbersAndResult = new AssignedNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public AssignedNumbersAndResult GenerateSubtractionProblem()
        {
            int number1Min = 2; // The game doesn't allow negative numbers as results.
            int number1Max = NumberLimit;
            int number2Min = 1;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2 = randomNumberGenerator.Next(number2Min, number1); // The second number has to be lower than the first.
            int result = number1 - number2;
            AssignedNumbersAndResult setNumbersAndResult = new AssignedNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public AssignedNumbersAndResult GenerateMultiplicationProblem()
        {
            int number1Min = 2; // Multiplication by 1 is too easy.
            int number1Max = (NumberLimit / 2) + 1;
            // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number2Min = 2;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2Max = NumberLimit / number1; // This way, the result will be lower or equal to the highest possible number.
            int number2 = randomNumberGenerator.Next(number2Min, number2Max + 1);
            int result = number1 * number2;
            AssignedNumbersAndResult setNumbersAndResult = new AssignedNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public AssignedNumbersAndResult GenerateDivisionProblem()
        {
            int number1Min = 2; // Division by 1 is too easy.
            int number1Max = (NumberLimit / 2) + 1; // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number2Min = 2;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2Max = NumberLimit / number1; // This way, the result will be lower or equal to 100.
            int number2 = randomNumberGenerator.Next(number2Min, number2Max + 1);
            int result = number1 * number2;
            AssignedNumbersAndResult setNumbersAndResult = new AssignedNumbersAndResult();
            // The process is the same as multiplication but the arguments change order
            // so the actual result (number2) of division is always an integer.
            // The condition ensures the quotient is never 2 because it is too easy.
            // The switch ensures that the divisor is not always higher than the dividend.
            if (number1 == 2)
            {
                setNumbersAndResult = new AssignedNumbersAndResult(result, number1, number2);
            }
            else if (number2 == 2)
            {
                setNumbersAndResult = new AssignedNumbersAndResult(result, number2, number1);
            }
            else
            {
                int orderOfArguments = randomNumberGenerator.Next(2);
                switch (orderOfArguments)
                {
                    case 0:
                        setNumbersAndResult = new AssignedNumbersAndResult(result, number2, number1);
                        break;
                    default:
                        setNumbersAndResult = new AssignedNumbersAndResult(result, number1, number2);
                        break;
                }
            }
            return setNumbersAndResult;
        }
    }
}
