using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ModelItem
    {
        private int codigo;
        private string nome;
        private int quantidadeEstoque;
        private string descricao;
        private DateTime dataCadastro;
        private int idAlmoxarife;
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int QuantidadeEstoque
        {
            get
            {
                return quantidadeEstoque;
            }

            set
            {
                quantidadeEstoque = value;
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

        public DateTime DataCadastro
        {
            get
            {
                return dataCadastro;
            }

            set
            {
                dataCadastro = value;
            }
        }

        public int IdAlmoxarife
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
