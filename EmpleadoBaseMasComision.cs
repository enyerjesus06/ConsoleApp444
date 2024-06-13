

namespace SistemaDeNominaPolimor
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoBaseMasComision(string primerNombre, string apellidoPaterno, string numSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
            : base(primerNombre, apellidoPaterno, numSeguroSocial, ventasBrutas, tarifaComision)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularIngreso()
        {
            return SalarioBase + (VentasBrutas * TarifaComision);
        }

        public decimal CalcularIngresoConIncremento()
        {
            return SalarioBase * 1.1m + (VentasBrutas * TarifaComision); 
        }
    }
}