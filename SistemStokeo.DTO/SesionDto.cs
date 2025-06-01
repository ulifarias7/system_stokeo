﻿using System;

namespace SistemStokeo.DTO
{
    public class SesionDto
    {
        public int IdUsuario { get; set; }

        public string? NombreCompleto { get; set; }
        
        public string? Correo { get; set; }
        
        public string? RolDescripcion { get; set; }
        
        public string? Token { get; set; }
    }
}
