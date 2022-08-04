using System;

namespace PilaresDePOO
{
    class Mono:Mamifero
    {
        public string Peso { get; set; }
        public bool domestico { get; set; }

        public Mono(string nombre, int numeroPatas, string tamaño)
        {
            Nombre = nombre;
            NumeroPatas = numeroPatas;
            domestico = false;
            Tamaño = tamaño;
            
            
            
        }
        public void Aullar()
        {
            Console.WriteLine ("SONIDO ES i-i-i");
        }
    }
}