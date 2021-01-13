using System;
using System.Collections.Generic;

#nullable disable

namespace Integracion.Entity
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Puesto { get; set; }
        public double Sueldo { get; set; }
        public int IdGrupo { get; set; }

        public virtual Grupo IdGrupoNavigation { get; set; }
    }
}
