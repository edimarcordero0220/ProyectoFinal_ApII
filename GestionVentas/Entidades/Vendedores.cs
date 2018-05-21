using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class Vendedores
    {
        [Key]
        public int VendedorId { get; set; }
        public string Nombres { get; set; }
        public string Descripcion { get; set; }
        public string MensajeInicial { get; set; }
        public string MensajeFinal { get; set; }
        public int Pct1 { get; set; }
        public int Pct2 { get; set; }
        public int Pct3 { get; set; }
        public int Pct4 { get; set; }
        public int Pct5 { get; set; }
        public int LimiteVentas { get; set; }

    }
}