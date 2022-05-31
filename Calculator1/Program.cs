using System;
using System.Globalization;


namespace Calculator1 {
    class Program {
        static void Main(string[] args) {

            int x = 0;
            double total = 0;
            while(x != null) { 
            try { 

            double a = double.Parse(Console.ReadLine());
                    char sinal = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

                    if(sinal == '-') {
                        double calc = a - b;
                        total = calc;
                    }
                    else if (sinal == '+') {
                        double calc = a + b;
                        total = calc;
                    }
                    
                   
                        Console.WriteLine("Total: " + total.ToString(CultureInfo.InvariantCulture));
            }
            catch(FormatException e) {
                    Console.WriteLine();
                Console.WriteLine("Error! Only Numbers");
                    
            }
            }
        }
    }
}
