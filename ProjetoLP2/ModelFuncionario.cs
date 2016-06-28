using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ModelFuncionario
    {
        private string id;
        private string cpf;
        private string rg;
        private string login;
        private string senha;
        private string nome;
        private int permissao;
        private DateTime dataNasc;
        private string idGerente;
        private DateTime dataCadastro;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
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

        public int Permissao
        {
            get
            {
                return permissao;
            }

            set
            {
                permissao = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        public string IdGerente
        {
            get
            {
                return idGerente;
            }

            set
            {
                idGerente = value;
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
    }
}
