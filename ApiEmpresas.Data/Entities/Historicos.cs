using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Data.Entities
{
    public class Historicos
    {
        private Guid? _idHistoricos;
        private Tipo_Movimentacao? _tipo;
        private decimal? _saldoMovimentacao ;
        private DateTime? _dataMovimentacao;
        private Guid? _idEmpresa;

        public Guid? IdHistoricos { 
            get => _idHistoricos;
            set => _idHistoricos = value;
        }
        public Tipo_Movimentacao? Tipo { 
            get => _tipo;
            set => _tipo = value;
        }
        public decimal? SaldoMovimentacao { 
            get => _saldoMovimentacao;
            set => _saldoMovimentacao = value;
        }
        public DateTime? DataMovimentacao { 
            get => _dataMovimentacao;
            set => _dataMovimentacao = value;
        }
        public Guid? IdEmpresa {
            get => _idEmpresa;
            set => _idEmpresa = value;
        }
    }
}
