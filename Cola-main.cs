using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TDA_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int seleccion, numero,m=0;
            Queue cola = new Queue();
            do
            {
                Console.WriteLine("\t\t\t TDA COLA\n" +
                                  "\t\t 1. encolar-ingresar \n" +
                                  "\t\t 2. desencolar-sacar \n" +
                                  "\t\t 3. mirar \n" +
                                  "\t\t 4. clear  \n" +
                                  "\t\t 5. contiene \n"+
                                  "\t\t 6. tamaño");
                seleccion = Convert.ToInt16(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:
                        Console.Write("Ingrese el numero: ");
                        cola.Enqueue(numero = Convert.ToInt16(Console.ReadLine()));
                        break;
                    case 2:
                        cola.Dequeue();
                        break;
                    case 3:
                        cola.Peek();
                        break;
                    case 4:
                        cola.Clear();
                        break;
                    case 5:
                        numero = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine(cola.Contains(numero));                       
                        break;
                    case 6:
                        Console.WriteLine(cola.Count);
                        break;
                    default:
                        m = 1;
                        break;
                }
            } while (m == 0);
        }
    }
}
