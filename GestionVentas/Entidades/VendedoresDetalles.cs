using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class VendedoresDetalles
    {
        [Key]
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public int CategoriaId { get; set; }
        public int MaximoVenta { get; set; }
        public List<VendedoresDetalles> Detalle;

        public VendedoresDetalles(int vendedorId, int categoriaId, int maximoVenta)
        {
            VendedorId = vendedorId;
            CategoriaId = categoriaId;
            MaximoVenta = maximoVenta;
        }

        public VendedoresDetalles()
        {
        }

      
        public void AgregarDetalle(int VendedorId, int CategoriaId, int MaximoVenta)
        {
            this.Detalle.Add(new VendedoresDetalles(VendedorId, CategoriaId, MaximoVenta));
        }
    }
}