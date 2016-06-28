using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    class Database
    {
        private static MySqlConnection conexao;
        private static Database instance;
        //LEMBREM DE CONFIGURAR AQUI O SEU PROPRIO LOGIN E SENHA DO BANCO!!!
        private const string URL = "Server=127.0.0.1;Database=estoque;Uid=root;Pwd=lombada;";

        private Database()
        {
            conexao = new MySqlConnection(URL);
        }

        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConexao()
        {
            return conexao;
        }

        public void ExecutarSQL(string qry)
        {
            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();
            MySqlCommand comm = new MySqlCommand(qry, conexao);
            comm.ExecuteNonQuery();
            conexao.Close();
        }


    }
}
