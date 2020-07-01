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
            this.orcamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamentosTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.OrcamentosTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.BOSair = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.MaskedTextBox();
            this.TAData = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orcamentosBindingSource
            // 
            this.orcamentosBindingSource.DataMember = "Orcamentos";
            this.orcamentosBindingSource.DataSource = this.oficinaMecDataSet;
            // 
            // orcamentosTableAdapter
            // 
            this.orcamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.OrcamentosTableAdapter = this.orcamentosTableAdapter;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BOSair
            // 
            this.BOSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSair.BackColor = System.Drawing.Color.Moccasin;
            this.BOSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOSair.Location = new System.Drawing.Point(666, 384);
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
            this.textbox2.Location = new System.Drawing.Point(624, 127);
            this.textbox2.Mask = "00/00/0000";
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(164, 20);
            this.textbox2.TabIndex = 134;
            this.textbox2.ValidatingType = typeof(System.DateTime);
            // 
            // TAData
            // 
            this.TAData.BackColor = System.Drawing.Color.Moccasin;
            this.TAData.Location = new System.Drawing.Point(624, 192);
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
            this.button1.Location = new System.Drawing.Point(624, 221);
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
            this.label4.Location = new System.Drawing.Point(620, 168);
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
            this.label3.Location = new System.Drawing.Point(620, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 130;
            this.label3.Text = "DATA INICIAL:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Moccasin;
            this.maskedTextBox1.Location = new System.Drawing.Point(624, 309);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(164, 20);
            this.maskedTextBox1.TabIndex = 140;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 8F);
            this.button2.Location = new System.Drawing.Point(624, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 139;
            this.button2.Text = "Consultar OS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Moccasin;
            this.label5.Location = new System.Drawing.Point(620, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 138;
            this.label5.Text = "CPF:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Moccasin;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(602, 384);
            this.listBox1.TabIndex = 141;
            // 
            // OsGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OficinaMec.Properties.Resources.Editado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.TAData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BOSair);
            this.Name = "OsGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OsGeral";
            this.Load += new System.EventHandler(this.OsGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource orcamentosBindingSource;
        private OficinaMecDataSetTableAdapters.OrcamentosTableAdapter orcamentosTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BOSair;
        private System.Windows.Forms.MaskedTextBox textbox2;
        private System.Windows.Forms.MaskedTextBox TAData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}