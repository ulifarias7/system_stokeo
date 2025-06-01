using System;

namespace SistemaStokeo.MODELS;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? nombre { get; set; }

    public DateTime? fechaRegistro { get; set; }

    public virtual ICollection<MenuRol> MenuRols { get; } = new List<MenuRol>();

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
