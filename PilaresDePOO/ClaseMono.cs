using System;

namespace PilaresDePOO
{
    class ClaseMono:ClaseBaseMamiferos
    {
        public string  comida { get; set; }
        

        public Gato(string nombre,  string tamano, string comida)
        {
            Nombre = nombre;
            Tamano = tamano;
            Comida = comida;
        }
        public void Maullar()
        {
            Console.WriteLine ("SONIDO ES i-i-i ");
        }
    }
}