namespace OficinaMec
{
    partial class TelaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            this.BEExcluir = new System.Windows.Forms.Button();
            this.BEAcrescentar = new System.Windows.Forms.Button();
            this.BESair = new System.Windows.Forms.Button();
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.pecas_estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pecas_estoqueTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.Pecas_estoqueTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.pecas_estoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas_estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas_estoqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BEExcluir
            // 
            this.BEExcluir.BackColor = System.Drawing.Color.Moccasin;
            this.BEExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEExcluir.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEExcluir.Location = new System.Drawing.Point(411, 369);
            this.BEExcluir.Name = "BEExcluir";
            this.BEExcluir.Size = new System.Drawing.Size(122, 57);
            this.BEExcluir.TabIndex = 42;
            this.BEExcluir.Text = "EXCLUIR ITENS";
            this.BEExcluir.UseVisualStyleBackColor = false;
            this.BEExcluir.Click += new System.EventHandler(this.BEExcluir_Click);
            // 
            // BEAcrescentar
            // 
            this.BEAcrescentar.BackColor = System.Drawing.Color.Moccasin;
            this.BEAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEAcrescentar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEAcrescentar.Location = new System.Drawing.Point(283, 369);
            this.BEAcrescentar.Name = "BEAcrescentar";
            this.BEAcrescentar.Size = new System.Drawing.Size(122, 57);
            this.BEAcrescentar.TabIndex = 41;
            this.BEAcrescentar.Text = "ACRESCENTAR ITENS";
            this.BEAcrescentar.UseVisualStyleBackColor = false;
            this.BEAcrescentar.Click += new System.EventHandler(this.BEAcrescentar_Click);
            // 
            // BESair
            // 
            this.BESair.BackColor = System.Drawing.Color.Moccasin;
            this.BESair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BESair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BESair.Location = new System.Drawing.Point(155, 368);
            this.BESair.Name = "BESair";
            this.BESair.Size = new System.Drawing.Size(122, 57);
            this.BESair.TabIndex = 46;
            this.BESair.Text = "SAIR";
            this.BESair.UseVisualStyleBackColor = false;
            this.BESair.Click += new System.EventHandler(this.BESair_Click);
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pecas_estoqueBindingSource
            // 
            this.pecas_estoqueBindingSource.DataMember = "Pecas_estoque";
            this.pecas_estoqueBindingSource.DataSource = this.oficinaMecDataSet;
            // 
            // pecas_estoqueTableAdapter
            // 
            this.pecas_estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.OrcamentosTableAdapter = null;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = this.pecas_estoqueTableAdapter;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pecas_estoqueDataGridView
            // 
            this.pecas_estoqueDataGridView.AllowUserToOrderColumns = true;
            this.pecas_estoqueDataGridView.AutoGenerateColumns = false;
            this.pecas_estoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pecas_estoqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pecas_estoqueDataGridView.DataSource = this.pecas_estoqueBindingSource;
            this.pecas_estoqueDataGridView.Location = new System.Drawing.Point(82, 64);
            this.pecas_estoqueDataGridView.Name = "pecas_estoqueDataGridView";
            this.pecas_estoqueDataGridView.Size = new System.Drawing.Size(643, 281);
            this.pecas_estoqueDataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COD_PECA";
            this.dataGridViewTextBoxColumn6.HeaderText = "COD_PECA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QTTD_PECA";
            this.dataGridViewTextBoxColumn1.HeaderText = "QTTD_PECA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCR_PECA";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCR_PECA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FABRIC_PECA";
            this.dataGridViewTextBoxColumn3.HeaderText = "FABRIC_PECA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECO_PECA";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRECO_PECA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MODELO_PECA";
            this.dataGridViewTextBoxColumn5.HeaderText = "MODELO_PECA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 47;
            this.button1.Text = "EFETUAR BAIXA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pecas_estoqueDataGridView);
            this.Controls.Add(this.BESair);
            this.Controls.Add(this.BEExcluir);
            this.Controls.Add(this.BEAcrescentar);
            this.Name = "TelaEstoque";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaEstoque";
            this.Load += new System.EventHandler(this.TelaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas_estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecas_estoqueDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BEExcluir;
        private System.Windows.Forms.Button BEAcrescentar;
        private System.Windows.Forms.Button BESair;
        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource pecas_estoqueBindingSource;
        private OficinaMecDataSetTableAdapters.Pecas_estoqueTableAdapter pecas_estoqueTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pecas_estoqueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}