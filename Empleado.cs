
namespace SistemaDeNominaPolimor
{
    public abstract class Empleado
    {
        public string? PrimerNombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? NumSeguroSocial { get; set; } 

        // Constructor base
        public Empleado(string primerNombre, string apellidoPaterno, string numSeguroSocial)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumSeguroSocial = numSeguroSocial;
        }

        // Método abstracto para calcular ingreso
        public abstract decimal CalcularIngreso();
    }
}
