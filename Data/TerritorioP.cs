using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;

public class TerritorioP{
    [Key]
    public string Nome { get; set; }
}