using System;

namespace PilaresDePOO
{
    class ClaseLoro:ClaseBaseAves

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