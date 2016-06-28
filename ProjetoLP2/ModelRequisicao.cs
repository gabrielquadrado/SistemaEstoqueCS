using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ModelRequisicao
    {
        private int codigoRequisicao;
        private DateTime dataRequisicao;
        private int quantidade;
        private string idAlmoxarife;
        private string idAuxProducao;
        private int codItem;

        public int CodigoRequisicao
        {
            get
            {
                return codigoRequisicao;
            }

            set
            {
                codigoRequisicao = value;
            }
        }

        public DateTime DataRequisicao
        {
            get
            {
                return dataRequisicao;
            }

            set
            {
                dataRequisicao = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
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

        public string IdAuxProducao
        {
            get
            {
                return idAuxProducao;
            }

            set
            {
                idAuxProducao = value;
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
    }
}