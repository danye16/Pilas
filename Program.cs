namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            pila.InsertarElemento(4);
            pila.InsertarElemento(5);
            pila.InsertarElemento(6);
            pila.ImprimirLista();
        }
    }
}