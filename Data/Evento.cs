using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;

public class Evento {
    [Key]
    public string CodEvento { get; set; }
    public DateTime Data { get; set; }
    public string titolo { get; set; }
    public string Artisti { get; set; }
    public string Nickname { get; set; }
    public Membro Membro { get; set; }
    public String NomeProvincia { get; set; }
    public TerritorioP TerritorioP { get; set; }
}