using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Dto
{
   public class EmpleadoDto
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Puesto { get; set; }
        public double Sueldo { get; set; }
        public int IdGrupo { get; set; }
        #endregion
    }
}
