public class Paciente
{
    // Datos personales
    public int PacienteID {  get; set; }
    public string Nombres { get; set; }
    public string NombreCompleto { get; set; }
    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Sexo { get; set; } // false = Hombre, true = Mujer
    public string CURP { get; set; }
    public string Nacionalidad { get; set; }

    // Dirección
    public string? Calle { get; set; }
    public string? Numero { get; set; }
    public string? Colonia { get; set; }
    public string? CP { get; set; }
    public string? Estado { get; set; }
    public string? Municipio { get; set; }
    public string? Telefono { get; set; }

    // Datos generales
    public string? Escolaridad { get; set; }
    public string? EstadoCivil { get; set; }
    public string? Ocupacion { get; set; }
    public string Religion { get; set; }

    // Datos médicos
    public string? TratamientosExistentes { get; set; }
    public string? Aseguradora { get; set; }
    public string? NumeroPoliza { get; set; }
    public string? AlergiasMedicamentos { get; set; }
    public string? AlergiasAlimentos { get; set; }
    public string? AlergiasAmbiente { get; set; }

    public string? AlergiasMaterial { get; set; }

    // Dificultades
    public bool DificultadHabla { get; set; }
    public bool DificultadAuditiva { get; set; }
    public bool DificultadVisual { get; set; }
    public bool DificultadMental { get; set; }
    public bool DificultadPsicologica { get; set; }
    public bool DificultadMotriz { get; set; }
    public bool UsaEquipoAuditivo { get; set; }
    public bool UsaLentes { get; set; }
}
