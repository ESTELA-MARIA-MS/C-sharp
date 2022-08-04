using System;

namespace PilaresDePOO
{
    class Perro:Mamifero
    {
        public bool ESdomestico { get; set; }
      public Perro(string nombre, int numeroPatas, string tamaño)
      {
          Nombre = nombre;
          Tamaño = tamaño;
          ESdomestico=true;
          NumeroPatas = numeroPatas;
      }

      public void latir()
      {
          Console.WriteLine("El Sonido Es: Guao");
      }

    }
}