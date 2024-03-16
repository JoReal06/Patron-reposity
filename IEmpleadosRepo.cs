using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_reposity
{
    public interface IEmpleadosRepo
    {
        //GENERAMOS LOS METODOS QUE SERAN NECESARIOS USAR TANTO 

        List<Empleado> mirarEmpleados();
        void guardar (List<Empleado> empleados);
    }
}
