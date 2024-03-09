using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathGame
{
    internal class GenerateNumbers
    {
        private int numberLimit; // Defines the range of the math problems.
        public int TimeLimit; // Sets the time limit in seconds.
        Random randomNumberGenerator = new Random();
        public GenerateNumbers(int numberLimit, int timeLimit)
        {
            this.numberLimit = numberLimit;
            TimeLimit = timeLimit;
        }
        public GenerateNumbers() : this(100, 15)
        {
                // Deafult game goes up to 100 and has a time limit of 15 seconds.
        }
        public SetNumbersAndResult Additon()
        {
            int number1Min = 1; // The minimum is included in the random number generator range.
            int number1Max = numberLimit; // The maximum is not included in the random number generator range. Also sets the maximum result (100).
            int number2Min = 1;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2 = randomNumberGenerator.Next(number2Min, number1Max - number1 + 1);
            int result = number1 + number2;
            SetNumbersAndResult setNumbersAndResult = new SetNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public SetNumbersAndResult Subtraction()
        {
            int number1Min = 2; // The game doesn't allow negative numbers as results.
            int number1Max = numberLimit;
            int number2Min = 1;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2 = randomNumberGenerator.Next(number2Min, number1); // The second number has to be lower than the first.
            int result = number1 - number2;
            SetNumbersAndResult setNumbersAndResult = new SetNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public SetNumbersAndResult Multiplication()
        {
            int number1Min = 2; // Multiplication by 1 is too easy.
            int number1Max = (numberLimit / 2) + 1;
            // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number2Min = 2;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2Max = numberLimit / number1; // This way, the result will be lower or equal to the highest possible number.
            int number2 = randomNumberGenerator.Next(number2Min, number2Max + 1);
            int result = number1 * number2;
            SetNumbersAndResult setNumbersAndResult = new SetNumbersAndResult(number1, number2, result);
            return setNumbersAndResult;
        }
        public SetNumbersAndResult Division()
        {
            int number1Min = 2; // Division by 1 is too easy.
            int number1Max = (numberLimit / 2) + 1; // The deafult game only goes up to 100, so the maximum number for multiplication is 50, ie. range up to 51 (not included).
            int number2Min = 2;
            int number1 = randomNumberGenerator.Next(number1Min, number1Max);
            int number2Max = numberLimit / number1; // This way, the result will be lower or equal to 100.
            int number2 = randomNumberGenerator.Next(number2Min, number2Max + 1);
            int result = number1 * number2;
            SetNumbersAndResult setNumbersAndResult = new SetNumbersAndResult();
            // The process is the same as multiplication but the arguments change order
            // so the actual result (number2) of division is always an integer.
            // The condition ensures the quotient is never 2 because it is too easy.
            // The switch ensures that the divisor is not always the higher than the dividend.
            if (number1 == 2)
            {
                setNumbersAndResult = new SetNumbersAndResult(result, number1, number2);
            }
            else if (number2 == 2)
            {
                setNumbersAndResult = new SetNumbersAndResult(result, number2, number1);
            }
            else
            {
                int orderOfArguments = randomNumberGenerator.Next(2);
                switch (orderOfArguments)
                {
                    case 0:
                        setNumbersAndResult = new SetNumbersAndResult(result, number2, number1);
                        break;
                    default:
                        setNumbersAndResult = new SetNumbersAndResult(result, number1, number2);
                        break;
                }
            }
            return setNumbersAndResult;
        }
    }
}
