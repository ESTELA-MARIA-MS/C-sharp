using System;

namespace PilaresDePOO
{
    class ClasePezGlobo:ClaseBasePeces
    {
        public string Alimentacion { get; set; }
        public void caracteristica()
        {
            robusto();
        }

        private void robusto()
        {
            Console.WriteLine("PARTICULARIDAD DEL ANIMAL: Se infla");
        }
    }
}