using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    public class ProductoBE
    {
        private int ProductoID;
        private string NombeProducto;
        private int SupplierId;
        private int CategoriaId;
        private string CantidadPrecioUnitario;
        private decimal PrecioUnitario;
        private int UnidadStock;
        private int UnidadOrden;
        private int ReorderLevel;
        private bool Discontinuidad;

        public int ProductoID1 { get => ProductoID; set => ProductoID = value; }
        public string NombeProducto1 { get => NombeProducto; set => NombeProducto = value; }
        public int SupplierId1 { get => SupplierId; set => SupplierId = value; }
        public int CategoriaId1 { get => CategoriaId; set => CategoriaId = value; }
        public string CantidadPrecioUnitario1 { get => CantidadPrecioUnitario; set => CantidadPrecioUnitario = value; }
        public decimal PrecioUnitario1 { get => PrecioUnitario; set => PrecioUnitario = value; }
        public int UnidadStock1 { get => UnidadStock; set => UnidadStock = value; }
        public int UnidadOrden1 { get => UnidadOrden; set => UnidadOrden = value; }
        public int ReorderLevel1 { get => ReorderLevel; set => ReorderLevel = value; }
        public bool Discontinuidad1 { get => Discontinuidad; set => Discontinuidad = value; }
    }
}
