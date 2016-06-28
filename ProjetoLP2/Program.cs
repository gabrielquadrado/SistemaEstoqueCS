using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLP2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewLogin());
            /*Application.Run(new ViewCadastroUsuario());
            Application.Run(new ViewTabelaUsuarios());
            Application.Run(new ViewCadastroItens());
            Application.Run(new ViewTabelaItens());
            Application.Run(new ViewTabelaItensAdmin());
            Application.Run(new ViewCadastroFornecedor());
            Application.Run(new ViewTabelaFornecedores());
            Application.Run(new ViewTabelaFornecedoresAdmin());
            Application.Run(new ViewMenuComum());
            Application.Run(new ViewMenuAlmoxarifado());
            Application.Run(new ViewMenuAdmin());
            Application.Run(new ViewRequisicaoItem());*/
        }
    }
}
