using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvPush.Domain;

[Table("Clientes")]
public class Cliente
{
    public Cliente()
    {
        Processos = new Collection<Processo>();
    }
    [Key]
    public int ClienteId { get; set; }

    [Required]
    [StringLength(250)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(350)]
    public string? ImagemUrl { get; set; }
    public ICollection<Processo> Processos { get; set; }
}
