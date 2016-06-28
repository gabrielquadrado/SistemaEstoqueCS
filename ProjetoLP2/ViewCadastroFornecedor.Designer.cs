namespace ProjetoLP2
{
    partial class ViewCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastroFornecedor));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCnpjMask = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxTelefoneMask = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(13, 118);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(117, 24);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão social:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCnpj.Location = new System.Drawing.Point(13, 12);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(54, 24);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(93, 24);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 280);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(86, 24);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(17, 88);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(244, 32);
            this.txtBoxNome.TabIndex = 2;
            // 
            // txtBoxRazaoSocial
            // 
            this.txtBoxRazaoSocial.Location = new System.Drawing.Point(16, 140);
            this.txtBoxRazaoSocial.Name = "txtBoxRazaoSocial";
            this.txtBoxRazaoSocial.Size = new System.Drawing.Size(245, 32);
            this.txtBoxRazaoSocial.TabIndex = 3;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(16, 194);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(245, 32);
            this.txtBoxEndereco.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(17, 250);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(244, 32);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxCnpjMask
            // 
            this.txtBoxCnpjMask.Location = new System.Drawing.Point(17, 35);
            this.txtBoxCnpjMask.Mask = "00.000.000/0000-00";
            this.txtBoxCnpjMask.Name = "txtBoxCnpjMask";
            this.txtBoxCnpjMask.Size = new System.Drawing.Size(244, 32);
            this.txtBoxCnpjMask.TabIndex = 1;
            // 
            // txtBoxTelefoneMask
            // 
            this.txtBoxTelefoneMask.Location = new System.Drawing.Point(16, 302);
            this.txtBoxTelefoneMask.Mask = "(00) 0000-0000";
            this.txtBoxTelefoneMask.Name = "txtBoxTelefoneMask";
            this.txtBoxTelefoneMask.Size = new System.Drawing.Size(245, 32);
            this.txtBoxTelefoneMask.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(58, 345);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 34);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // ViewCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(277, 394);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxTelefoneMask);
            this.Controls.Add(this.txtBoxCnpjMask);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.txtBoxRazaoSocial);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewCadastroFornecedor";
            this.Text = "Novo fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxRazaoSocial;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.MaskedTextBox txtBoxCnpjMask;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefoneMask;
        private System.Windows.Forms.Button btnCadastrar;
    }
}