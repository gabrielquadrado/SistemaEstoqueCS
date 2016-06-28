namespace ProjetoLP2
{
    partial class ViewCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastroUsuario));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCpfMask = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxRgMask = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxSenhaUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxDataNascMask = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxDadosPessoais = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBoxPrivilegios = new System.Windows.Forms.ComboBox();
            this.lblPrivilegios = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxDadosPessoais.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 137);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.Location = new System.Drawing.Point(53, 25);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(116, 19);
            this.lblLoginUsuario.TabIndex = 1;
            this.lblLoginUsuario.Text = "Login de usuário";
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(53, 75);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(120, 19);
            this.lblSenhaUsuario.TabIndex = 2;
            this.lblSenhaUsuario.Text = "Senha de usuário";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 81);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 19);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(195, 80);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(32, 19);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(191, 25);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(143, 19);
            this.lblDataNasc.TabIndex = 5;
            this.lblDataNasc.Text = "Data de nascimento:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(16, 159);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(339, 27);
            this.txtBoxNome.TabIndex = 5;
            // 
            // txtBoxCpfMask
            // 
            this.txtBoxCpfMask.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCpfMask.Location = new System.Drawing.Point(15, 100);
            this.txtBoxCpfMask.Mask = "000,000,000-00";
            this.txtBoxCpfMask.Name = "txtBoxCpfMask";
            this.txtBoxCpfMask.Size = new System.Drawing.Size(161, 27);
            this.txtBoxCpfMask.TabIndex = 3;
            // 
            // txtBoxRgMask
            // 
            this.txtBoxRgMask.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRgMask.Location = new System.Drawing.Point(193, 100);
            this.txtBoxRgMask.Mask = "00,000,000-0";
            this.txtBoxRgMask.Name = "txtBoxRgMask";
            this.txtBoxRgMask.Size = new System.Drawing.Size(161, 27);
            this.txtBoxRgMask.TabIndex = 4;
            // 
            // txtBoxLoginUsuario
            // 
            this.txtBoxLoginUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginUsuario.Location = new System.Drawing.Point(56, 46);
            this.txtBoxLoginUsuario.Name = "txtBoxLoginUsuario";
            this.txtBoxLoginUsuario.Size = new System.Drawing.Size(244, 27);
            this.txtBoxLoginUsuario.TabIndex = 6;
            // 
            // txtBoxSenhaUsuario
            // 
            this.txtBoxSenhaUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSenhaUsuario.Location = new System.Drawing.Point(56, 96);
            this.txtBoxSenhaUsuario.Name = "txtBoxSenhaUsuario";
            this.txtBoxSenhaUsuario.PasswordChar = '*';
            this.txtBoxSenhaUsuario.Size = new System.Drawing.Size(244, 27);
            this.txtBoxSenhaUsuario.TabIndex = 7;
            // 
            // txtBoxDataNascMask
            // 
            this.txtBoxDataNascMask.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataNascMask.Location = new System.Drawing.Point(193, 45);
            this.txtBoxDataNascMask.Mask = "00/00/0000";
            this.txtBoxDataNascMask.Name = "txtBoxDataNascMask";
            this.txtBoxDataNascMask.Size = new System.Drawing.Size(161, 27);
            this.txtBoxDataNascMask.TabIndex = 2;
            // 
            // groupBoxDadosPessoais
            // 
            this.groupBoxDadosPessoais.BackColor = System.Drawing.Color.Lavender;
            this.groupBoxDadosPessoais.Controls.Add(this.txtBoxId);
            this.groupBoxDadosPessoais.Controls.Add(this.lblId);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBoxDataNascMask);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBoxCpfMask);
            this.groupBoxDadosPessoais.Controls.Add(this.lblNome);
            this.groupBoxDadosPessoais.Controls.Add(this.lblCpf);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBoxRgMask);
            this.groupBoxDadosPessoais.Controls.Add(this.lblRg);
            this.groupBoxDadosPessoais.Controls.Add(this.lblDataNasc);
            this.groupBoxDadosPessoais.Controls.Add(this.txtBoxNome);
            this.groupBoxDadosPessoais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDadosPessoais.Location = new System.Drawing.Point(12, 9);
            this.groupBoxDadosPessoais.Name = "groupBoxDadosPessoais";
            this.groupBoxDadosPessoais.Size = new System.Drawing.Size(364, 203);
            this.groupBoxDadosPessoais.TabIndex = 12;
            this.groupBoxDadosPessoais.TabStop = false;
            this.groupBoxDadosPessoais.Text = "Dados pessoais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBoxPrivilegios);
            this.groupBox2.Controls.Add(this.lblPrivilegios);
            this.groupBox2.Controls.Add(this.txtBoxSenhaUsuario);
            this.groupBox2.Controls.Add(this.txtBoxLoginUsuario);
            this.groupBox2.Controls.Add(this.lblLoginUsuario);
            this.groupBox2.Controls.Add(this.lblSenhaUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de login";
            // 
            // cbBoxPrivilegios
            // 
            this.cbBoxPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxPrivilegios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxPrivilegios.FormattingEnabled = true;
            this.cbBoxPrivilegios.Items.AddRange(new object[] {
            "Usuário administrador",
            "Usuário de almoxarife",
            "Usuário comum"});
            this.cbBoxPrivilegios.Location = new System.Drawing.Point(56, 146);
            this.cbBoxPrivilegios.Name = "cbBoxPrivilegios";
            this.cbBoxPrivilegios.Size = new System.Drawing.Size(244, 27);
            this.cbBoxPrivilegios.TabIndex = 8;
            // 
            // lblPrivilegios
            // 
            this.lblPrivilegios.AutoSize = true;
            this.lblPrivilegios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegios.Location = new System.Drawing.Point(56, 125);
            this.lblPrivilegios.Name = "lblPrivilegios";
            this.lblPrivilegios.Size = new System.Drawing.Size(76, 19);
            this.lblPrivilegios.TabIndex = 14;
            this.lblPrivilegios.Text = "Privilégios";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(110, 417);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(161, 31);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(14, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.Location = new System.Drawing.Point(15, 45);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(161, 27);
            this.txtBoxId.TabIndex = 1;
            // 
            // ViewCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(388, 454);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBoxDadosPessoais);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewCadastroUsuario";
            this.Text = "Novo usuário";
            this.groupBoxDadosPessoais.ResumeLayout(false);
            this.groupBoxDadosPessoais.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.MaskedTextBox txtBoxCpfMask;
        private System.Windows.Forms.MaskedTextBox txtBoxRgMask;
        private System.Windows.Forms.TextBox txtBoxLoginUsuario;
        private System.Windows.Forms.TextBox txtBoxSenhaUsuario;
        private System.Windows.Forms.MaskedTextBox txtBoxDataNascMask;
        private System.Windows.Forms.GroupBox groupBoxDadosPessoais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbBoxPrivilegios;
        private System.Windows.Forms.Label lblPrivilegios;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblId;
    }
}