using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ModelPedido
    {
        private int numeroPedido;
        private float orcamento;
        private string descricao;
        private DateTime dataPedido;
        private string statusPedido;
        private DateTime dataAutorizacao;
        private int codItem;
        private string cnpjFornecedor;
        private string idAlmoxarife;

        public int NumeroPedido
        {
            get
            {
                return numeroPedido;
            }

            set
            {
                numeroPedido = value;
            }
        }

        public float Orcamento
        {
            get
            {
                return orcamento;
            }

            set
            {
                orcamento = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public DateTime DataPedido
        {
            get
            {
                return dataPedido;
            }

            set
            {
                dataPedido = value;
            }
        }

        public string StatusPedido
        {
            get
            {
                return statusPedido;
            }

            set
            {
                statusPedido = value;
            }
        }

        public DateTime DataAutorizacao
        {
            get
            {
                return dataAutorizacao;
            }

            set
            {
                dataAutorizacao = value;
            }
        }

        public int CodItem
        {
            get
            {
                return codItem;
            }

            set
            {
                codItem = value;
            }
        }

        public string CnpjFornecedor
        {
            get
            {
                return cnpjFornecedor;
            }

            set
            {
                cnpjFornecedor = value;
            }
        }

        public string IdAlmoxarife
        {
            get
            {
                return idAlmoxarife;
            }

            set
            {
                idAlmoxarife = value;
            }
        }
    }
}
