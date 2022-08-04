using System;
namespace PilaresDePOO
{
     class Aves: Animal
    {

        public string NombreAve { get; set; }

        public string ColorPlumaje { get; set; }

        public string Habitat { get; set; }
        
        public void Volar()
        {
            Console.WriteLine("Puede Volar");
        }

         public void Corre()
        {
            if (NombreAve == "Aguila" )
            {
                CorreRapido();
            }
            else
            {
                CorreLento();
            }
        }

        private void CorreRapido()
        {
            Console.WriteLine("El Ave corre rapido");
        }

        private void CorreLento()
        {
            Console.WriteLine("El Ave corre lento");
        }
    }
}