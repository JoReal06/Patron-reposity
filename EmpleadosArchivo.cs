using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_reposity
{
    public class EmpleadosArchivo : IEmpleadosRepo
    {

        //ESTA CLASE SU FUNCION ES LEER Y ESCRBIR EN EL ARCHIVO "REGISTRO.TXT", VALIDANDO SUS EXCEPCIONES
        //LA IMPLEMENTACION DE LA INTERFAZ PERMITE SABER QUE TIPO DE OBJETOS SE VAN A LEER Y ESCRIBIR EN BASE
        // A LOS ATRIBUTOS QUE ESTE TENGA.

        private string _archivo;

        public EmpleadosArchivo(string archivo)
        {
            _archivo = archivo;
        }

        //leer txt

        public List<Empleado> mirarEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (StreamReader lector = new StreamReader(_archivo))
                { 
                    string line;
                    while ((line = lector.ReadLine()) != null)
                    {
                        string[] info = line.Split(',');
                        Empleado em = new Empleado
                        {
                            _nombre = info[0],
                            _edad = int.Parse(info[1]),
                            _puesto = info[2]

                        };
                        empleados.Add(em);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AL parecer hubo un error al intentar mirar los datos " + ex.Message);
            }

           return empleados;
        }


        //Guardar los datos

        public void guardar(List<Empleado> empleados)
        {
            try
            {
                using (StreamWriter escritor  = new StreamWriter(_archivo))
                {
                    foreach (Empleado empleado in empleados) 
                    {
                        escritor.WriteLine($"{empleado._nombre},{empleado._edad},{empleado._puesto}");
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("AL parecer hubo un error al escribir los datos " + ex.Message);
            }
        }
    }
}
