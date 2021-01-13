using Integracion.Dao;
using Modelos.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.ClassBl
{
  public  class EmpleadoBl
    {
        #region Obtener

        public List<EmpleadoDto> ObtenerEmpleado()
        {
            var empleados = new EmpleadoDao();
            try
            {

                return empleados.ObtenerEmpleados();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region Insertar
        public EmpleadoDto InsertarEmpleado(EmpleadoDto empleado)
        {
            var empleados = new EmpleadoDao();
            try
            {

                return empleados.InsertarEmpleados(empleado);
            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

        #region Actualizar
        public EmpleadoDto ActualizarEmpleado(EmpleadoDto empleado)
        {
            var empleados = new EmpleadoDao();
            try
            {

                return empleados.ActualizarEmpleados(empleado);
            }
            catch (Exception)
            {

                throw;
            }

        }


        #endregion

        #region Eliminar

        public EmpleadoDto EliminarEmpleado(EmpleadoDto empleado)
        {
            var empleados = new EmpleadoDao();
            try
            {

                return empleados.EliminarEmpleados(empleado);
            }
            catch (Exception)
            {

                throw;
            }

        }



        #endregion


    }
}
