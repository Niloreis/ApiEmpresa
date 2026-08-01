using System.ComponentModel.DataAnnotations;

namespace ApiEmpresas.Services.Models
{
    public class EmpresasGetModel
    {
        public Guid? IdEmpresa { get; set; }

        public string? Nome_Empresa { get; set; }

        public decimal? Saldo { get; set; }
    }
}
