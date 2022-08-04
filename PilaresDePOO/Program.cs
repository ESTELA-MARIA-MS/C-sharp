using System;

namespace PilaresDePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("*******************Clase Base Animal**********************");
            Console.WriteLine("");
            Console.WriteLine("*******************Animales Mamiferos*********************");

            Mamifero m1 = new Mamifero();
            m1.TipoAnimal = "Perro";
            m1.idAnimal = 1;
            m1.Comida= "doogui";
            
            
            Perro p1 = new Perro("Lasy", 4, "Es Pequeña");

            Console.WriteLine("Especie de Animal: " + m1.TipoAnimal);
            Console.WriteLine("Nombre: " + p1.Nombre );
            Console.WriteLine("Numero de Patas: " + p1.NumeroPatas);
            Console.WriteLine("El Animal es Domestico? :  " + p1.ESdomestico);
            p1.latir();
            Console.WriteLine("Su Alimentacion es: " + m1.Comida);
            Console.WriteLine("");
            Console.WriteLine("");

            Mamifero m2 = new Mamifero();
            m2.idAnimal = 2;
            m2.TipoAnimal = "Gato";
            m2.Comida = "Doogui";

            Gato g1 = new Gato("Lulu", 4, "Es Grande", "Es Lindo");

            Console.WriteLine("Especie del Animal: " + m2.TipoAnimal);
            Console.WriteLine("Nombre: " + g1.Nombre );
            Console.WriteLine("El Animal es Domestico :  " + g1.domestico);
            Console.WriteLine("Peso del Animal: " + g1.Peso);
            Console.WriteLine("Numeros de Patas: " + g1.NumeroPatas);
            Console.WriteLine("Su Alimentacion es: " + m2.Comida);
            g1.Maullar();
            Console.WriteLine("");
            Console.WriteLine("");

            Mamifero t3 = new Mamifero();
            t3.idAnimal = 3;
            t3.TipoAnimal = "Mono";
            t3.idNombre ="Gogo";
            t3.Maullar = "i-i-i";
            t3.Comida = "Frutas";

            Console.WriteLine("Especie del Animal: " + t3.TipoAnimal);
            Console.WriteLine("Nombre: " + t3.idNombre );
            Console.WriteLine("SONIDO ES: " + t3.Maullar);
            Console.WriteLine("Su Alimentacion es: " + t3.Comida);
          
           
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("");

            Console.WriteLine("**************************Animales Aves***************************");


            Aves a1 = new Aves();
            a1.TipoAnimal = "Ave";
            a1.idAnimal = 1;
            Aguila ag1 = new Aguila();
            ag1.NombreAve = "Aguila";
            ag1.ColorPlumaje = "Cafe con pintas negras";
            ag1.Habitat = "Cerros o Bosques";
            ag1.tipoAguila = "Aguila Harpia";
            ag1.Comida= "Semillas y Inceptos";

            Console.WriteLine("Especie del Animal: " + a1.TipoAnimal);
            Console.WriteLine("Nombre: " + ag1.NombreAve );
            Console.WriteLine("Color de la pluma de la especie:  " + ag1.ColorPlumaje);
            Console.WriteLine("El Hábitat  es:  " + ag1.Habitat);
            ag1.Corre();
            ag1.VolarAlto();
            Console.WriteLine("Su Alimentacion es: " + ag1.Comida);
            Console.WriteLine("");
            Console.WriteLine("");

            Aves a2 = new Aves();
            a2.TipoAnimal = "Ave";
            a2.idAnimal = 2;
            Loro L1 = new Loro();
            L1.NombreAve = "Loro";
            L1.Habitat = "En lugares frescos";
            L1.ColorPlumaje = "Amarillo";
            L1.Comida= "Semillas y Inceptos";

            Console.WriteLine("Especie del Animal: " + a2.TipoAnimal);
            Console.WriteLine("Nombre: " + L1.NombreAve );
            Console.WriteLine("El Hábitat es:  " + L1.Habitat);
            Console.WriteLine("Su Alimentacion es: " + L1.Comida);
            Console.WriteLine("Color de la pluma de la especie:  " + L1.ColorPlumaje);
            L1.Corre();
            L1.Hablar();
            
            Console.WriteLine("********************************************************************");
            Console.WriteLine("");


            Console.WriteLine("**************************Animales ACUATICOS*************************");
            Peces p = new Peces();
            p.TipoAnimal = "Acuatico";
            p.idAnimal = 1;
            PezGlobo gl1 = new PezGlobo();
            gl1.NombrePez = "Pez Globo";
            gl1.Color = "Cafe claro";
            gl1.NumeroAletas = 2;
            gl1.Alimentacion = "ALGAS, ANIMALES INVERTEBRADOS";
            
            Console.WriteLine("Especie del Animal: " + p.TipoAnimal);
            Console.WriteLine("Nombre: " + gl1.NombrePez );
            Console.WriteLine("Numeros de Aletas:  " + gl1.NumeroAletas);
            Console.WriteLine("Su Alimentacion es: " + gl1.Alimentacion);
            Console.WriteLine("Color del Especie:  " + gl1.Color); 
            gl1.caracteristica();
            gl1.Nadar();

            Console.WriteLine("********************************************************************");

        }
    }
}
