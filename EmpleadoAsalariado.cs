
namespace SistemaDeNominaPolimor
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numSeguroSocial, decimal salarioSemanal)
            : base(primerNombre, apellidoPaterno, numSeguroSocial)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularIngreso()
        {
            return SalarioSemanal;
        }
    }
}
