using System;

namespace PilaresDePOO
{
    class PezGlobo:Peces
    {
        public string Alimentacion { get; set; }
        public void caracteristica()
        {
            robusto();
        }

        private void robusto()
        {
            Console.WriteLine(" El ANIMAL: Se infla");
        }
    }
}