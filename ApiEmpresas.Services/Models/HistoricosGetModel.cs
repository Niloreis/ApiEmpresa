using System.ComponentModel.DataAnnotations;

namespace ApiEmpresas.Services.Models
{
    public class HistoricosGetModel
    {
        public Guid? IdHistoicos { get; set; }

        public Tipo_Movimentacao Tipo { get; set; }

        public DateTime DataMovimentacao { get; set; }

        public EmpresasGetModel? Empresa { get; set; }
    }
}

