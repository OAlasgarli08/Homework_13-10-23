using Helpers.CalculatorHelper;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controllers
{
    public class CalculatorController
    {
        private readonly CalculatorService _calculateService;
        private readonly CalculatorHelper calculatorHelper;
        public CalculatorController()
        {
            _calculateService = new CalculatorService();
        }

        public void Calculate()
        {

            Console.WriteLine("Add first digit");
        Num1: string num1 = Console.ReadLine();

            double number1;

            bool isTrueNum1 = double.TryParse(num1, out number1);

            if (!isTrueNum1)
            {
                Console.WriteLine(CalculatorHelper.Invalidoperation);
                goto Num1;
            }

            Console.WriteLine("Choose your operation type: +, -, *, / ");
            string operation = Console.ReadLine();

            Console.WriteLine("Add second digit");
        Num2: string num2 = Console.ReadLine();

            double number2;

            bool isTrueNum2 = double.TryParse(num2, out number2);

            if (!isTrueNum2)
            {
                Console.WriteLine(CalculatorHelper.Invalidoperation);
                goto Num2;
            }

            if (operation == "/" && number2 == 0)
            {
                Console.WriteLine(CalculatorHelper.DivisbleByZero);
                Console.WriteLine("Add first digit");
                goto Num1;
            }

            string result = _calculateService.Calculate(number1, number2, operation);

            Console.WriteLine(result);
        }
    }
}
