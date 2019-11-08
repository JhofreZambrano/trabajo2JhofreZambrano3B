using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TDA_PilaCola.clases
{
    class ProPilaCola
    {
        Queue cola = new Queue();
        Stack proPila = new Stack();
        int valor;

        public int enquequeCola()
        {
            Console.Write("Ingrese el numero: ");
            cola.Enqueue(valor = Convert.ToInt16(Console.ReadLine()));
            return 0;
        }

        public int dequeueCola()
        {
            Console.Write("El valor eliminado es:  ");
            Console.WriteLine(cola.Dequeue());
            return 0;
        }

        public int peekCola()
        {
            Console.Write("El valor es: ");
            Console.WriteLine(cola.Peek());
            return 0;
        }

        public int clearCola()
        {
            Console.Write("La cola se vacio.");
            cola.Clear();
            return 0;
        }

        public int containsCola()
        {
            Console.Write("Ingrese el valor a buscar en la cola: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.Write(cola.Contains(valor));
            return 0;
        }

        public int countCola()
        {
            Console.Write("La cantidad de elementos en la cola es: " + cola.Count);
            return 0;
        }

        public int imprimirCola()
        {
            foreach (var valor in cola)
            {
                Console.WriteLine(valor);
            }
            return 0;
        }     

        public int pushPila()
        {
            Console.Write("\t -Ingrese el valor: ");
            proPila.Push(valor = Convert.ToInt16(Console.ReadLine()));
            return 0;
        }

        public int popPila()
        {
            Console.WriteLine("\t -El elemento es: " + proPila.Pop());
            return 0;
        }

        public int imprimirPila()
        {
            foreach (var valor in proPila)
            {
                Console.WriteLine(valor);
            }
            return 0;
        }

        public int clearPila()
        {
            proPila.Clear();
            Console.Write("La pila se vacio\n");
            return 0;
        }

        public int containsPila()
        {
            Console.Write("Ingrese el valor a buscar en la pila: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(proPila.Contains(valor));
            return 0;
        }

        public int peekPila()
        {
            Console.Write("El ultimo elemento agregado es: ");
            Console.Write(proPila.Peek());
            return 0;
        }

        public int countPila()
        {
            Console.Write("La cantidad de elementos en la cola es: " + proPila.Count);
            return 0;
        }


    }
}
