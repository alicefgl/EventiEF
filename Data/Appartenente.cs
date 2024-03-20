using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;

public class Appartenente {
    [Key]
    public string IdAppartenenza { get; set; }
    public string? CodEvento { get; set; }
    public Evento? Evento { get; set; }
    public string? Categorie { get; set; }
    public Categoria? Categoria { get; set; }
}
