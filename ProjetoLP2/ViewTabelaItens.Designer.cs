namespace ProjetoLP2
{
    partial class ViewTabelaItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabelaItens));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxItensCadastrados = new System.Windows.Forms.TextBox();
            this.dtGridItensCadastrados = new System.Windows.Forms.DataGridView();
            this.estoqueDataSet = new ProjetoLP2.estoqueDataSet();
            this.estoqueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ProjetoLP2.estoqueDataSetTableAdapters.itemTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidaeemestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlmoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItensCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(752, 450);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 39);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBoxItensCadastrados
            // 
            this.txtBoxItensCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxItensCadastrados.Location = new System.Drawing.Point(16, 454);
            this.txtBoxItensCadastrados.Name = "txtBoxItensCadastrados";
            this.txtBoxItensCadastrados.Size = new System.Drawing.Size(730, 27);
            this.txtBoxItensCadastrados.TabIndex = 10;
            // 
            // dtGridItensCadastrados
            // 
            this.dtGridItensCadastrados.AllowUserToAddRows = false;
            this.dtGridItensCadastrados.AutoGenerateColumns = false;
            this.dtGridItensCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridItensCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridItensCadastrados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGridItensCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItensCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidaeemestoqueDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.idAlmoxDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn});
            this.dtGridItensCadastrados.DataSource = this.itemBindingSource;
            this.dtGridItensCadastrados.Location = new System.Drawing.Point(12, 12);
            this.dtGridItensCadastrados.Name = "dtGridItensCadastrados";
            this.dtGridItensCadastrados.Size = new System.Drawing.Size(903, 432);
            this.dtGridItensCadastrados.TabIndex = 12;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueDataSetBindingSource
            // 
            this.estoqueDataSetBindingSource.DataSource = this.estoqueDataSet;
            this.estoqueDataSetBindingSource.Position = 0;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.estoqueDataSetBindingSource;
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
            // ViewTabelaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(923, 497);
            this.Controls.Add(this.dtGridItensCadastrados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxItensCadastrados);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewTabelaItens";
            this.Text = "Ítens cadastrados";
            this.Load += new System.EventHandler(this.ViewTabelaItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItensCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxItensCadastrados;
        private System.Windows.Forms.DataGridView dtGridItensCadastrados;
        private System.Windows.Forms.BindingSource estoqueDataSetBindingSource;
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