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
    public partial class ViewTabelaFornecedoresAdmin : Form
    {
        public ViewTabelaFornecedoresAdmin()
        {
            InitializeComponent();
        }

        private void ViewTabelaFornecedoresAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.estoqueDataSet.fornecedor);
        }
    }
}
