using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class Gastos
    {
        [Key]

        public int GastoId { get; set; }
        public int VendedorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }
    }
}