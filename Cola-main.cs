using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TDA_Cola.clases;

namespace TDA_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int seleccion,m=0;
            ProCola cola = new ProCola();
            do
            {
                Console.WriteLine("\n" + "----------------------------------------------------" + "\n" +
                                  "\t TDA COLA\n" +
                                  " 1. Insertar un numero a la cola\n" +
                                  " 2. Eliminar y mostrar el primer elemento de la cola\n" +
                                  " 3. Mirar primer elemento de la cola\n" +
                                  " 4. Vaciar la cola\n" +
                                  " 5. Contiene 'n' numero en la cola\n" +
                                  " 6. Tamaño de la cola\n" +
                                  " 7. Imprimir la cola\n" +
                                  " 8. Salir.\n"+
                                  "----------------------------------------------------");
                seleccion = Convert.ToInt16(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:
                        cola.enqueque();
                        break;
                    case 2:
                        cola.dequeue();
                        break;
                    case 3:
                        cola.peek();
                        break;
                    case 4:
                        cola.clear();
                        break;
                    case 5:
                        cola.contains();                      
                        break;
                    case 6:
                        cola.count();
                        break;
                    case 7:
                        cola.imprimir();
                        break;
                    case 8:
                        m = 1;
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida.");
                        break;
                }
            } while (m == 0);
        }
    }
}
