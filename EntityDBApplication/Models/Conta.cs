using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDBApplication.Models
{
    public class Conta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int IdConta { get; set; }
        [Required, StringLength(50), Column(Order = 1)]
        public string Nome { get; set; }
        [Required, StringLength(100), Column(Order = 2)]
        public string Descricao { get; set; }
    }
}
