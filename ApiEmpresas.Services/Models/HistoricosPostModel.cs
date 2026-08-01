using System.ComponentModel.DataAnnotations;

namespace ApiEmpresas.Services.Models
{
    // quando sair ou entrar dinheiro 
    public enum Tipo_Movimentacao
    {
        Entrda = 0,

        Saida = 1
    }

    public class HistoricosPostModel
    {
        [Required(ErrorMessage = "Por favor, informe se é entrada (0) ou saida (1)")]
        public Tipo_Movimentacao Tipo { get; set; }

        [Required(ErrorMessage = "Por favor, informe o quado está entrando ou saindo")]
        public decimal Saldo_Movimentacao { get; set; }  
        
        public DateTime DataMovimentacao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id da empresa")]
        public Guid? IdEmpresa { get; set; }
    }
}
