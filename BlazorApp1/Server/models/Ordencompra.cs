using System;
using System.Collections.Generic;

namespace BlazorApp1.Server.models
{
    public partial class Ordencompra
    {
        public int Id { get; set; }
        public string? Estado { get; set; }
        public string? Especificacion { get; set; }
        public string? Archivo { get; set; }
        public int? Insumo { get; set; }
        public int? Cantidad { get; set; }
        public int? Proveedor { get; set; }
        public DateTime? Generada { get; set; }
        public DateTime? Aprobada { get; set; }
        public DateTime? Recepcionada { get; set; }
    }
}
