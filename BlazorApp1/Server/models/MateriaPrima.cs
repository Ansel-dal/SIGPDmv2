using System;
using System.Collections.Generic;

namespace BlazorApp1.Server.models
{
    public partial class MateriaPrima
    {
        public int Id { get; set; }
        public int? StockMin { get; set; }
        public int? StockMax { get; set; }
        public int? StockReal { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo { get; set; }
    }
}
