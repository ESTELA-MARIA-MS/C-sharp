using System;

namespace PilaresDePOO
{
    class Aguila:Aves
    {
        public string tipoAguila { get; set; }
        public void VolarAlto()
        {
            Console.WriteLine("Vuela Alto");
        }
    }
}