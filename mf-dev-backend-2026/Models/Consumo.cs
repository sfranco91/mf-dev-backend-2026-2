using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{

    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data")]

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o valor")]

        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a quilometragem")]

        public int Km { get; set; }

        [Required(ErrorMessage = "Tipo do combustivel")]

        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veiculo")]
        [Required(ErrorMessage = "Obrigatorio informar o veiculo")]

        public int VeiculoID { get; set; }

        [ForeignKey("VeiculoID")]
        public Veiculo Veiculo { get; set; }
    }


    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        
    }
}
