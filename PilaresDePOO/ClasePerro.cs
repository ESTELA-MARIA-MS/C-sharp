using System;

namespace PilaresDePOO
{
    class ClasePerro:ClaseBaseMamiferos
    {
        public bool Esdomestico { get; set; }
      public Perro(string nombre,  string tamano)
      {
          Nombre = nombre;
          Esdomestico=true;
          Tamano = tamano;
      }

      public void latir()
      {
          Console.WriteLine("El Sonido Es: Guao");
      }

    }
}