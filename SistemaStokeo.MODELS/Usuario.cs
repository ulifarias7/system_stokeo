using System;
using System.Collections.Generic;

namespace SistemaStokeo.MODELS;

public partial class Usuario
{   
    public int IdUsuario { get; set; }
    public string? NombreCompleto { get; set; }
    public string? Correo { get; set; }
    public int? IdRol { get; set; }
    public string? Clave { get; set; }
    public bool? EsActivo { get; set; }
    public DateTime? FechaRegistro { get; set; }
    public virtual Rol? IdRolNavigation { get; set; }

}

//{
//  "idUsuario": 0,
//  "nombreCompleto": "Ulises",
//  "correo": "ulisesnicolasfarias@yopmail.com",
//  "idRol": 1,
//  "clave": "Ulises123!",
//  "esActivo": 0,
//  "rolDescripcion": "Administrador"
//}