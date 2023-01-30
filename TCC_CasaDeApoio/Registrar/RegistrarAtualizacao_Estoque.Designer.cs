namespace TCC_CasaDeApoio.Registrar
{
    partial class RegistrarAtualizacao_Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAtualizacao_Estoque));
            this.txtID_Atualizar_Estoque = new System.Windows.Forms.TextBox();
            this.cbxAlimento = new System.Windows.Forms.ComboBox();
            this.txtQTD_Alimento = new System.Windows.Forms.TextBox();
            this.cbxRemedio = new System.Windows.Forms.ComboBox();
            this.txtQTD_Remedio = new System.Windows.Forms.TextBox();
            this.lblRegistrar_Atualizacao_Estoque = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblQTD_Alimento = new System.Windows.Forms.Label();
            this.lblQTD_Remedio = new System.Windows.Forms.Label();
            this.lblRemedio = new System.Windows.Forms.Label();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.dtgrdvwAlimentos = new System.Windows.Forms.DataGridView();
            this.dtgrdvwRemedios = new System.Windows.Forms.DataGridView();
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentosTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAtualizarEstoqueAlimentosTableAdapters.AlimentosTableAdapter();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAtualizarEstoqueRemedios();
            this.remediosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remediosTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAtualizarEstoqueRemediosTableAdapters.RemediosTableAdapter();
            this.estoqueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwRemedios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remediosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID_Atualizar_Estoque
            // 
            this.txtID_Atualizar_Estoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Atualizar_Estoque.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID_Atualizar_Estoque.Enabled = false;
            this.txtID_Atualizar_Estoque.Location = new System.Drawing.Point(260, 103);
            this.txtID_Atualizar_Estoque.Name = "txtID_Atualizar_Estoque";
            this.txtID_Atualizar_Estoque.Size = new System.Drawing.Size(186, 20);
            this.txtID_Atualizar_Estoque.TabIndex = 0;
            this.txtID_Atualizar_Estoque.Visible = false;
            // 
            // cbxAlimento
            // 
            this.cbxAlimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlimento.DisplayMember = "Nome";
            this.cbxAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlimento.FormattingEnabled = true;
            this.cbxAlimento.Location = new System.Drawing.Point(260, 144);
            this.cbxAlimento.Name = "cbxAlimento";
            this.cbxAlimento.Size = new System.Drawing.Size(186, 21);
            this.cbxAlimento.TabIndex = 1;
            this.cbxAlimento.ValueMember = "ID_Alimento";
            this.cbxAlimento.SelectedIndexChanged += new System.EventHandler(this.cbxAlimento_SelectedIndexChanged);
            this.cbxAlimento.Click += new System.EventHandler(this.CbxAlimento_Click);
            this.cbxAlimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbxAlimento_KeyDown);
            // 
            // txtQTD_Alimento
            // 
            this.txtQTD_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQTD_Alimento.Location = new System.Drawing.Point(260, 193);
            this.txtQTD_Alimento.Name = "txtQTD_Alimento";
            this.txtQTD_Alimento.Size = new System.Drawing.Size(186, 20);
            this.txtQTD_Alimento.TabIndex = 2;
            this.txtQTD_Alimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQTD_Alimento_KeyDown);
            this.txtQTD_Alimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQTD_Alimento_KeyPress);
            // 
            // cbxRemedio
            // 
            this.cbxRemedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRemedio.DisplayMember = "Nome";
            this.cbxRemedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemedio.FormattingEnabled = true;
            this.cbxRemedio.Location = new System.Drawing.Point(260, 282);
            this.cbxRemedio.Name = "cbxRemedio";
            this.cbxRemedio.Size = new System.Drawing.Size(186, 21);
            this.cbxRemedio.TabIndex = 3;
            this.cbxRemedio.ValueMember = "ID_Remedio";
            this.cbxRemedio.SelectedIndexChanged += new System.EventHandler(this.cbxRemedio_SelectedIndexChanged);
            this.cbxRemedio.Click += new System.EventHandler(this.CbxRemedio_Click);
            this.cbxRemedio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbxRemedio_KeyDown);
            // 
            // txtQTD_Remedio
            // 
            this.txtQTD_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQTD_Remedio.Location = new System.Drawing.Point(260, 328);
            this.txtQTD_Remedio.Name = "txtQTD_Remedio";
            this.txtQTD_Remedio.Size = new System.Drawing.Size(186, 20);
            this.txtQTD_Remedio.TabIndex = 4;
            this.txtQTD_Remedio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQTD_Remedio_KeyDown);
            this.txtQTD_Remedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQTD_Remedio_KeyPress);
            // 
            // lblRegistrar_Atualizacao_Estoque
            // 
            this.lblRegistrar_Atualizacao_Estoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar_Atualizacao_Estoque.AutoSize = true;
            this.lblRegistrar_Atualizacao_Estoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistrar_Atualizacao_Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Atualizacao_Estoque.Location = new System.Drawing.Point(254, 9);
            this.lblRegistrar_Atualizacao_Estoque.Name = "lblRegistrar_Atualizacao_Estoque";
            this.lblRegistrar_Atualizacao_Estoque.Size = new System.Drawing.Size(260, 33);
            this.lblRegistrar_Atualizacao_Estoque.TabIndex = 62;
            this.lblRegistrar_Atualizacao_Estoque.Text = "Atualizar Estoque";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(426, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 52);
            this.btnLimpar.TabIndex = 71;
            this.btnLimpar.Text = "Limpar Item Selecionado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(226, 409);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 52);
            this.btnRegistrar.TabIndex = 70;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(85, 103);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 72;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // lblQTD_Alimento
            // 
            this.lblQTD_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQTD_Alimento.AutoSize = true;
            this.lblQTD_Alimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblQTD_Alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTD_Alimento.Location = new System.Drawing.Point(13, 193);
            this.lblQTD_Alimento.Name = "lblQTD_Alimento";
            this.lblQTD_Alimento.Size = new System.Drawing.Size(207, 20);
            this.lblQTD_Alimento.TabIndex = 73;
            this.lblQTD_Alimento.Text = "Quantidade do Alimento:";
            // 
            // lblQTD_Remedio
            // 
            this.lblQTD_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQTD_Remedio.AutoSize = true;
            this.lblQTD_Remedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblQTD_Remedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTD_Remedio.Location = new System.Drawing.Point(12, 326);
            this.lblQTD_Remedio.Name = "lblQTD_Remedio";
            this.lblQTD_Remedio.Size = new System.Drawing.Size(208, 20);
            this.lblQTD_Remedio.TabIndex = 74;
            this.lblQTD_Remedio.Text = "Quantidade do Remédio:";
            // 
            // lblRemedio
            // 
            this.lblRemedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemedio.AutoSize = true;
            this.lblRemedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRemedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemedio.Location = new System.Drawing.Point(70, 283);
            this.lblRemedio.Name = "lblRemedio";
            this.lblRemedio.Size = new System.Drawing.Size(85, 20);
            this.lblRemedio.TabIndex = 75;
            this.lblRemedio.Text = "Remédio:";
            // 
            // lblAlimento
            // 
            this.lblAlimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(71, 145);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(84, 20);
            this.lblAlimento.TabIndex = 76;
            this.lblAlimento.Text = "Alimento:";
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(791, 491);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 77;
            this.pctrbxImagem.TabStop = false;
            // 
            // dtgrdvwAlimentos
            // 
            this.dtgrdvwAlimentos.AllowUserToAddRows = false;
            this.dtgrdvwAlimentos.AllowUserToDeleteRows = false;
            this.dtgrdvwAlimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwAlimentos.AutoGenerateColumns = false;
            this.dtgrdvwAlimentos.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estoqueDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.dtgrdvwAlimentos.DataSource = this.alimentosBindingSource;
            this.dtgrdvwAlimentos.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dtgrdvwAlimentos.Location = new System.Drawing.Point(467, 144);
            this.dtgrdvwAlimentos.Name = "dtgrdvwAlimentos";
            this.dtgrdvwAlimentos.ReadOnly = true;
            this.dtgrdvwAlimentos.RowHeadersVisible = false;
            this.dtgrdvwAlimentos.Size = new System.Drawing.Size(312, 75);
            this.dtgrdvwAlimentos.TabIndex = 133;
            // 
            // dtgrdvwRemedios
            // 
            this.dtgrdvwRemedios.AllowUserToAddRows = false;
            this.dtgrdvwRemedios.AllowUserToDeleteRows = false;
            this.dtgrdvwRemedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwRemedios.AutoGenerateColumns = false;
            this.dtgrdvwRemedios.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwRemedios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdvwRemedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwRemedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estoqueDataGridViewTextBoxColumn1,
            this.pesoDataGridViewTextBoxColumn1});
            this.dtgrdvwRemedios.DataSource = this.remediosBindingSource;
            this.dtgrdvwRemedios.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dtgrdvwRemedios.Location = new System.Drawing.Point(467, 282);
            this.dtgrdvwRemedios.Name = "dtgrdvwRemedios";
            this.dtgrdvwRemedios.ReadOnly = true;
            this.dtgrdvwRemedios.RowHeadersVisible = false;
            this.dtgrdvwRemedios.Size = new System.Drawing.Size(312, 75);
            this.dtgrdvwRemedios.TabIndex = 134;
            // 
            // casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos
            // 
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos.DataSetName = "CasaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos";
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alimentosBindingSource
            // 
            this.alimentosBindingSource.DataMember = "Alimentos";
            this.alimentosBindingSource.DataSource = this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos;
            // 
            // alimentosTableAdapter
            // 
            this.alimentosTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque disponível do Alimento";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estoqueDataGridViewTextBoxColumn.Width = 170;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Tipo de Peso do Alimento";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pesoDataGridViewTextBoxColumn.Width = 139;
            // 
            // casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios
            // 
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios.DataSetName = "CasaDeApoioNossoLarDataSetAtualizarEstoqueRemedios";
            this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remediosBindingSource
            // 
            this.remediosBindingSource.DataMember = "Remedios";
            this.remediosBindingSource.DataSource = this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios;
            // 
            // remediosTableAdapter
            // 
            this.remediosTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueDataGridViewTextBoxColumn1
            // 
            this.estoqueDataGridViewTextBoxColumn1.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn1.HeaderText = "Estoque disponível do Alimento";
            this.estoqueDataGridViewTextBoxColumn1.Name = "estoqueDataGridViewTextBoxColumn1";
            this.estoqueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estoqueDataGridViewTextBoxColumn1.Width = 170;
            // 
            // pesoDataGridViewTextBoxColumn1
            // 
            this.pesoDataGridViewTextBoxColumn1.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn1.HeaderText = "Tipo de Peso do Alimento";
            this.pesoDataGridViewTextBoxColumn1.Name = "pesoDataGridViewTextBoxColumn1";
            this.pesoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pesoDataGridViewTextBoxColumn1.Width = 139;
            // 
            // RegistrarAtualizacao_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(791, 491);
            this.Controls.Add(this.dtgrdvwRemedios);
            this.Controls.Add(this.dtgrdvwAlimentos);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.lblRemedio);
            this.Controls.Add(this.lblQTD_Remedio);
            this.Controls.Add(this.lblQTD_Alimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblRegistrar_Atualizacao_Estoque);
            this.Controls.Add(this.txtQTD_Remedio);
            this.Controls.Add(this.cbxRemedio);
            this.Controls.Add(this.txtQTD_Alimento);
            this.Controls.Add(this.cbxAlimento);
            this.Controls.Add(this.txtID_Atualizar_Estoque);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarAtualizacao_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarAtualizacao_Estoque_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarAtualizacao_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwRemedios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remediosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Atualizar_Estoque;
        private System.Windows.Forms.ComboBox cbxAlimento;
        private System.Windows.Forms.TextBox txtQTD_Alimento;
        private System.Windows.Forms.ComboBox cbxRemedio;
        private System.Windows.Forms.TextBox txtQTD_Remedio;
        private System.Windows.Forms.Label lblRegistrar_Atualizacao_Estoque;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblQTD_Alimento;
        private System.Windows.Forms.Label lblQTD_Remedio;
        private System.Windows.Forms.Label lblRemedio;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.DataGridView dtgrdvwAlimentos;
        private System.Windows.Forms.DataGridView dtgrdvwRemedios;
        private CasaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private CasaDeApoioNossoLarDataSetAtualizarEstoqueAlimentosTableAdapters.AlimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private CasaDeApoioNossoLarDataSetAtualizarEstoqueRemedios casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios;
        private System.Windows.Forms.BindingSource remediosBindingSource;
        private CasaDeApoioNossoLarDataSetAtualizarEstoqueRemediosTableAdapters.RemediosTableAdapter remediosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn1;
    }
}