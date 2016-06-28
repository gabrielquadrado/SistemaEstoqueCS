namespace ProjetoLP2
{
    partial class ViewTabelaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTabelaUsuarios));
            this.dtGridUsuariosCadastrados = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btbBuscar = new System.Windows.Forms.Button();
            this.txtBoxUsuariosCadastrados = new System.Windows.Forms.TextBox();
            this.estoqueDataSet = new ProjetoLP2.estoqueDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new ProjetoLP2.estoqueDataSetTableAdapters.funcionarioTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGerenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuariosCadastrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridUsuariosCadastrados
            // 
            this.dtGridUsuariosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridUsuariosCadastrados.AutoGenerateColumns = false;
            this.dtGridUsuariosCadastrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridUsuariosCadastrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridUsuariosCadastrados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtGridUsuariosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuariosCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.permissaoDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.idGerenteDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dtGridUsuariosCadastrados.DataSource = this.funcionarioBindingSource;
            this.dtGridUsuariosCadastrados.Location = new System.Drawing.Point(13, 13);
            this.dtGridUsuariosCadastrados.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridUsuariosCadastrados.MultiSelect = false;
            this.dtGridUsuariosCadastrados.Name = "dtGridUsuariosCadastrados";
            this.dtGridUsuariosCadastrados.Size = new System.Drawing.Size(1132, 377);
            this.dtGridUsuariosCadastrados.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(988, 397);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(157, 44);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btbBuscar
            // 
            this.btbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbBuscar.Location = new System.Drawing.Point(825, 397);
            this.btbBuscar.Name = "btbBuscar";
            this.btbBuscar.Size = new System.Drawing.Size(157, 44);
            this.btbBuscar.TabIndex = 6;
            this.btbBuscar.Text = "Buscar";
            this.btbBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBoxUsuariosCadastrados
            // 
            this.txtBoxUsuariosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsuariosCadastrados.Location = new System.Drawing.Point(13, 404);
            this.txtBoxUsuariosCadastrados.Name = "txtBoxUsuariosCadastrados";
            this.txtBoxUsuariosCadastrados.Size = new System.Drawing.Size(806, 27);
            this.txtBoxUsuariosCadastrados.TabIndex = 5;
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.estoqueDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // permissaoDataGridViewTextBoxColumn
            // 
            this.permissaoDataGridViewTextBoxColumn.DataPropertyName = "permissao";
            this.permissaoDataGridViewTextBoxColumn.HeaderText = "permissao";
            this.permissaoDataGridViewTextBoxColumn.Name = "permissaoDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "dataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "dataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // idGerenteDataGridViewTextBoxColumn
            // 
            this.idGerenteDataGridViewTextBoxColumn.DataPropertyName = "idGerente";
            this.idGerenteDataGridViewTextBoxColumn.HeaderText = "idGerente";
            this.idGerenteDataGridViewTextBoxColumn.Name = "idGerenteDataGridViewTextBoxColumn";
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            // 
            // ViewTabelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1157, 448);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btbBuscar);
            this.Controls.Add(this.txtBoxUsuariosCadastrados);
            this.Controls.Add(this.dtGridUsuariosCadastrados);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ViewTabelaUsuarios";
            this.Text = "Usuários do sistema";
            this.Load += new System.EventHandler(this.ViewTabelaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuariosCadastrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridUsuariosCadastrados;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btbBuscar;
        private System.Windows.Forms.TextBox txtBoxUsuariosCadastrados;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private estoqueDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGerenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
    }
}