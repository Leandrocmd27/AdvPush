using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvPush.Domain;

[Table("Processos")]
public class Processo
{
    [Key]
    public int ProcessoId { get; set; }

    [Required]
    [StringLength(25)]
    public string? NumeroProcesso { get; set; }

    [Required]
    [StringLength(10)]
    public string? TipoAcao { get; set; }
    public Boolean PrazoAberto { get; set; }

    [Required]
    [StringLength(10)]
    public int Status { get; set; }
    public DateTime DataPrazo { get; set; }
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public DateTime DataCadastro { get; set; }
}
