using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpresas.Data.Entities
{
    public class Empresas
    {
        private Guid? _idEmpresa;
        private string? _nomeEmpresa;
        private decimal? _Saldo;

        public Guid? IdEmpresa { 
            get => _idEmpresa; 
            set => _idEmpresa = value;
        }
        public string? NomeEmpresa {
            get => _nomeEmpresa; 
            set => _nomeEmpresa = value;
        }
        public decimal? Saldo {
            get => _Saldo;
            set => _Saldo = value;
        }
    }
}
