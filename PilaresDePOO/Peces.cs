using System;

namespace PilaresDePOO
{
     class Peces:Animal
    {

        public string NombrePez { get; set; }
        public string Color { get; set; }
        public int NumeroAletas { get; set; }

        public void Nadar()
        {
            Console.WriteLine("EL PUEDE NADAR");
        }
    }
}