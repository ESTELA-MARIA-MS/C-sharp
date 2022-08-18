using System;

namespace EstadisticasDelCovid_19
{
    
    class Program
    {
        protected void position(int a, int b, string mensaje)
    {
       Console.SetCursorPosition(a, b);
       Console.WriteLine(mensaje);
    }
        static void Main(string[] args)
        {
            string opcion = "";
            Salas salas = new Salas();
            
            while (true)
            {
                Console.Clear();
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fecha Y Hora: " + DateTime.Now); 
                Console.WriteLine("*           ----------------------------      *");
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("||   Sistema De Estadistica De Covid-2019    ||");
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                System.Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("||                                           ||");
                Console.WriteLine("||         1 - Reporte de Ingreso            ||");
                Console.WriteLine("||         2 - Crear Ingreso                 ||");
                Console.WriteLine("||         3 - Altas De Paciente             ||");
                Console.WriteLine("||                                           ||");
                Console.WriteLine("||                                           ||");
                Console.WriteLine("||              0 - Salir                    ||");
                Console.WriteLine("||                                           ||");
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        salas.listarPacientes();
                        break;
                    case "2":
                        salas.ingresoDePruebas();
                        break;
                    case "3":
                        salas.salidaDePacientes();
                        break;                                 
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}    
