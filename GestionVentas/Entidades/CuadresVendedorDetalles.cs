using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using System.Data;

namespace GestionVentas.Entidades
{
    public class CuadresVendedorDetalles
    {
        [Key]
        public int Id { get; set; }
        
        public int CuadreId { get; set; }
        public int Pendiente { get; set; }
        public int Monto { get; set; }
        public int Vendido { get; set; }
        public int Subsidios { get; set; }
        public int Gastos { get; set; }
        public int Pagos { get; set; }
        public int Comision { get; set; }
        public int Ganancia { get; set; }
        


        public virtual List<CuadresVendedores> cuadrevendedor { get; set; }
        //public CuadresVendedorDetalles(int vendido)
        //{
        //    this.cuadrevendedor = new List<CuadresVendedores>();
        //}

        public CuadresVendedorDetalles(int Pendiente, int Monto,int Vendido,int Gastos,int Pagos,int Comision, int Ganancia)
        {
            this.Pendiente=Pendiente;
            this.Monto = Monto;
            this.Vendido = Vendido;
            this.Gastos = Gastos;
            this.Pagos = Pagos;
            this.Comision = Comision;
            this.Ganancia = Ganancia;
            
        }

        public CuadresVendedorDetalles()
        {
           
                this.Pendiente = 0;
                this.Monto = 0;
                this.Vendido = 0;
            this.Gastos = 0;
            this.Pagos = 0;
            this.Comision = 0;
            this.Ganancia = 0;
            
        }

       

        
       
    }
}