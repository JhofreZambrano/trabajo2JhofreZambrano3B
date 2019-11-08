using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Pila.clases
{
    public class ProPila
    {
        Stack proPila = new Stack();
        int valor;
        
        public int push()
        {
            Console.Write("\t -Ingrese el valor: ");            
            proPila.Push(valor = Convert.ToInt16(Console.ReadLine()));
            return 0;            
        }

        public int pop()
        {
            Console.WriteLine("\t -El elemento es: "+ proPila.Pop()); 
            return 0;
        }

        public int imprimir()
        {
            foreach (var valor in proPila)
            {
                Console.WriteLine(valor);
            }
            return 0;
        }

        public int clear()
        {
            proPila.Clear();
            Console.Write("La pila se vacio\n");
            return 0;
        }

        public int contains()
        {
            Console.Write("Ingrese el valor a buscar en la pila: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(proPila.Contains(valor));            
            return 0;
        }
        public int peek()
        {
            Console.Write("El ultimo elemento agregado es: ");
            Console.Write(proPila.Peek());
            return 0;
        }
        public int count()
        {
            Console.Write("La cantidad de elementos en la cola es: " + proPila.Count);
            return 0;
        }
    }
}
