using System.ComponentModel.DataAnnotations;

namespace ApiEmpresas.Services.Models
{
    public class EmpresasPostModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome da empresa.")]
        public string? Nome_Empresa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o saldo inicial.")]
        public decimal? Saldo { get; set; }

    }
}
