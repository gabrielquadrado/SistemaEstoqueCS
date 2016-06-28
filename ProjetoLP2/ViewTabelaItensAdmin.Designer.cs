namespace ProjetoLP2
{
    partial class ViewTabelaItensAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabelaItensAdmin));
            this.dtGridItensCadastradosAdm = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBoxdtGridItensCadastradosAdm = new System.Windows.Forms.TextBox();
            this.estoqueDataSet = new ProjetoLP2.estoqueDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ProjetoLP2.estoqueDataSetTableAdapters.itemTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidaeemestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlmoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItensCadastradosAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridItensCadastradosAdm
            // 
            this.dtGridItensCadastradosAdm.AutoGenerateColumns = false;
            this.dtGridItensCadastradosAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridItensCadastradosAdm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridItensCadastradosAdm.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGridItensCadastradosAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridItensCadastradosAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidaeemestoqueDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.idAlmoxDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn});
            this.dtGridItensCadastradosAdm.DataSource = this.itemBindingSource;
            this.dtGridItensCadastradosAdm.Location = new System.Drawing.Point(13, 13);
            this.dtGridItensCadastradosAdm.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridItensCadastradosAdm.MultiSelect = false;
            this.dtGridItensCadastradosAdm.Name = "dtGridItensCadastradosAdm";
            this.dtGridItensCadastradosAdm.Size = new System.Drawing.Size(942, 417);
            this.dtGridItensCadastradosAdm.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(833, 440);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 38);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(699, 440);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 38);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBoxdtGridItensCadastradosAdm
            // 
            this.txtBoxdtGridItensCadastradosAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxdtGridItensCadastradosAdm.Location = new System.Drawing.Point(13, 444);
            this.txtBoxdtGridItensCadastradosAdm.Name = "txtBoxdtGridItensCadastradosAdm";
            this.txtBoxdtGridItensCadastradosAdm.Size = new System.Drawing.Size(680, 27);
            this.txtBoxdtGridItensCadastradosAdm.TabIndex = 8;
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
            // ViewTabelaItensAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(967, 488);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxdtGridItensCadastradosAdm);
            this.Controls.Add(this.dtGridItensCadastradosAdm);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewTabelaItensAdmin";
            this.Text = "Ítens cadastrados - Admin";
            this.Load += new System.EventHandler(this.ViewTabelaItensAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridItensCadastradosAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridItensCadastradosAdm;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBoxdtGridItensCadastradosAdm;
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