using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class CuadresVendedores
    {
        [Key]
        public int CuadreId  { get; set; }
        public int VendedorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }
        public List<CuadresVendedorDetalles> Lista { get; set; }


        //public virtual List<CuadresVendedorDetalles> detalle { get; set; }

        public CuadresVendedores()
        {
            this.CuadreId = 0;
            this.VendedorId = 0;
            this.Monto = 0;
            
            this.Concepto = "";
            this.Lista = new List<CuadresVendedorDetalles>();
            
        }
       
        public void AgregarDetalle(int Pendiente, int Monto, int Vendido, int Gastos, int Pagos, int Comision, int Ganancia)
        {
         
            this.Lista.Add(new CuadresVendedorDetalles(Pendiente, Monto, Vendido, Gastos, Pagos, Comision, Ganancia));
           
        }
    }
}