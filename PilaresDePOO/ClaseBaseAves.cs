using System;
namespace PilaresDePOO
{
     class ClaseBaseAves: ClaseBaseAnimal
    {

        public string NombreAve { get; set; }

        public string ColorPlumaje { get; set; }

        public string LugardeHabitat { get; set; }
        
        
        public void Volar()
        {
            Console.WriteLine("PUEDE VOLAR");
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
            Console.WriteLine("El Ave carre lento");
        }
    }
}