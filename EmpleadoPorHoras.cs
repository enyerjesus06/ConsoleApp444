

namespace SistemaDeNominaPolimor
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHoras { get; set; }
        public decimal HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string primerNombre, string apellidoPaterno, string numSeguroSocial, decimal sueldoPorHoras, decimal horasTrabajadas)
            : base(primerNombre, apellidoPaterno, numSeguroSocial)
        {
            SueldoPorHoras = sueldoPorHoras;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularIngreso()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHoras * HorasTrabajadas;
            }
            else
            {
                return (40 * SueldoPorHoras) + ((HorasTrabajadas - 40) * SueldoPorHoras * 1.5m);
            }
        }
    }
}