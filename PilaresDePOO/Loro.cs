using System;

namespace PilaresDePOO
{
    class Loro:Aves

    {
        public string Comida { get; set; }
        public void Hablar()
        {
            comunicacion();
        }

        private void comunicacion()
        {
                Console.WriteLine("El Animal Puede Hablar");
        }
    }
}