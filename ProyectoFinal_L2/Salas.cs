using System;
using System.Collections.Generic;

public class Salas
{
    protected void position(int a, int b, string mensaje)
    {
       Console.SetCursorPosition(a, b);
       Console.WriteLine(mensaje);
    }

     public List<Paciente> ListadePaciente { get; set; }

    public Salas ()
    {   
        ListadePaciente = new List<Paciente> ();

        
   
        Paciente a = new Paciente("01", "Sala de Cuidados Leves", 0);
        

        Paciente b = new Paciente("02", "Sala de Cuidados Intermedios", 0);
        

        Paciente c = new Paciente("03", "Sala de Cuidados Graves", 0);
        

      
        Paciente a1 = new Paciente("0", "Cubrete al toser/estornudar", 0);
        Paciente b1 = new Paciente("0", "Manten distanciamiento social", 0);
        Paciente c1 = new Paciente("0", "Trate de respirar", 0);
        
        ListadePaciente.Add(a);
        ListadePaciente.Add(a1);
        ListadePaciente.Add(b);
        ListadePaciente.Add(b1);
        ListadePaciente.Add(c);
        ListadePaciente.Add(c1);
        
        
    } 
    public void listarPacientes() {
        Console.Clear();
        
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*"); 
        Console.WriteLine("");
        Console.WriteLine("||   **********************************  ||");
        Console.WriteLine(""); 
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("||               DATOS                   ||");
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("Nombre Estela           || Genero F");
        Console.WriteLine("");
        Console.WriteLine("Edad  20                || Ciudad Yoro ");
        Console.WriteLine(""); 
        Console.WriteLine("");
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("||         Lista De Ingresos Activos     ||");
        Console.WriteLine ("Codido, Descripcion, Existencia");
        Console.WriteLine("");  

        foreach (var paciente in ListadePaciente)
        {
            
            Console.WriteLine(paciente.Codigo + " | " + paciente.Descripcion + " | " + paciente.Existencia );
    
           

        }
        
        Console.ReadLine();
    }

    private void movimientoSalas (string codigo, int cantidad, string tipoMovimiento){
        foreach (var paciente in ListadePaciente)
        {
            if (paciente.Codigo == codigo) {
                if (tipoMovimiento == "+"){
                    paciente.Existencia =  paciente.Existencia + cantidad;
                } else {
                    paciente.Existencia = paciente.Existencia - cantidad;
                }       
            }
        }
    }

    public void ingresoDePruebas() {
        string cuidad = "";
        string codigo = "";
        string cantidad = "";
        string edad = "";
        string genero = "";
        

        Console.Clear();
        Console.WriteLine();

        System.Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("||  Hoja De Ingreso De Pacientes con CIVID-19  ||");
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+**+*");
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+**+*");
        System.Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Ingrese el Codigo del Paciente: ");
        codigo = Console.ReadLine(); 
        Console.WriteLine("Ingrese el numero de Paciente ");
        cantidad = Console.ReadLine();
        Console.WriteLine("Ingrese la ciudad en que Habita ");
        cuidad = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del paciente ");
        edad = Console.ReadLine();
        Console.WriteLine("Ingrese la genero del paciente ");
        genero = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad),"+");
    }

    public void salidaDePacientes (){
        string codigo = "";
        string cantidad ="";

        Console.Clear();
        Console.WriteLine();

        System.Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("Ingreso de Altas De Paciente:");
        System.Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        Console.WriteLine("Ingreso el Codigo De la Sala:"); 
        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*");
        codigo = Console.ReadLine(); 
        Console.WriteLine("Ingreso la cantidad de Altas");
        cantidad = Console.ReadLine();

        movimientoSalas(codigo, Int32.Parse(cantidad),"-");
    }

}