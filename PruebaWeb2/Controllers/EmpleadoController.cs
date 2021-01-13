using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaWeb2.Models;
using Negocio.ClassBl;
using PruebaWeb.Models;
using Modelos.Dto;

namespace PruebaWeb2.Controllers
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

                empleadoModelo.Add(new EmpleadoModel()
                {

                    Id = empleado.Id,
                    Nombre = empleado.Nombre,
                    Codigo = empleado.Codigo,
                    Puesto = empleado.Puesto,
                    Sueldo = empleado.Sueldo,
                    IdGrupo = empleado.IdGrupo
                });

            }
            return View(empleadoModelo);
        }


        [HttpPost]
        public IActionResult Insertar(EmpleadoModel empleadoModelo)
        {

            if (!ModelState.IsValid)
            {
                return empleadoModelo;
            }

            var empleadoBl = new EmpleadoBl();
            var empleados = empleadoBl.InsertarEmpleado(new EmpleadoDto() {
                Id = empleadoModelo.Id,
                Nombre = empleadoModelo.Nombre,
                Codigo = empleadoModelo.Codigo,
                Puesto = empleadoModelo.Puesto,
                Sueldo = empleadoModelo.Sueldo,
                IdGrupo = empleadoModelo.IdGrupo
            });

            return View(empleadoModelo);

        }



    }
}
