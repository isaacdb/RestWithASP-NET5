using System;
using System.Collections.Generic;

namespace RestWithASPNET.Service
{
    public class CalculatorService
    {
        private readonly string SUM = "sum";
        private readonly string SUBTRACTION = "sub";
        private readonly string MULTIPLICATION = "mult";
        private readonly string DIVISION = "div";
        private readonly string EXPONENTIAL = "exp";
        private readonly string ROOT = "root";

        public List<string> AvailableOperations()
        {
            return new List<string> { SUM, SUBTRACTION, MULTIPLICATION, DIVISION, EXPONENTIAL, ROOT };
        }

        public string Calculate(string operation, string strFirstNumber, string strSecondNumber)
        {
            if (!AvailableOperations().Contains(operation))
            {
                return "Invalid operation";
            }

            if (!CalculatorHelper.IsNumeric(strFirstNumber) || !CalculatorHelper.IsNumeric(strSecondNumber))
            {
                return "Invalid input";
            }

            var firstNumber = CalculatorHelper.ConvertToDecimal(strFirstNumber);
            var secondNumber = CalculatorHelper.ConvertToDecimal(strSecondNumber);

            decimal result;

            switch (operation)
            {
                case "sum":
                    result = Sum(firstNumber, secondNumber);
                    break;

                case "sub":
                    result = Subtration(firstNumber, secondNumber);
                    break;

                case "mult":
                    result = Multiplication(firstNumber, secondNumber);
                    break;

                case "div":
                    result = Division(firstNumber, secondNumber);
                    break;

                case "exp":
                    result = Exponential(firstNumber, secondNumber);
                    break;

                case "root":
                    result = SquareRoot(firstNumber, secondNumber);
                    break;

                default:
                    return "Invalid operation error";
            }

            return result.ToString();
        }

        private decimal SquareRoot(decimal firstNumber, decimal secondNumber)
        {
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(firstNumber), 1 / Convert.ToDouble(secondNumber)));
        }

        private decimal Exponential(decimal firstNumber, decimal secondNumber)
        {
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)));
        }

        private decimal Division(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private decimal Subtration(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
