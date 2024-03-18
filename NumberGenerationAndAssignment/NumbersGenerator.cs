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
        Random randomNumberGenerator = new Random();
        public NumbersGenerator(int numberLimit)
        {
            NumberLimit = numberLimit;
        }
        // Deafult game goes up to 100 - not used in this game.
        //public NumbersGenerator() : this(100)
        //{
        //}
        public AssignedNumbersAndResult GenerateAdditionProblem()
        {
            int number1Max = NumberLimit; // The maximum is not included in the random number generator range. Also sets the maximum result (100).
            int number1 = randomNumberGenerator.Next(1, number1Max);
            int number2 = randomNumberGenerator.Next(1, number1Max - number1 + 1);
            int result = number1 + number2;
            return new AssignedNumbersAndResult(number1, number2, result);
        }
        public AssignedNumbersAndResult GenerateSubtractionProblem()
        {
            int number1Max = NumberLimit + 1;
            int number1 = randomNumberGenerator.Next(2, number1Max); // The game doesn't allow negative numbers as results.
            int number2 = randomNumberGenerator.Next(1, number1); // The second number has to be lower than the first.
            int result = number1 - number2;
            return new AssignedNumbersAndResult(number1, number2, result);
        }
        public AssignedNumbersAndResult GenerateMultiplicationProblem()
        {
            int number1Max = (NumberLimit / 2) + 1;
            // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number1 = randomNumberGenerator.Next(2, number1Max); // Multiplication by 1 is too easy.
            int number2Max = NumberLimit / number1; // This way, the result will be lower or equal to the highest possible number.
            int number2 = randomNumberGenerator.Next(2, number2Max + 1);
            int result = number1 * number2;
            return new AssignedNumbersAndResult(number1, number2, result);
        }
        public AssignedNumbersAndResult GenerateDivisionProblem()
        {
            int number1Max = (NumberLimit / 2) + 1; // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number1 = randomNumberGenerator.Next(2, number1Max); // Division by 1 is too easy.
            int number2Max = NumberLimit / number1; // This way, the result will be lower or equal to 100.
            int number2 = randomNumberGenerator.Next(2, number2Max + 1);
            int result = number1 * number2;
            // The process is the same as multiplication but the arguments change order
            // so the actual result (number2) of division is always an integer.
            // The condition ensures the quotient is never 2 because it is too easy.
            // The switch ensures that the divisor is not always higher than the dividend.
            if (number1 == 2)
            {
                return new AssignedNumbersAndResult(result, number1, number2);
            }
            else if (number2 == 2)
            {
                return new AssignedNumbersAndResult(result, number2, number1);
            }
            else
            {
                int orderOfArguments = randomNumberGenerator.Next(2);
                switch (orderOfArguments)
                {
                    case 0:
                        return new AssignedNumbersAndResult(result, number2, number1);
                    default:
                        return new AssignedNumbersAndResult(result, number1, number2);
                }
            }
        }
    }
}
