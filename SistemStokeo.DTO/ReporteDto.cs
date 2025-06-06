﻿using System;

namespace SistemStokeo.DTO
{
   public class ReporteDto
   {
        public string? NumeroDocumento { get; set; }

        public string? TipoPago { get; set; }
        
        public string? FechaRegistro { get; set; }
        
        public string? TotalVenta { get; set; }
        
        public string? Producto { get; set; }
        
        public string? Cantidad { get; set; }
        
        public string? Precio  { get; set; }
        
        public string? Total { get; set; }
   }
}
