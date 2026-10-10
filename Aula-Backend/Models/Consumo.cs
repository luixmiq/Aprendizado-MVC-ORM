using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aula_Backend.Models
{
    [Table("Consumos")]
     public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a quilometragem")]
        [Display(Name = "Quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Combustivel { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o veículo")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina, Etanol
    }
}