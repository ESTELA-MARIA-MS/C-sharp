using System;

namespace PilaresDePOO
{
    class ClaseGato:ClaseBaseMamiferos
    {
        public string Peso { get; set; }
        public bool domestico { get; set; }

        public Gato(string nombre,  string tamano, string peso)
        {
            Nombre = nombre;
            Tamano = tamano;
            domestico = true;
            Peso = peso;
        }
        public void Maullar()
        {
            Console.WriteLine ("SONIDO ES MIAU ");
        }
    }
}