namespace OficinaMec.Telas
{
    partial class OsGeral
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
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.orcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamentoTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.OrcamentoTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.BOSair = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.MaskedTextBox();
            this.TAData = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentoBindingSource
            // 
            this.orcamentoBindingSource.DataMember = "Orcamento";
            this.orcamentoBindingSource.DataSource = this.oficinaMecDataSet;
            // 
            // orcamentoTableAdapter
            // 
            this.orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.OrcamentoTableAdapter = this.orcamentoTableAdapter;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BOSair
            // 
            this.BOSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSair.BackColor = System.Drawing.Color.Moccasin;
            this.BOSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOSair.Location = new System.Drawing.Point(666, 368);
            this.BOSair.Name = "BOSair";
            this.BOSair.Size = new System.Drawing.Size(122, 57);
            this.BOSair.TabIndex = 101;
            this.BOSair.Text = "VOLTAR";
            this.BOSair.UseVisualStyleBackColor = false;
            this.BOSair.Click += new System.EventHandler(this.BOSair_Click);
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.Color.Moccasin;
            this.textbox2.Location = new System.Drawing.Point(624, 243);
            this.textbox2.Mask = "00/00/0000";
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(164, 20);
            this.textbox2.TabIndex = 134;
            this.textbox2.ValidatingType = typeof(System.DateTime);
            // 
            // TAData
            // 
            this.TAData.BackColor = System.Drawing.Color.Moccasin;
            this.TAData.Location = new System.Drawing.Point(624, 179);
            this.TAData.Mask = "00/00/0000";
            this.TAData.Name = "TAData";
            this.TAData.Size = new System.Drawing.Size(164, 20);
            this.TAData.TabIndex = 133;
            this.TAData.ValidatingType = typeof(System.DateTime);
            this.TAData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TAData_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 8F);
            this.button1.Location = new System.Drawing.Point(624, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 132;
            this.button1.Text = "Consultar Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(620, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 131;
            this.label4.Text = "DATA FINAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(620, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 130;
            this.label3.Text = "DATA INICIAL:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Moccasin;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(106, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 368);
            this.listBox1.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(141, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 21);
            this.label1.TabIndex = 136;
            this.label1.Text = "QUANTIDADE DE ORDENS DE SERVIÇO NESTE PERÍODO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(536, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 137;
            this.label2.Text = "00";
            // 
            // OsGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OficinaMec.Properties.Resources.Editado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.TAData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BOSair);
            this.Name = "OsGeral";
            this.Text = "OsGeral";
            this.Load += new System.EventHandler(this.OsGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource orcamentoBindingSource;
        private OficinaMecDataSetTableAdapters.OrcamentoTableAdapter orcamentoTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BOSair;
        private System.Windows.Forms.MaskedTextBox textbox2;
        private System.Windows.Forms.MaskedTextBox TAData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}