namespace ProjetoLP2
{
    partial class ViewMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuAdmin));
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btnCadastrarItem = new System.Windows.Forms.Button();
            this.btnConsultarFornecedores = new System.Windows.Forms.Button();
            this.btnConsultarItens = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnRequisitarItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(11, 88);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(340, 32);
            this.btnCadastrarFornecedor.TabIndex = 6;
            this.btnCadastrarFornecedor.Text = "Cadastrar fornecedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // btnCadastrarItem
            // 
            this.btnCadastrarItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarItem.Location = new System.Drawing.Point(13, 50);
            this.btnCadastrarItem.Name = "btnCadastrarItem";
            this.btnCadastrarItem.Size = new System.Drawing.Size(340, 32);
            this.btnCadastrarItem.TabIndex = 5;
            this.btnCadastrarItem.Text = "Cadastrar ítem";
            this.btnCadastrarItem.UseVisualStyleBackColor = false;
            this.btnCadastrarItem.Click += new System.EventHandler(this.btnCadastrarItem_Click);
            // 
            // btnConsultarFornecedores
            // 
            this.btnConsultarFornecedores.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarFornecedores.Location = new System.Drawing.Point(12, 205);
            this.btnConsultarFornecedores.Name = "btnConsultarFornecedores";
            this.btnConsultarFornecedores.Size = new System.Drawing.Size(340, 32);
            this.btnConsultarFornecedores.TabIndex = 8;
            this.btnConsultarFornecedores.Text = "Consultar fornecedores";
            this.btnConsultarFornecedores.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedores.Click += new System.EventHandler(this.btnConsultarFornecedores_Click);
            // 
            // btnConsultarItens
            // 
            this.btnConsultarItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarItens.Location = new System.Drawing.Point(12, 164);
            this.btnConsultarItens.Name = "btnConsultarItens";
            this.btnConsultarItens.Size = new System.Drawing.Size(340, 32);
            this.btnConsultarItens.TabIndex = 7;
            this.btnConsultarItens.Text = "Consultar itens";
            this.btnConsultarItens.UseVisualStyleBackColor = false;
            this.btnConsultarItens.Click += new System.EventHandler(this.btnConsultarItens_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(13, 12);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(340, 32);
            this.btnCadastrarUsuario.TabIndex = 5;
            this.btnCadastrarUsuario.Text = "Cadastrar usuário";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnRequisitarItem
            // 
            this.btnRequisitarItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnRequisitarItem.Location = new System.Drawing.Point(14, 246);
            this.btnRequisitarItem.Name = "btnRequisitarItem";
            this.btnRequisitarItem.Size = new System.Drawing.Size(340, 32);
            this.btnRequisitarItem.TabIndex = 9;
            this.btnRequisitarItem.Text = "Requisitar ítem";
            this.btnRequisitarItem.UseVisualStyleBackColor = false;
            this.btnRequisitarItem.Click += new System.EventHandler(this.btnRequisitarItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Consultar usuários";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnConsultarUsuarios_Click);
            // 
            // ViewMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(365, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRequisitarItem);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.btnCadastrarItem);
            this.Controls.Add(this.btnConsultarFornecedores);
            this.Controls.Add(this.btnConsultarItens);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewMenuAdmin";
            this.Text = "Menu - Usuário administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button btnCadastrarItem;
        private System.Windows.Forms.Button btnConsultarFornecedores;
        private System.Windows.Forms.Button btnConsultarItens;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnRequisitarItem;
        private System.Windows.Forms.Button button1;
    }
}