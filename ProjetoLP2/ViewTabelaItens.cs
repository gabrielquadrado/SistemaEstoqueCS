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
    public partial class ViewTabelaItens : Form
    {
        public ViewTabelaItens()
        {
            InitializeComponent();
        }

        private void ViewTabelaItens_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.estoqueDataSet.item);
            // TODO: This line of code loads data into the 'estoqueDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.estoqueDataSet.item);

        }
    }
}
