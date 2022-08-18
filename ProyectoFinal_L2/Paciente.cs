public class Paciente
{
    public string Descripcion { get; set; }

    public int Existencia { get; set; }

    public string Codigo { get; set; }
    

    public Paciente (string descripcion, string codigo,  int existencia)
    {
        Descripcion = descripcion;

        Codigo = codigo;
        
        Existencia = existencia;
       
    }
}