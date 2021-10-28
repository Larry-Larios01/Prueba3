using Domain.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ActivoFijo
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public decimal ValorActivo { get; set; }

        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }

        public TipoActivo TipoActivo { get; set; }
        public TipoDepreciacion depreciacion { get; set; }
    }
}
