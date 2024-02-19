using System;
using System.Collections.Generic;

namespace datos_personales.Models;

public partial class DatosPersonale
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public int? Telefono { get; set; }

    public int Carnet { get; set; }

    public DateOnly Expededo { get; set; }

    public string Direccion { get; set; } = null!;
}
