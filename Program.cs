using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            Icalculadora ICalculadora = new Calculadora();

            int input;
            do
            {
                MuestraMenu();
                input = Convert.ToInt32(Console.ReadLine());

                if (input != 5)
                {
                    int value1, value2;
                    LeeValores(out value1, out value2);
                    Calcula(input, value1, value2); 
                }
                Console.WriteLine("");
            } while (input != 5);

            void Calcula(int opcion, int value1, int value2)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado es: " + ICalculadora.Suma(value1, value2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es: " + ICalculadora.Resta(value1, value2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es: " + ICalculadora.Multiplicacion(value1, value2));
                        break;
                    case 4:
                        Console.WriteLine("El resultado es: " + ICalculadora.Division(value1, value2));
                        break;
                    case 5:
                        break;
                }
            }

            void LeeValores(out int value1, out int value2)
            {
                Console.WriteLine("Introduzca el primer valor:");
                value1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo valor");
                value2 = Convert.ToInt32(Console.ReadLine());
            }

             void MuestraMenu()
            {
                Console.WriteLine("Que opcion desea realizar:");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Salir");
            }
        }
    }
}
