﻿using System;

namespace SistemaStokeo.MODELS;

public partial class NumeroDocumento
{
    public int IdNumeroDocumento { get; set; }

    public int? UltimoNumero { get; set; }
    
    public DateTime? FechaRegistro { get; set; }
}
