

using Patron_reposity;

string txt = "registro.txt";

IEmpleadosRepo empleado_repo = new EmpleadosArchivo(txt);

GestorEmpleados gestor = new GestorEmpleados(empleado_repo);

gestor.Registrar(new Empleado { _nombre = "jose", _edad = 18, _puesto = "gerente" });


Console.WriteLine("estos son los empleados registrados: ");

foreach (var empleado in gestor.todosLosEmpleados())
{
    Console.WriteLine($"Nombre: {empleado._nombre},edad: {empleado._edad},puesto: {empleado._puesto}");
}