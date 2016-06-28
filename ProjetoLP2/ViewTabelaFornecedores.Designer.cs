namespace ProjetoLP2
{
    partial class ViewTabelaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabelaFornecedores));
            this.dtGridFornecedoresCadastrados = new System.Windows.Forms.DataGridView();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefantasiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlmoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueDataSet = new ProjetoLP2.estoqueDataSet();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fornecedorTableAdapter = new ProjetoLP2.estoqueDataSetTableAdapters.fornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFornecedoresCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridFornecedoresCadastrados
            // 
            this.dtGridFornecedoresCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridFornecedoresCadastrados.AutoGenerateColumns = false;
            this.dtGridFornecedoresCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridFornecedoresCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridFornecedoresCadastrados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGridFornecedoresCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFornecedoresCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpjDataGridViewTextBoxColumn,
            this.nomefantasiaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idAlmoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn});
            this.dtGridFornecedoresCadastrados.DataSource = this.fornecedorBindingSource;
            this.dtGridFornecedoresCadastrados.Location = new System.Drawing.Point(13, 13);
            this.dtGridFornecedoresCadastrados.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridFornecedoresCadastrados.MultiSelect = false;
            this.dtGridFornecedoresCadastrados.Name = "dtGridFornecedoresCadastrados";
            this.dtGridFornecedoresCadastrados.Size = new System.Drawing.Size(1190, 524);
            this.dtGridFornecedoresCadastrados.TabIndex = 0;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            // 
            // nomefantasiaDataGridViewTextBoxColumn
            // 
            this.nomefantasiaDataGridViewTextBoxColumn.DataPropertyName = "nome_fantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.HeaderText = "nome_fantasia";
            this.nomefantasiaDataGridViewTextBoxColumn.Name = "nomefantasiaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // idAlmoDataGridViewTextBoxColumn
            // 
            this.idAlmoDataGridViewTextBoxColumn.DataPropertyName = "idAlmo";
            this.idAlmoDataGridViewTextBoxColumn.HeaderText = "idAlmo";
            this.idAlmoDataGridViewTextBoxColumn.Name = "idAlmoDataGridViewTextBoxColumn";
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.estoqueDataSet;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(903, 558);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(301, 32);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 563);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(865, 27);
            this.textBox1.TabIndex = 12;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTabelaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1216, 616);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtGridFornecedoresCadastrados);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewTabelaFornecedores";
            this.Text = "Fornecedores cadastrados";
            this.Load += new System.EventHandler(this.ViewTabelaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFornecedoresCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridFornecedoresCadastrados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private estoqueDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefantasiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlmoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
    }
}