using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_reposity
{
    public  class GestorEmpleados
    {

        //ESTA CLASE SE ENCARGA DE HACER LA PARTE DE REGISTRAR Y MOSTRAR LOS EMPLEADOS QUE ESTAN REGISTRADOS,
        //EL USO DE UNA VARIABLE DE TIPO DE INTERFAZ  HACE QUE NO HAYA LA NECESIDAD DE MODIFICAR ESTA CLASE EN BASE
        //AL TIPO DE OBJETO QUE SE ESTE TRABJANDO, O SEA LA INTERFAZ LE DICE AL A LA CLASE EL TIPO DE OBJETO A TRABAJAR.

        public IEmpleadosRepo rep;

        public GestorEmpleados(IEmpleadosRepo Rep)
        {
            rep = Rep;
        }

        public List<Empleado> todosLosEmpleados()
        { 
            return rep.mirarEmpleados();
        }

        public void Registrar(Empleado empleado) 
        {
            List<Empleado> empleados = rep.mirarEmpleados();
            empleados.Add(empleado);
            rep.guardar(empleados);
        }

    }
}
