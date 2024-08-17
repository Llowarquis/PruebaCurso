using System.ComponentModel.DataAnnotations;

namespace PrimerProyecto.Models;

public class Estudiantes
{
    [Key]
    public int EstudianteId { get; set; } // ID en la BD

    public string? nombre { get; set; }
    public int matricula { get; set; }
    public string? carrera { get; set; }
}
