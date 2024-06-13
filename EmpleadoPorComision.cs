
namespace SistemaDeNominaPolimor
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string numSeguroSocial, decimal ventasBrutas, decimal tarifaComision)
            : base(primerNombre, apellidoPaterno, numSeguroSocial)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override decimal CalcularIngreso()
        {
            return VentasBrutas * TarifaComision;
        }
    }
}