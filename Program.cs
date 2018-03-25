using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PooVueling
{
    class Program
    {
        enum Operacion { Suma, Resta, Multiplicacion, Division };

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
                string strr = (opcion == 5) ? "sortir" : ((Operacion)opcion - 1).ToString();
                Console.WriteLine(strr);

                Type thisType = ICalculadora.GetType();

                MethodInfo method = thisType.GetMethod(strr);
                Console.WriteLine("el metodo es: {0}" , method);

                //Esta linea esta mal, no he conseguido usar el metodo ni pasarle los parametros
                //Console.WriteLine("El resultado es: {0}", method.Invoke(value1, value2);

                switch (strr)
                {
                    case "Suma":
                        Console.WriteLine("El resultado es: " + ICalculadora.Suma(value1, value2));
                        break;
                    case "Resta":
                        Console.WriteLine("El resultado es: " + ICalculadora.Resta(value1, value2));
                        break;
                    case "Multiplicacion":
                        Console.WriteLine("El resultado es: " + ICalculadora.Multiplicacion(value1, value2));
                        break;
                    case "Division":
                        Console.WriteLine("El resultado es: " + ICalculadora.Division(value1, value2));
                        break;
                    case "sortir":
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
