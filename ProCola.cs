using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TDA_Cola.clases
{
    class ProCola
    {
        Queue cola = new Queue();
        int valor;

        public int enqueque()
        {
            Console.Write("Ingrese el numero: ");
            cola.Enqueue(valor = Convert.ToInt16(Console.ReadLine()));
            return 0;
        }
        public int dequeue()
        {
            Console.Write("El valor eliminado es:  ");
            Console.WriteLine(cola.Dequeue());
            return 0;
        }
        public int peek()
        {
            Console.Write("El valor es: ");
            Console.WriteLine(cola.Peek());
            return 0;
        }
        public int clear()
        {
            Console.Write("La cola se vacio.");
            cola.Clear();
            return 0;
        }
        public int contains()
        {
            Console.Write("Ingrese el valor a buscar en la cola: ");
            valor = Convert.ToInt16(Console.ReadLine());
            Console.Write(cola.Contains(valor));
            return 0;
        }
        public int count()
        {
            Console.Write("La cantidad de elementos en la cola es: "+cola.Count);
            return 0;
        }
        public int imprimir()
        {
            foreach (var valor in cola)
            {
                Console.WriteLine(valor);
            }
            return 0;
        }
    }
}
