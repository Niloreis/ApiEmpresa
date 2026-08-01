using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ApiEmpresas.Services.Models
{
    public class EmpresasPutModel
    {
        [Required(ErrorMessage = "Por favor, informe  o id da empressa  desejada.")]
        public Guid? IdEmpresa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome da empresa.")]
        public string? Nome_Empresa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o saldo inicial.")]
        public decimal? Saldo { get; set; }

    }
}
