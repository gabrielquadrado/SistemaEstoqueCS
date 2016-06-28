using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ModelFornecedor
    {
        private string cnpj;
        private string nomeFantasia;
        private string email;
        private string razaoSocial;
        private string logradouro;
        private int numero;
        private string cep;
        private string cidade;
        private string estado;
        private string idAlmoxarife;
        private List<int> telefones = new List<int>();
        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return nomeFantasia;
            }

            set
            {
                nomeFantasia = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
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
