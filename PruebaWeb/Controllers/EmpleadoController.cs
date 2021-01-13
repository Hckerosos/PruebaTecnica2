using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            var empleadoBl = new EmpleadoBl();
            var empleados = empleadoBl.ObtenerEmpleado().ToArray();
            var empleadoModelo = new List<EmpleadoModel>();
            foreach (var empleado in empleados)
            {
                empleadoModelo[Array.IndexOf(empleados, empleado)].Id = empleado.Id;
                empleadoModelo[Array.IndexOf(empleados, empleado)].Nombre = empleado.Nombre;
                empleadoModelo[Array.IndexOf(empleados, empleado)].Codigo = empleado.Codigo;
                empleadoModelo[Array.IndexOf(empleados, empleado)].Puesto = empleado.Puesto;
                empleadoModelo[Array.IndexOf(empleados, empleado)].Sueldo = empleado.Sueldo;
                empleadoModelo[Array.IndexOf(empleados, empleado)].IdGrupo = empleado.IdGrupo;
            }
            return View(empleadoModelo);
        }





    }
}
