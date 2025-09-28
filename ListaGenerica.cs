using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica
{
    internal class ListaGenerica<T>
    {
        private List<T> elementos;

        public ListaGenerica()
        {
            elementos = new List<T>();
        }

        // Agregar elemento
        public void Agregar(T valor)
        {
            elementos.Add(valor);
        }

        // Eliminar por índice
        public void Eliminar(int indice)
        {
            if (indice >= 0 && indice < elementos.Count)
            {
                elementos.RemoveAt(indice);
            }
        }

        // Mostrar todos los elementos
        public List<T> Mostrar()
        {
            return new List<T>(elementos);
        }
    }
}
