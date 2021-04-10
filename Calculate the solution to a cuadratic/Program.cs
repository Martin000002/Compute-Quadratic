using System;

namespace Calculate_the_solution_to_a_cuadratic
{
    class Program
    {
        public static double a;
        public static double b;
        public static double c;

        static void Main(string[] args)
        {
            Console.WriteLine("Input a");
            String Sa = Console.ReadLine();
            a = Int32.Parse(Sa);
            Console.WriteLine("Input b");
            String Sb = Console.ReadLine();
            b = Int32.Parse(Sb);
            Console.WriteLine("Input c");
            String Sc = Console.ReadLine();
            c = Int32.Parse(Sc);

            //ax^2 + bx + c = 0

            //-b/(2a) +- Raiz(b^2 - 4(ac))/(2a)

            //primero revisa si la solucion es real o compleja
            double Eje = ResuelveElEje();
            if (TieneSolucionReal())
            {
                Console.WriteLine("esReal");
                double Discriminante = ResuelveDiscriminante();
                Console.WriteLine("x1 = " + (Eje + Discriminante) + "\n" + "x2 = " + (Eje - Discriminante));
            }else
            {
                Console.WriteLine("noEsReal");
                double DiscriminanteNegativo = ResuelveDiscriminanteNegativo();
                Console.WriteLine("x1 = " + Eje + " + " + DiscriminanteNegativo + " i " + "\n" + "x2 = " + (Eje + " - " + DiscriminanteNegativo + " i "));
            }
        }

        static Boolean TieneSolucionReal()
        {
            if(0 <= (b * b) - 4 * (a * c))
            {
                return true;
            }else
            {
                return false;
            }
        }

        static double ResuelveElEje()
        {
            double result = ((-1 * b) / (2 * a));
            Console.WriteLine("eje: " + result);
            return result;
        }

        static double ResuelveDiscriminante()
        {
            double result = Math.Sqrt( (b * b) - 4 * (a * c)) / (2 * a);
            Console.WriteLine("dicriminante: " + result);
            return result;
        }
        static double ResuelveDiscriminanteNegativo()
        {
            double result = Math.Sqrt(-1 *( (b * b) - 4 * (a * c))) / (2 * a);
            Console.WriteLine("dicriminanteNeg: " + result + " underRoot " + 
                (-1* ( (b * b) - 4 * (a * c)))
                );
            return result;
        }
    }
    
}
