using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLP2
{
    public partial class ViewMenuAdmin : Form
    {
        public ViewMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            ViewCadastroUsuario cadastroUsuarioGUI = new ViewCadastroUsuario();
            cadastroUsuarioGUI.ShowDialog();
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            ViewCadastroItens cadastroItensGUI = new ViewCadastroItens();
            cadastroItensGUI.ShowDialog();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            ViewCadastroFornecedor cadastroFornecedorGUI = new ViewCadastroFornecedor();
            cadastroFornecedorGUI.ShowDialog();
        }

        private void btnConsultarItens_Click(object sender, EventArgs e)
        {
            ViewTabelaItensAdmin tabelaItensGUI = new ViewTabelaItensAdmin();
            tabelaItensGUI.ShowDialog();
        }

        private void btnConsultarFornecedores_Click(object sender, EventArgs e)
        {
            ViewTabelaFornecedoresAdmin tabelaFornecedoresGUI = new ViewTabelaFornecedoresAdmin();
            tabelaFornecedoresGUI.ShowDialog();
        }

        private void btnRequisitarItem_Click(object sender, EventArgs e)
        {
            ViewRequisicaoItem requisicaoItemGUI = new ViewRequisicaoItem();
            requisicaoItemGUI.ShowDialog();
        }

        private void btnConsultarUsuarios_Click(object sender, EventArgs e)
        {
            ViewTabelaUsuarios tabelaUsuariosGUI = new ViewTabelaUsuarios();
            tabelaUsuariosGUI.ShowDialog();
        }
    }
}
