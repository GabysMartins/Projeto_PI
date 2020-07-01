namespace OficinaMec
{
    partial class TelaCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadUsuario));
            this.TCUNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TCUConfirmacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TCUSenha = new System.Windows.Forms.TextBox();
            this.TCUEmail = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.BCUSalvar = new System.Windows.Forms.Button();
            this.BCUSair = new System.Windows.Forms.Button();
            this.BCURemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.funcionarioTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.TCUCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TCUNome
            // 
            this.TCUNome.BackColor = System.Drawing.Color.Moccasin;
            this.TCUNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCUNome.Location = new System.Drawing.Point(206, 184);
            this.TCUNome.Name = "TCUNome";
            this.TCUNome.Size = new System.Drawing.Size(148, 20);
            this.TCUNome.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(140, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "NOME:";
            // 
            // TCUConfirmacao
            // 
            this.TCUConfirmacao.BackColor = System.Drawing.Color.Moccasin;
            this.TCUConfirmacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCUConfirmacao.Location = new System.Drawing.Point(490, 184);
            this.TCUConfirmacao.Name = "TCUConfirmacao";
            this.TCUConfirmacao.PasswordChar = '*';
            this.TCUConfirmacao.Size = new System.Drawing.Size(148, 20);
            this.TCUConfirmacao.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(376, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "CONF. SENHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(103, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "PERMISSÃO:";
            // 
            // TCUSenha
            // 
            this.TCUSenha.BackColor = System.Drawing.Color.Moccasin;
            this.TCUSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCUSenha.Location = new System.Drawing.Point(490, 151);
            this.TCUSenha.Name = "TCUSenha";
            this.TCUSenha.PasswordChar = '*';
            this.TCUSenha.Size = new System.Drawing.Size(148, 20);
            this.TCUSenha.TabIndex = 72;
            // 
            // TCUEmail
            // 
            this.TCUEmail.BackColor = System.Drawing.Color.Moccasin;
            this.TCUEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCUEmail.Location = new System.Drawing.Point(206, 255);
            this.TCUEmail.Name = "TCUEmail";
            this.TCUEmail.Size = new System.Drawing.Size(148, 20);
            this.TCUEmail.TabIndex = 70;
            this.TCUEmail.TextChanged += new System.EventHandler(this.TCUEmail_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Telefone.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Moccasin;
            this.Telefone.Location = new System.Drawing.Point(421, 150);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(63, 21);
            this.Telefone.TabIndex = 69;
            this.Telefone.Text = "SENHA:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.Color.Moccasin;
            this.CPF.Location = new System.Drawing.Point(159, 220);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(41, 21);
            this.CPF.TabIndex = 68;
            this.CPF.Text = "CPF:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Moccasin;
            this.Nome.Location = new System.Drawing.Point(136, 252);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(64, 21);
            this.Nome.TabIndex = 67;
            this.Nome.Text = "E-MAIL:";
            // 
            // BCUSalvar
            // 
            this.BCUSalvar.BackColor = System.Drawing.Color.Moccasin;
            this.BCUSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCUSalvar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCUSalvar.Location = new System.Drawing.Point(280, 326);
            this.BCUSalvar.Name = "BCUSalvar";
            this.BCUSalvar.Size = new System.Drawing.Size(136, 57);
            this.BCUSalvar.TabIndex = 66;
            this.BCUSalvar.Text = "SALVAR";
            this.BCUSalvar.UseVisualStyleBackColor = false;
            this.BCUSalvar.Click += new System.EventHandler(this.BCUSalvar_Click);
            // 
            // BCUSair
            // 
            this.BCUSair.BackColor = System.Drawing.Color.Moccasin;
            this.BCUSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCUSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCUSair.Location = new System.Drawing.Point(433, 326);
            this.BCUSair.Name = "BCUSair";
            this.BCUSair.Size = new System.Drawing.Size(136, 57);
            this.BCUSair.TabIndex = 65;
            this.BCUSair.Text = "SAIR";
            this.BCUSair.UseVisualStyleBackColor = false;
            this.BCUSair.Click += new System.EventHandler(this.BCUSair_Click);
            // 
            // BCURemover
            // 
            this.BCURemover.BackColor = System.Drawing.Color.Moccasin;
            this.BCURemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCURemover.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCURemover.Location = new System.Drawing.Point(126, 326);
            this.BCURemover.Name = "BCURemover";
            this.BCURemover.Size = new System.Drawing.Size(136, 57);
            this.BCURemover.TabIndex = 64;
            this.BCURemover.Text = "REMOVER";
            this.BCURemover.UseVisualStyleBackColor = false;
            this.BCURemover.Click += new System.EventHandler(this.BCURemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "CÓDIGO DO USUÁRIO:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "COD_FUNC", true));
            this.textBox1.Location = new System.Drawing.Point(206, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 80;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.oficinaMecDataSet;
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.OrcamentosTableAdapter = null;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.funcionarioBindingSource, "PERMIS_FUNC", true));
            this.radioButton1.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton1.Location = new System.Drawing.Point(206, 292);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 82;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Administrador";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.funcionarioBindingSource, "PERMIS_FUNC", true));
            this.radioButton2.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton2.Location = new System.Drawing.Point(300, 292);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 83;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Secretaria";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.funcionarioBindingSource, "PERMIS_FUNC", true));
            this.radioButton3.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton3.Location = new System.Drawing.Point(379, 292);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 84;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mecanico";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.funcionarioBindingSource, "PERMIS_FUNC", true));
            this.radioButton4.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton4.Location = new System.Drawing.Point(457, 292);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 17);
            this.radioButton4.TabIndex = 85;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Estoquista";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // TCUCPF
            // 
            this.TCUCPF.BackColor = System.Drawing.Color.Moccasin;
            this.TCUCPF.Location = new System.Drawing.Point(206, 220);
            this.TCUCPF.Mask = "000,000,000-00";
            this.TCUCPF.Name = "TCUCPF";
            this.TCUCPF.Size = new System.Drawing.Size(148, 20);
            this.TCUCPF.TabIndex = 86;
            // 
            // TelaCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TCUCPF);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TCUNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCUConfirmacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCUSenha);
            this.Controls.Add(this.TCUEmail);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.BCUSalvar);
            this.Controls.Add(this.BCUSair);
            this.Controls.Add(this.BCURemover);
            this.Name = "TelaCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaCadUsuario";
            this.Load += new System.EventHandler(this.TelaCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCUNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TCUConfirmacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCUSenha;
        private System.Windows.Forms.TextBox TCUEmail;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button BCUSalvar;
        private System.Windows.Forms.Button BCUSair;
        private System.Windows.Forms.Button BCURemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private OficinaMecDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.MaskedTextBox TCUCPF;
    }
}