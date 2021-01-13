using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaWeb2.Models
{
    public class EmpleadoModel
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Range(1, 10000)]
        public int Codigo { get; set; }
        public string Puesto { get; set; }
        public double Sueldo { get; set; }
        public int IdGrupo { get; set; }
        #endregion
    }
}
