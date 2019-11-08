using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDA_PilaCola.clases;
using System.Collections;

namespace TDA_PilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            ProPilaCola pilacola = new ProPilaCola();
            int seleccion, m=0;
            do
            {
                Console.WriteLine("\n----------------------\n" +
                                  "\t TDA PILA-COLA\n" +
                                  " Escoja la opcion:\n" +
                                  " 1. Pila.\n" +
                                  " 2. Cola.\n" +
                                  " 3. Salir.\n" +
                                  "-----------------------");
                seleccion = Convert.ToInt16(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:
                        {
                            int Spila;
                            Console.WriteLine("\n" + "----------------------------------------------------" + "\n" +
                                   "\t TDA PILA\n" +
                                   " 1. Insertar un numero a la pila\n" +
                                   " 2. Eliminar y mostrar ultimo elemento de la pila\n" +
                                   " 3. Imprimir la pila\n" +
                                   " 4. vaciar la pila\n" +
                                   " 5. contiene 'n' numero en la pila\n" +
                                   " 6. Mostrar el ultimo elemento(sin eliminar)\n" +
                                   " 7. Tamaño de la pila\n" +
                                   " 8. Salir.\n" +
                                   "----------------------------------------------------");
                            Spila = Convert.ToInt16(Console.ReadLine());
                            switch (Spila)
                            {
                                case 1:
                                    pilacola.pushPila();
                                    break;
                                case 2:
                                    pilacola.popPila();
                                    break;
                                case 3:
                                    pilacola.imprimirPila();
                                    break;
                                case 4:
                                    pilacola.clearPila();
                                    break;
                                case 5:
                                    pilacola.containsPila();
                                    break;
                                case 6:
                                    pilacola.peekPila();
                                    break;
                                case 7:
                                    pilacola.countPila();
                                    break;
                                case 8:
                                    m = 1;
                                    break;
                                default:
                                    Console.Write("La opcion no es valida.");
                                    break;
                            }
                        }break;
                    case 2:
                        {
                            int Scola;
                            Console.WriteLine("\n" + "----------------------------------------------------" + "\n" +
                                              "\t TDA COLA\n" +
                                              " 1. Insertar un numero a la cola\n" +
                                              " 2. Eliminar y mostrar el primer elemento de la cola\n" +
                                              " 3. Mirar el primer elemento de la cola\n" +
                                              " 4. Vaciar la cola\n" +
                                              " 5. Contiene 'n' numero en la cola\n" +
                                              " 6. Tamaño de la cola\n" +
                                              " 7. Imprimir la cola\n" +
                                              " 8. Salir.\n" +
                                              "----------------------------------------------------");
                            Scola = Convert.ToInt16(Console.ReadLine());
                            switch (Scola)
                            {
                                case 1:
                                    pilacola.enquequeCola();
                                    break;
                                case 2:
                                    pilacola.dequeueCola();
                                    break;
                                case 3:
                                    pilacola.peekCola();
                                    break;
                                case 4:
                                    pilacola.clearCola();
                                    break;
                                case 5:
                                    pilacola.containsCola();
                                    break;
                                case 6:
                                    pilacola.countCola();
                                    break;
                                case 7:
                                    pilacola.imprimirCola();
                                    break;
                                case 8:
                                    m = 1;
                                    break;
                                default:
                                    Console.WriteLine("La opcion no es valida.");
                                    break;
                            }                           
                        }break;

                    case 3:
                        m = 1;
                        break;
                } 
            } while (m == 0);
        }
    }
}
