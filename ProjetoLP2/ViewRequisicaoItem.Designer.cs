namespace ProjetoLP2
{
    partial class ViewRequisicaoItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRequisicaoItem));
            this.dtGridRequisitarItem = new System.Windows.Forms.DataGridView();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.btnRequisitar = new System.Windows.Forms.Button();
            this.estoqueDataSet = new ProjetoLP2.estoqueDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ProjetoLP2.estoqueDataSetTableAdapters.itemTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidaeemestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlmoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRequisitarItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridRequisitarItem
            // 
            this.dtGridRequisitarItem.AutoGenerateColumns = false;
            this.dtGridRequisitarItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridRequisitarItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridRequisitarItem.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGridRequisitarItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridRequisitarItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidaeemestoqueDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.idAlmoxDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn});
            this.dtGridRequisitarItem.DataSource = this.itemBindingSource;
            this.dtGridRequisitarItem.Location = new System.Drawing.Point(12, 12);
            this.dtGridRequisitarItem.Name = "dtGridRequisitarItem";
            this.dtGridRequisitarItem.Size = new System.Drawing.Size(770, 248);
            this.dtGridRequisitarItem.TabIndex = 0;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(26, 279);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(89, 19);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Location = new System.Drawing.Point(140, 277);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(100, 27);
            this.txtBoxQuantidade.TabIndex = 2;
            // 
            // btnRequisitar
            // 
            this.btnRequisitar.Location = new System.Drawing.Point(623, 273);
            this.btnRequisitar.Name = "btnRequisitar";
            this.btnRequisitar.Size = new System.Drawing.Size(159, 38);
            this.btnRequisitar.TabIndex = 3;
            this.btnRequisitar.Text = "Requisitar";
            this.btnRequisitar.UseVisualStyleBackColor = true;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.estoqueDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // quantidaeemestoqueDataGridViewTextBoxColumn
            // 
            this.quantidaeemestoqueDataGridViewTextBoxColumn.DataPropertyName = "quantidae_em_estoque";
            this.quantidaeemestoqueDataGridViewTextBoxColumn.HeaderText = "quantidae_em_estoque";
            this.quantidaeemestoqueDataGridViewTextBoxColumn.Name = "quantidaeemestoqueDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // idAlmoxDataGridViewTextBoxColumn
            // 
            this.idAlmoxDataGridViewTextBoxColumn.DataPropertyName = "idAlmox";
            this.idAlmoxDataGridViewTextBoxColumn.HeaderText = "idAlmox";
            this.idAlmoxDataGridViewTextBoxColumn.Name = "idAlmoxDataGridViewTextBoxColumn";
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            // 
            // ViewRequisicaoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(794, 320);
            this.Controls.Add(this.btnRequisitar);
            this.Controls.Add(this.txtBoxQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dtGridRequisitarItem);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewRequisicaoItem";
            this.Text = "Requisitar ítem";
            this.Load += new System.EventHandler(this.ViewRequisicaoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridRequisitarItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridRequisitarItem;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private System.Windows.Forms.Button btnRequisitar;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private estoqueDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidaeemestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlmoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
    }
}