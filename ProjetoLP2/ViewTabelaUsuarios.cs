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
    public partial class ViewTabelaUsuarios : Form
    {
        public ViewTabelaUsuarios()
        {
            InitializeComponent();
        }

        private void ViewTabelaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.estoqueDataSet.funcionario);

        }
    }
}
