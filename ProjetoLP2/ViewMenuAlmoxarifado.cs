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
    public partial class ViewMenuAlmoxarifado : Form
    {
        public ViewMenuAlmoxarifado()
        {
            InitializeComponent();
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            ViewCadastroItens cadastroItensGUI = new ViewCadastroItens();
            cadastroItensGUI.ShowDialog();
        }

        private void btnCadastrarForncedor_Click(object sender, EventArgs e)
        {
            ViewCadastroFornecedor cadastroFornecedorGUI = new ViewCadastroFornecedor();
            cadastroFornecedorGUI.ShowDialog();
        }

        private void btnConsultarItens_Click(object sender, EventArgs e)
        {
            ViewTabelaItens tabelaItensGUI = new ViewTabelaItens();
            tabelaItensGUI.ShowDialog();
        }

        private void btnConsultarFornecedores_Click(object sender, EventArgs e)
        {
            ViewTabelaFornecedores tabelaFornecedoresGUI = new ViewTabelaFornecedores();
            tabelaFornecedoresGUI.ShowDialog();
        }

        private void btnRequisitarItem_Click(object sender, EventArgs e)
        {
            ViewRequisicaoItem requisicaoItemGUI = new ViewRequisicaoItem();
            requisicaoItemGUI.ShowDialog();
        }
    }
}
