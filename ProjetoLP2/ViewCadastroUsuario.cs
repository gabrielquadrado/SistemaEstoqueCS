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
    public partial class ViewCadastroUsuario : Form
    {
        public ViewCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ModelFuncionario funcionario = new ModelFuncionario();
            ControlFuncionario control = new ControlFuncionario();
            funcionario.Id = txtBoxId.Text;
            funcionario.DataNasc = DateTime.Parse(txtBoxDataNascMask.Text);
            funcionario.Cpf = txtBoxCpfMask.Text;
            funcionario.Rg = txtBoxRgMask.Text;
            funcionario.Nome = txtBoxNome.Text;
            funcionario.Login = txtBoxLoginUsuario.Text;
            funcionario.Senha = txtBoxSenhaUsuario.Text;
            funcionario.Permissao = (cbBoxPrivilegios.SelectedIndex + 1);
            funcionario.DataCadastro = DateTime.Now.Date;
            funcionario.IdGerente = "1";
            control.Create(funcionario);
            this.Close();
        }
    }
}
