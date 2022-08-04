using System;

namespace PilaresDePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("*********************Animales Mamiferos************************");
            ClaseBaseMamiferos m1 = new ClaseBaseMamiferos();
            m1.TipoAnimal = "Perro";
            m1.idAnimal = 1;
            ClasePerro p1 = new ClasePerro("Max", 4, "Es Grande");

            Console.WriteLine("Tipo de Animal: " + m1.TipoAnimal);
            Console.WriteLine("Nombre: " + p1.Nombre );
            Console.WriteLine("Es Domestico? S/N :  " + p1.Esdomestico);
            p1.latir();
            Console.WriteLine("");
            Console.WriteLine("");

            ClaseBaseMamiferos m2 = new ClaseBaseMamiferos();
            m2.TipoAnimal = "Gato";
            m2.idAnimal = 2;
            ClaseGato g1 = new ClaseGato( "Es Pequeño");

            Console.WriteLine("Tipo de Animal: " + m2.TipoAnimal);
            Console.WriteLine("Nombre: " + g1.Nombre );
            Console.WriteLine("Peso del Animal: " + g1.Peso);
            Console.WriteLine("El Animal es Domestico? S/N :  " + g1.domestico);
            g1.Maullar();

            ClaseBaseMamiferos m3 = new ClaseBaseMamiferos();
            m3.TipoAnimal = "Mono";
            m3.idAnimal = 3;
            ClaseMono m1 = new ClaseMono( "Es Grande");

            Console.WriteLine("Tipo de Animal: " + m3.TipoAnimal);
            Console.WriteLine("Nombre: " + m1.Nombre );
            Console.WriteLine("Peso del Animal: " + m1.Comida);
            m1.Maullar();
            Console.WriteLine("******************************************************");


            Console.WriteLine("**************************AVES*************************");
            ClaseBaseAves a1 = new ClaseBaseAves();
            a1.TipoAnimal = "Ave";
            a1.idAnimal = 1;
            ClaseAguila ag1 = new ClaseAguila();
            ag1.NombreAve = "Aguila";
            ag1.ColorPlumaje = "Cafe con pintas negras";
            ag1.LugardeHabitat = "Cerros o Bosques";
            ag1.tipoAguila = "Aguila Harpia";
            
            Console.WriteLine("Tipo de Animal: " + a1.TipoAnimal);
            Console.WriteLine("Nombre: " + ag1.NombreAve );
            Console.WriteLine("Color del Plumaje:  " + ag1.ColorPlumaje);
            Console.WriteLine("El Hábitat del Animal es:  " + ag1.Habitat);
            ag1.VolarAlto();
            ag1.Corre();
            Console.WriteLine("");
            Console.WriteLine("");

            ClaseBaseAves a2 = new ClaseBaseAves();
            a2.TipoAnimal = "Ave";
            a2.idAnimal = 2;
            ClaseLoro L1 = new ClaseLoro();
            L1.NombreAve = "Loro";
            L1.Comida= "Semillas";
            L1.Habitat = "Selva";
            L1.ColorPlumaje = "Amarillo";
            
            Console.WriteLine("Tipo de Animal: " + a2.TipoAnimal);
            Console.WriteLine("Nombre: " + L1.NombreAve );
            Console.WriteLine("Color del Plumaje:  " + L1.ColorPlumaje);
            Console.WriteLine("El Hábitat del Animal es:  " + L1.Habitat);
            Console.WriteLine("Se alimenta de: " + L1.Comida);
            L1.Volar();
            L1.Corre();
            Console.WriteLine("********************************************************************");


            Console.WriteLine("*******************************ACUATICOS****************************");

            ClaseBasePeces p = new ClaseBasePeces();
            gl1.NombrePez = "Pez Globo";
            p.idAnimal = 1;
            p.TipoAnimal = "Acuatico";
            ClasePezGlobo gl1 = new ClasePezGlobo();
            gl1.Color = "Cafe claro";
            gl1.NumerodeAletas = 2;
            gl1.Alimentacion = "ALGAS, ANIMALES INVERTEBRADOS";
            
            Console.WriteLine("Tipo de Animal: " + p.TipoAnimal);
            Console.WriteLine("Nombre: " + gl1.NombrePez );
            Console.WriteLine("Color del Pez:  " + gl1.Color);
            Console.WriteLine("Se Alimenta de: " + gl1.Alimentacion);
            gl1.Nadar();
            gl1.caracteristica();

            Console.WriteLine("********************************************************************");

        }
    }
}
