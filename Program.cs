// using System;

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            MathUtils.Multiply(5, 3);
//            MathUtils.Sum(4, 5);
//         }
//     }
// }

#pragma warning disable 219

namespace Calculator
{
    public class Calculator{
        int num1;
        int num2;
        int result;

        void Add(){
            result = num1 + num2;
            Console.WriteLine(result);
        }

        void Subtract(){
              result = num1 - num2;
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine("This is a calculator program");
            obj.num1 = 20;
            obj.num2 = 30;

            OOPExercise.Car myCar = new OOPExercise.Car("Toyota", "Camry", 2022, "Red");
            myCar.Start();
            myCar.Drive(50);
        }
    }
}
