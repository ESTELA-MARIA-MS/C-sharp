using System;

namespace PilaresDePOO
{
    class Gato:Mamifero
    {
        public string Peso { get; set; }
        public bool domestico { get; set; }

        public Gato(string nombre, int numeroPatas, string tamaño, string peso)
        {
            Nombre = nombre;
            Peso = peso;
            NumeroPatas = numeroPatas;
            domestico = true;
            Tamaño = tamaño;
            
            
        }
        public void Maullar()
        {
            Console.WriteLine ("SONIDO ES MIAU");
        }
    }
}