using System.ComponentModel.DataAnnotations;

namespace tESTE.Models
{
    public class Cliente
    {
        [Key]
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Idade { get; set; }
    }
}

