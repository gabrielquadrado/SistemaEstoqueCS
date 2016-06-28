namespace ProjetoLP2
{
    partial class ViewMenuComum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuComum));
            this.btnConsultarItens = new System.Windows.Forms.Button();
            this.btnConsultarFornecedores = new System.Windows.Forms.Button();
            this.btnRequisitarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarItens
            // 
            this.btnConsultarItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarItens.Location = new System.Drawing.Point(12, 12);
            this.btnConsultarItens.Name = "btnConsultarItens";
            this.btnConsultarItens.Size = new System.Drawing.Size(310, 32);
            this.btnConsultarItens.TabIndex = 1;
            this.btnConsultarItens.Text = "Consultar itens";
            this.btnConsultarItens.UseVisualStyleBackColor = false;
            this.btnConsultarItens.Click += new System.EventHandler(this.btnConsultarItens_Click);
            // 
            // btnConsultarFornecedores
            // 
            this.btnConsultarFornecedores.BackColor = System.Drawing.SystemColors.Control;
            this.btnConsultarFornecedores.Location = new System.Drawing.Point(12, 56);
            this.btnConsultarFornecedores.Name = "btnConsultarFornecedores";
            this.btnConsultarFornecedores.Size = new System.Drawing.Size(310, 32);
            this.btnConsultarFornecedores.TabIndex = 2;
            this.btnConsultarFornecedores.Text = "Consultar fornecedores";
            this.btnConsultarFornecedores.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedores.Click += new System.EventHandler(this.btnConsultarFornecedores_Click);
            // 
            // btnRequisitarItem
            // 
            this.btnRequisitarItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnRequisitarItem.Location = new System.Drawing.Point(12, 100);
            this.btnRequisitarItem.Name = "btnRequisitarItem";
            this.btnRequisitarItem.Size = new System.Drawing.Size(310, 32);
            this.btnRequisitarItem.TabIndex = 3;
            this.btnRequisitarItem.Text = "Requisitar ítem";
            this.btnRequisitarItem.UseVisualStyleBackColor = false;
            this.btnRequisitarItem.Click += new System.EventHandler(this.btnRequisitarItem_Click);
            // 
            // ViewMenuComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(334, 144);
            this.Controls.Add(this.btnRequisitarItem);
            this.Controls.Add(this.btnConsultarFornecedores);
            this.Controls.Add(this.btnConsultarItens);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewMenuComum";
            this.Text = "Menu - Usuário comum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarItens;
        private System.Windows.Forms.Button btnConsultarFornecedores;
        private System.Windows.Forms.Button btnRequisitarItem;
    }
}