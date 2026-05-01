using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar ano de fabricacao")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar ano do modelo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }


        public ICollection<Consumo> Consumos { get; set; }
    }
}