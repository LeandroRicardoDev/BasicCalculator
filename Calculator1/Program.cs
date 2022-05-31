using System;
using System.Globalization;


namespace Calculator1 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Clear();
                try {
                    double total = 0;
                    double number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    char signal = char.Parse(Console.ReadLine());
                    double number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    switch (signal) {
                        case '+':
                            total = number1 + number2;
                            break;
                        case '-':
                            total = number1 - number2;
                            break;
                        case '/':
                            total = number1 / number2;
                            break;
                        case '*':
                            total = number1 * number2;
                            break;
                    }                    
                    Console.WriteLine("Total: " + total.ToString(CultureInfo.InvariantCulture));
                } catch (FormatException e) {                   
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();                
            }
        }
    }
}
