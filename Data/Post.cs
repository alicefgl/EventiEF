using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace FogliettaA_5I_EventiEF.Data;

public class Post{
    [Key]
    public string IdPost { get; set; }
    public string Commento { get; set; }
    public float Voto { get; set; }
    public string Nickname { get; set; }
    public Membro Membro { get; set; }
}