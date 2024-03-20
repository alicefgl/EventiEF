using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;

public class Membro{
    [Key]
    public string Nickname { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
}