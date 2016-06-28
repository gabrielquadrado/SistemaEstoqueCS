namespace ProjetoLP2
{
    partial class ViewMenuAlmoxarifado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuAlmoxarifado));
            this.btnConsultarFornecedores = new System.Windows.Forms.Button();
            this.btnConsultarItens = new System.Windows.Forms.Button();
            this.btnCadastrarForncedor = new System.Windows.Forms.Button();
            this.btnCadastrarItem = new System.Windows.Forms.Button();
            this.btnRequisitarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarFornecedores
            // 
            this.btnConsultarFornecedores.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarFornecedores.Location = new System.Drawing.Point(12, 143);
            this.btnConsultarFornecedores.Name = "btnConsultarFornecedores";
            this.btnConsultarFornecedores.Size = new System.Drawing.Size(340, 32);
            this.btnConsultarFornecedores.TabIndex = 4;
            this.btnConsultarFornecedores.Text = "Consultar fornecedores";
            this.btnConsultarFornecedores.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedores.Click += new System.EventHandler(this.btnConsultarFornecedores_Click);
            // 
            // btnConsultarItens
            // 
            this.btnConsultarItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarItens.Location = new System.Drawing.Point(12, 100);
            this.btnConsultarItens.Name = "btnConsultarItens";
            this.btnConsultarItens.Size = new System.Drawing.Size(340, 32);
            this.btnConsultarItens.TabIndex = 3;
            this.btnConsultarItens.Text = "Consultar itens";
            this.btnConsultarItens.UseVisualStyleBackColor = false;
            this.btnConsultarItens.Click += new System.EventHandler(this.btnConsultarItens_Click);
            // 
            // btnCadastrarForncedor
            // 
            this.btnCadastrarForncedor.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarForncedor.Location = new System.Drawing.Point(12, 57);
            this.btnCadastrarForncedor.Name = "btnCadastrarForncedor";
            this.btnCadastrarForncedor.Size = new System.Drawing.Size(340, 32);
            this.btnCadastrarForncedor.TabIndex = 2;
            this.btnCadastrarForncedor.Text = "Cadastrar fornecedor";
            this.btnCadastrarForncedor.UseVisualStyleBackColor = false;
            this.btnCadastrarForncedor.Click += new System.EventHandler(this.btnCadastrarForncedor_Click);
            // 
            // btnCadastrarItem
            // 
            this.btnCadastrarItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarItem.Location = new System.Drawing.Point(12, 14);
            this.btnCadastrarItem.Name = "btnCadastrarItem";
            this.btnCadastrarItem.Size = new System.Drawing.Size(340, 32);
            this.btnCadastrarItem.TabIndex = 1;
            this.btnCadastrarItem.Text = "Cadastrar ítem";
            this.btnCadastrarItem.UseVisualStyleBackColor = false;
            this.btnCadastrarItem.Click += new System.EventHandler(this.btnCadastrarItem_Click);
            // 
            // btnRequisitarItem
            // 
            this.btnRequisitarItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnRequisitarItem.Location = new System.Drawing.Point(12, 186);
            this.btnRequisitarItem.Name = "btnRequisitarItem";
            this.btnRequisitarItem.Size = new System.Drawing.Size(340, 32);
            this.btnRequisitarItem.TabIndex = 5;
            this.btnRequisitarItem.Text = "Requisitar ítem";
            this.btnRequisitarItem.UseVisualStyleBackColor = false;
            this.btnRequisitarItem.Click += new System.EventHandler(this.btnRequisitarItem_Click);
            // 
            // ViewMenuAlmoxarifado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(364, 229);
            this.Controls.Add(this.btnRequisitarItem);
            this.Controls.Add(this.btnCadastrarForncedor);
            this.Controls.Add(this.btnCadastrarItem);
            this.Controls.Add(this.btnConsultarFornecedores);
            this.Controls.Add(this.btnConsultarItens);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewMenuAlmoxarifado";
            this.Text = "Menu - Usuário de almoxarifado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarFornecedores;
        private System.Windows.Forms.Button btnConsultarItens;
        private System.Windows.Forms.Button btnCadastrarForncedor;
        private System.Windows.Forms.Button btnCadastrarItem;
        private System.Windows.Forms.Button btnRequisitarItem;
    }
}