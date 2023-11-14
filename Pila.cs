using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Pila
    {
        private int _cima;
        private int[] listapila;
        private int _longitusPila = 5;

        //Constructor para crear una pila vacia
        public Pila()
        {
            _cima = -1;
            listapila = new int[_longitusPila];
        }

        //Metodo para verificar si la pila esta vacia
        public bool PilaVacia()
        {
            return _cima == -1?true:false;
        }
        //Metodo para verificar si la pila esta llena
        public bool PilaLlena()
        {
            return _cima == _longitusPila-1? true:false;
        }

        public int LongitudPila()
        {
            if (PilaVacia())
            {
                return -1;
            }
            else
                return _longitusPila;
        }
        //Metodo para saber la cantidad de elementos dentro de la pila
        public int CantidadElementos() 
        {
            return _cima + 1;
        }
        //Obtener el valor de la cima
        public int ValorCima()
        {
            return listapila[_cima];
        }
        //MEtodo para insertar un elemento dentor de la pila
        public bool InsertarElemento(int elemento)
        {
            if(PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;
                listapila[_cima] = elemento;
                return true;
            }
        }
        //Metodo para retirar un elemento de la lista
        public int ExtraerElemento()
        {
            if (PilaVacia())
            {
                Console.WriteLine("La pila se encuentra vacia");
                return _cima;
            }
            else
            {
                int auxiliar = listapila[_cima];
                _cima--;
                return auxiliar; 
            }
        }
        //Eliminar elementos de la pila
        public bool LimpiarPila()
        {
            if (PilaVacia() )
            {
                return false;
            }
            else
            {
                while(!PilaVacia())
                    ExtraerElemento();
            }
            return true;
        }

    }

   
}
