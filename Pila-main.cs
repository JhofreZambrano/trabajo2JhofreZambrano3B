using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TDA_Pila.clases;

namespace TDA_Pila
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int seleccion,m=0;

            ProPila pila = new ProPila();
            do
            {
                Console.WriteLine("\n" +"----------------------------------------------------"+"\n"+
                                  "\t TDA PILA\n" +
                                  " 1. Insertar un numero a la pila\n" +
                                  " 2. Eliminar y mostrar ultimo elemento de la pila\n" +
                                  " 3. Imprimir la pila\n" +
                                  " 4. vaciar la pila\n"+
                                  " 5. contiene 'n' numero en la pila\n"+
                                  " 6. Mostrar el ultimo elemento(sin eliminar)\n"+
                                  " 7. Tamaño de la pila\n"+
                                  " 8. Salir.\n"+
                                  "----------------------------------------------------");
                seleccion = Convert.ToInt16(Console.ReadLine());
                switch (seleccion)
                {
                    case 1:                        
                        pila.push();                                               
                        break;
                    case 2:
                        pila.pop();
                        break;
                    case 3:
                        pila.imprimir();                        
                        break;
                    case 4:
                        pila.clear();
                        break;
                    case 5:
                        pila.contains();
                        break;
                    case 6:
                        pila.peek();
                        break;
                    case 7:
                        pila.count();
                        break;
                    case 8:
                        m = 1;
                        break;
                    default:
                        Console.Write("La opcion no es valida.");
                        break;
                }
            } while (m == 0);
        }
    }
}
