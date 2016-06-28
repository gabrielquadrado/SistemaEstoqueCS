using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ControlLogin
    {
        public int TipoLogin(string login, string senha)
        {
            int perm;
            MySqlConnection conexao = Database.GetInstance().GetConexao();
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            string qry = string.Format("SELECT permissao FROM funcionario WHERE login='{0}' AND senha='{1}';", login, senha);
            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                perm = dr.GetInt32("permissao");
                dr.Close();
                return perm;
            }
            else
            {
                dr.Close();
                return 0;
            }
        }
    }
}
