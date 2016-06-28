using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    class DAOFuncionario
    {
        public void Create(ModelFuncionario funcionario)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("insert into funcionario values ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},'{9}');",funcionario.Id,
                funcionario.Cpf, funcionario.Rg, funcionario.Login, funcionario.Senha, funcionario.Nome, funcionario.Permissao, funcionario.DataNasc.ToString("yyyy-MM-dd"),
                funcionario.IdGerente, funcionario.DataCadastro.ToString("yyyy-MM-dd"));
            db.ExecutarSQL(qry);
        }
        public ModelFuncionario Read(int id)
        {
            ModelFuncionario funcionario = null;
            MySqlConnection conexao = Database.GetInstance().GetConexao();
            string qry = "SELECT * FROM funcionario WHERE id=" + id;
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                funcionario = new ModelFuncionario();
                funcionario.Id = dr.GetString("id");
                funcionario.Cpf = dr.GetString("cpf");
                funcionario.Rg = dr.GetString("rg");
                funcionario.Login = dr.GetString("login");
                funcionario.Senha = dr.GetString("senha");
                funcionario.Nome = dr.GetString("nome");
                funcionario.Permissao = dr.GetInt32("permissao");
                funcionario.DataNasc = dr.GetDateTime("dataNasc");
                funcionario.IdGerente = dr.GetString("idGerente");
                funcionario.DataCadastro = dr.GetDateTime("dataCadastro");
            }
            conexao.Close();
            return funcionario;
        }
        public void Update(ModelFuncionario funcionario)
        {
            Database db= Database.GetInstance();
            string qry = string.Format("UPDATE funcionario SET cpf='{1}', rg='{2}', login='{3}', senha='{4}', nome='{5}', permissao={6}, dataNasc='{7}', idGerente='{8}', dataCadastro='{8}'"
                + "WHERE id={10};",funcionario.Cpf, funcionario.Rg, funcionario.Login, funcionario.Senha, funcionario.Nome, funcionario.Permissao, funcionario.DataNasc,
                funcionario.IdGerente, funcionario.DataCadastro, funcionario.Id);
            db.ExecutarSQL(qry);
        }
        public void Delete (string id)
        {
            Database db = Database.GetInstance();
            string qry = string.Format("DELETE FROM funcionario WHERE id={0}", id);
            db.ExecutarSQL("qry");
        }
    }
}
