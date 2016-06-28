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
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControlLogin controleLogin = new ControlLogin();
            int tipoLogin = controleLogin.TipoLogin(txtBoxUsuario.Text, txtBoxSenha.Text);
            if (tipoLogin == 1)
            {
                ViewMenuAdmin menuGerenteGUI = new ViewMenuAdmin();
                this.Hide();
                menuGerenteGUI.ShowDialog();
                this.Close();
            }
            else if (tipoLogin == 2)
            {
                ViewMenuAlmoxarifado menuAlmoxarifadoGUI = new ViewMenuAlmoxarifado();
                this.Hide();
                menuAlmoxarifadoGUI.ShowDialog();
                this.Close();
            }
            else if (tipoLogin == 3)
            {
                ViewMenuComum menuAuxProdGUI = new ViewMenuComum();
                this.Hide();
                menuAuxProdGUI.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario não cadastrado ou erro de digitação", "Usuário invalido",MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Refresh();
                txtBoxSenha.Clear();
                txtBoxUsuario.Clear();
            }
        }
    }
}
