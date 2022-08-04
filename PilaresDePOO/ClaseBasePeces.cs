using System;

namespace PilaresDePOO
{
     class ClaseBasePeces:ClaseBaseAnimal
    {

        public string NombrePez { get; set; }
        public int NumerodeAletas { get; set; }
        public string Color { get; set; }

        public void Nadar()
        {
            Console.WriteLine("EL PUEDE NADAR");
        }
    }
}