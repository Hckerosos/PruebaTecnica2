using Integracion.Entity;
using Modelos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integracion.Dao
{
    public class EmpleadoDao
    {
        #region Obtener 

        public List<EmpleadoDto> ObtenerEmpleados()
        {
            var rta = new List<EmpleadoDto>();

            using (var bd = new PruebaContext())
            {
                var empleados = bd.Empleados.ToArray();
                foreach (var empleado in empleados)
                {
                    rta.Add(new EmpleadoDto()
                    {
                        Id = empleado.Id,
                        Nombre = empleado.Nombre,
                        Codigo = empleado.Codigo,
                        Puesto = empleado.Puesto,
                        Sueldo = empleado.Sueldo,
                        IdGrupo = empleado.IdGrupo,
                    });
                }
            }
            return rta;
        }

        #endregion

        #region Insertar 
        public EmpleadoDto InsertarEmpleados(EmpleadoDto empleado)
        {
            var rta = new EmpleadoDto();

            using (var bd = new PruebaContext())
            {

                var _empleado = new Empleado()
                {
                    Id = empleado.Id,
                    Nombre = empleado.Nombre,
                    Codigo = empleado.Codigo,
                    Puesto = empleado.Puesto,
                    Sueldo = empleado.Sueldo,
                    IdGrupo = empleado.IdGrupo

                };
                bd.Add(_empleado);
                bd.SaveChanges();
            }

            return rta;
        }


        #endregion

        #region Actualizar 
        public EmpleadoDto ActualizarEmpleados(EmpleadoDto empleado)
        {
            var rta = new EmpleadoDto();

            using (var bd = new PruebaContext())
            {

                var _empleado = new Empleado()
                {
                    Id = empleado.Id,
                    Nombre = empleado.Nombre,
                    Codigo = empleado.Codigo,
                    Puesto = empleado.Puesto,
                    Sueldo = empleado.Sueldo,
                    IdGrupo = empleado.IdGrupo

                };
                bd.Entry(_empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                bd.SaveChanges();
            }

            return rta;
        }


        #endregion

        #region Eliminar

        public EmpleadoDto EliminarEmpleados(EmpleadoDto empleado)
        {
            var rta = new EmpleadoDto();

            using (var bd = new PruebaContext())
            {

                var _empleado = new Empleado()
                {
                    Id = empleado.Id,
                    Nombre = empleado.Nombre,
                    Codigo = empleado.Codigo,
                    Puesto = empleado.Puesto,
                    Sueldo = empleado.Sueldo,
                    IdGrupo = empleado.IdGrupo

                };
                bd.Remove(_empleado);
                bd.SaveChanges();
            }

            return rta;
        }


        #endregion



    }
}
