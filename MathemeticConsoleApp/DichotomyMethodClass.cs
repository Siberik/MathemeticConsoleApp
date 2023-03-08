using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemeticConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Здесь мы задаём точность
            const double epsilon = 0.1;
            double a, b;
            //Наш интервальчик
            a = 0;
            b = 10;
            while (b - a > epsilon)
            {
                double c = (a + b) / 2;
                if (f(b) * f(c) < 0)
                {
                    a = c;
                    Console.WriteLine($"Присваиваем значение a={c}");
                }


                else
                {
                    b = c;
                    Console.WriteLine($"Присваиваем значение b={c}");
                }

            }
            //найденное значение x в нуле функции
            Console.WriteLine($"А вот и ответ: {((a + b) / 2)}");
            Console.ReadKey();
        }

        static double f(double x)
        {
            //Это наше уравнение
            
            return 3 * x - 2;
            
        }
        
    }
        
    }
    

