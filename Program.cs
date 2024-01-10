namespace GA_WholeNumbersAndMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Concatenating: ");
            Console.WriteLine("10" + "20");

            Console.Write("Add two numbers: ");
            Console.WriteLine(10 + 20);

            // Whole numbers
            // Integrals

            // -128 to 127
            //sbyte example = 128; 
            int number1 = 10; // Declaring a new variable with a value of 10
            int number2 = 20; // Declaring a new variable with a value of 20
            int sum = number1 + number2; // Adding the two variables together, and SAVING the result in sum

            Console.WriteLine($"{number1} + {number2} = {sum}");

            // Math Operations
            // Addition : +
            // Subtraction : -
            // Multiplication : * ( astrix )
            // Divide : / (forward slash)
            // Modulus : % ( percentage ) ( mod )

            // PEDMAS
            // Parenthese
            // Exponents
            // Division
            // Multiplication
            // Addition
            // Subtraction

            int num1 = 35;
            int num2 = 21;

            int sumNumbers = num1 + num2;
            int minusNumbers = num1 - num2;
            int multiplyNumbers = num1 * num2;
            int divideNumbers = num1 / num2;
            int modNumbers = num1 % num2;

            Console.WriteLine($"{num1} + {num2} = {sumNumbers}");
            Console.WriteLine($"{num1} - {num2} = {minusNumbers}");
            Console.WriteLine($"{num1} * {num2} = {multiplyNumbers}");

            Console.WriteLine("Divide and Mod");
            Console.WriteLine($"{num1} / {num2} = {divideNumbers}");
            Console.WriteLine($"{num1} % {num2} = {modNumbers}");

            // Pedmas

            // PEDMAS
            // Parenthese
            // Exponents
            // Division
            // Multiplication
            // Addition
            // Subtraction
            int pedmas = (multiplyNumbers + sumNumbers) + (divideNumbers * minusNumbers) / (modNumbers);

            Console.WriteLine(pedmas);

            // Sum 56
            // subtract 14
            // multiplication 735
            // divide is 1
            // mod is 14

            // MultiplyNumber + sum = 735 + 56 = 791
            // divideNum * minusNum = 1 * 14 = 14
            // Mod Numbers is 14
            // 791 + 14 / 14
            // 14 / 14 = 1
            // 791 + 1
            // 792


        } // main

    } // class

} // namespace
