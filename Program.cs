
using SistemaDeNominaPolimor;


List<Empleado> empleados = new List<Empleado>();

#region Empleado Asalariado
Console.WriteLine($"Calculo Para Empleado Asalariado");

Console.WriteLine("Digite el Nombre del Empleado Asalariado");
string primerNombre = Console.ReadLine();

Console.WriteLine("Digite el Apellido Paterno del Empleado");
string apellidoPaterno = Console.ReadLine();

Console.WriteLine("Digite Numero de Seguro Social");
string numSeguroSocial = Console.ReadLine();

Console.WriteLine("Digite pago del Empleado Asalariado");
decimal salarioSemanal = Convert.ToDecimal(Console.ReadLine());

EmpleadoAsalariado salario = new EmpleadoAsalariado(primerNombre, apellidoPaterno, numSeguroSocial, salarioSemanal);
empleados.Add(salario);
#endregion

#region EmpleadoPorHoras
Console.WriteLine($"Calculo Para Empleado que cobra Por Horas");

Console.WriteLine("Digite el Nombre del Empleado por Hora");
primerNombre = Console.ReadLine();

Console.WriteLine("Digite el Apellido del Empleado por Hora");
apellidoPaterno = Console.ReadLine();

Console.WriteLine("Digite Numero de Seguro Social");
numSeguroSocial = Console.ReadLine();

Console.WriteLine("Digite el Sueldo");
decimal sueldoPorHoras = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite Horas Trabajadas");
decimal horasTrabajadas = Convert.ToDecimal(Console.ReadLine());

EmpleadoPorHoras sueldoHora = new EmpleadoPorHoras(primerNombre, apellidoPaterno, numSeguroSocial, sueldoPorHoras, horasTrabajadas);
empleados.Add(sueldoHora);
#endregion

#region EmpleadoPorComision
Console.WriteLine($"Calculo Para Empleado que cobra Por Comision");

Console.WriteLine("Digite el Nombre del Empleado por Comision");
primerNombre = Console.ReadLine();

Console.WriteLine("Digite el Apellido del Empleado por Comision");
apellidoPaterno = Console.ReadLine();

Console.WriteLine("Digite Numero de Seguro Social");
numSeguroSocial = Console.ReadLine();

Console.WriteLine("Digite Monto de Ventas Brutas");
decimal ventasBrutas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite Tarifa De Comision");
decimal tarifaComision = Convert.ToDecimal(Console.ReadLine());

EmpleadoPorComision sueldoComision = new EmpleadoPorComision(primerNombre, apellidoPaterno, numSeguroSocial, ventasBrutas, tarifaComision);
empleados.Add(sueldoComision);
#endregion

#region EmpleadoBaseMasComision
Console.WriteLine($"Calculo Para Empleado Asalariado Mas Comision");

Console.WriteLine("Digite el Nombre del Empleado por Comision");
primerNombre = Console.ReadLine();

Console.WriteLine("Digite el Apellido del Empleado por Comision");
apellidoPaterno = Console.ReadLine();

Console.WriteLine("Digite Numero de Seguro Social");
numSeguroSocial = Console.ReadLine();

Console.WriteLine("Digite Monto de Ventas Brutas");
ventasBrutas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite Tarifa De Comision");
tarifaComision = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite Sueldo Base");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

EmpleadoBaseMasComision sueldoMasComision = new EmpleadoBaseMasComision(primerNombre, apellidoPaterno, numSeguroSocial, ventasBrutas, tarifaComision, salarioBase);
empleados.Add(sueldoMasComision);
foreach (Empleado empleado in empleados)
{
    Console.WriteLine("Empleado: {0} {1}Número de seguro social: {2}Ingreso: {3:C}",
        empleado.PrimerNombre, empleado.ApellidoPaterno, empleado.NumSeguroSocial, empleado.CalcularIngreso());

    if (empleado is EmpleadoBaseMasComision empleadoBaseMasComision)
    {
        Console.WriteLine("Ingreso con incremento del 10%: {0:C}", empleadoBaseMasComision.CalcularIngresoConIncremento());
    }
}
#endregion