using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;


public class Categoria {
    [Key]
    public string Nome { get; set; }
    public string Descrizione { get; set; }
}