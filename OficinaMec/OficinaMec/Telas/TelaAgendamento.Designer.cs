namespace OficinaMec
{
    partial class TelaAgendamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAgendamento));
            this.BASair = new System.Windows.Forms.Button();
            this.BAAgendar = new System.Windows.Forms.Button();
            this.TADescritivo = new System.Windows.Forms.TextBox();
            this.Descritivo = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TAModelo = new System.Windows.Forms.TextBox();
            this.TAANO = new System.Windows.Forms.TextBox();
            this.TANome = new System.Windows.Forms.TextBox();
            this.TAPlaca = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.AnoFabricacao = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.Label();
            this.Informacoes = new System.Windows.Forms.Label();
            this.BALimpar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.AgendamentoTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TAData = new System.Windows.Forms.MaskedTextBox();
            this.textbox2 = new System.Windows.Forms.MaskedTextBox();
            this.TAHorario = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TACPF = new System.Windows.Forms.MaskedTextBox();
            this.TATelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BASair
            // 
            this.BASair.BackColor = System.Drawing.Color.Moccasin;
            this.BASair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BASair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASair.Location = new System.Drawing.Point(24, 383);
            this.BASair.Name = "BASair";
            this.BASair.Size = new System.Drawing.Size(119, 57);
            this.BASair.TabIndex = 35;
            this.BASair.Text = "SAIR";
            this.BASair.UseVisualStyleBackColor = false;
            this.BASair.Click += new System.EventHandler(this.BACancelar_Click);
            // 
            // BAAgendar
            // 
            this.BAAgendar.BackColor = System.Drawing.Color.Moccasin;
            this.BAAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAAgendar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAAgendar.Location = new System.Drawing.Point(165, 383);
            this.BAAgendar.Name = "BAAgendar";
            this.BAAgendar.Size = new System.Drawing.Size(119, 57);
            this.BAAgendar.TabIndex = 34;
            this.BAAgendar.Text = "AGENDAR";
            this.BAAgendar.UseVisualStyleBackColor = false;
            this.BAAgendar.Click += new System.EventHandler(this.BAAgendar_Click);
            // 
            // TADescritivo
            // 
            this.TADescritivo.BackColor = System.Drawing.Color.Moccasin;
            this.TADescritivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TADescritivo.Location = new System.Drawing.Point(586, 328);
            this.TADescritivo.Multiline = true;
            this.TADescritivo.Name = "TADescritivo";
            this.TADescritivo.Size = new System.Drawing.Size(227, 112);
            this.TADescritivo.TabIndex = 33;
            // 
            // Descritivo
            // 
            this.Descritivo.AutoSize = true;
            this.Descritivo.BackColor = System.Drawing.Color.Transparent;
            this.Descritivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descritivo.ForeColor = System.Drawing.Color.Moccasin;
            this.Descritivo.Location = new System.Drawing.Point(580, 302);
            this.Descritivo.Name = "Descritivo";
            this.Descritivo.Size = new System.Drawing.Size(239, 24);
            this.Descritivo.TabIndex = 31;
            this.Descritivo.Text = "DESCRITIVO DO PROBLEMA:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Moccasin;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TAModelo
            // 
            this.TAModelo.BackColor = System.Drawing.Color.Moccasin;
            this.TAModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAModelo.Location = new System.Drawing.Point(665, 220);
            this.TAModelo.Name = "TAModelo";
            this.TAModelo.Size = new System.Drawing.Size(131, 20);
            this.TAModelo.TabIndex = 29;
            // 
            // TAANO
            // 
            this.TAANO.BackColor = System.Drawing.Color.Moccasin;
            this.TAANO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAANO.Location = new System.Drawing.Point(665, 194);
            this.TAANO.Name = "TAANO";
            this.TAANO.Size = new System.Drawing.Size(131, 20);
            this.TAANO.TabIndex = 28;
            // 
            // TANome
            // 
            this.TANome.BackColor = System.Drawing.Color.Moccasin;
            this.TANome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TANome.Location = new System.Drawing.Point(648, 142);
            this.TANome.Name = "TANome";
            this.TANome.Size = new System.Drawing.Size(148, 20);
            this.TANome.TabIndex = 26;
            // 
            // TAPlaca
            // 
            this.TAPlaca.BackColor = System.Drawing.Color.Moccasin;
            this.TAPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAPlaca.Location = new System.Drawing.Point(648, 116);
            this.TAPlaca.Name = "TAPlaca";
            this.TAPlaca.Size = new System.Drawing.Size(148, 20);
            this.TAPlaca.TabIndex = 25;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Telefone.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Moccasin;
            this.Telefone.Location = new System.Drawing.Point(582, 244);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(84, 21);
            this.Telefone.TabIndex = 24;
            this.Telefone.Text = "TELEFONE:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.Color.Moccasin;
            this.CPF.Location = new System.Drawing.Point(582, 168);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(41, 21);
            this.CPF.TabIndex = 23;
            this.CPF.Text = "CPF:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Moccasin;
            this.Nome.Location = new System.Drawing.Point(582, 140);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(60, 21);
            this.Nome.TabIndex = 22;
            this.Nome.Text = "NOME:";
            // 
            // AnoFabricacao
            // 
            this.AnoFabricacao.AutoSize = true;
            this.AnoFabricacao.BackColor = System.Drawing.Color.Transparent;
            this.AnoFabricacao.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoFabricacao.ForeColor = System.Drawing.Color.Moccasin;
            this.AnoFabricacao.Location = new System.Drawing.Point(582, 192);
            this.AnoFabricacao.Name = "AnoFabricacao";
            this.AnoFabricacao.Size = new System.Drawing.Size(81, 21);
            this.AnoFabricacao.TabIndex = 21;
            this.AnoFabricacao.Text = "ANO FAB.:";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.BackColor = System.Drawing.Color.Transparent;
            this.Modelo.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.ForeColor = System.Drawing.Color.Moccasin;
            this.Modelo.Location = new System.Drawing.Point(582, 218);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(77, 21);
            this.Modelo.TabIndex = 20;
            this.Modelo.Text = "MODELO:";
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.BackColor = System.Drawing.Color.Transparent;
            this.placa.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.ForeColor = System.Drawing.Color.Moccasin;
            this.placa.Location = new System.Drawing.Point(582, 115);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(60, 21);
            this.placa.TabIndex = 19;
            this.placa.Text = "PLACA:";
            // 
            // Informacoes
            // 
            this.Informacoes.AutoSize = true;
            this.Informacoes.BackColor = System.Drawing.Color.Transparent;
            this.Informacoes.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacoes.ForeColor = System.Drawing.Color.Moccasin;
            this.Informacoes.Location = new System.Drawing.Point(582, 22);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(214, 24);
            this.Informacoes.TabIndex = 18;
            this.Informacoes.Text = "INFORMAÇÕES CLIENTES";
            // 
            // BALimpar
            // 
            this.BALimpar.BackColor = System.Drawing.Color.Moccasin;
            this.BALimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BALimpar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BALimpar.Location = new System.Drawing.Point(309, 383);
            this.BALimpar.Name = "BALimpar";
            this.BALimpar.Size = new System.Drawing.Size(119, 57);
            this.BALimpar.TabIndex = 36;
            this.BALimpar.Text = "LIMPAR";
            this.BALimpar.UseVisualStyleBackColor = false;
            this.BALimpar.Click += new System.EventHandler(this.BALimpar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(683, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(582, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "NUMERO OS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(582, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "HORÁRIO:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 8F);
            this.button3.Location = new System.Drawing.Point(592, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 25);
            this.button3.TabIndex = 119;
            this.button3.Text = "Consultar OS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(8, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 120;
            this.label3.Text = "DATA AGENDAMENTO:";
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "Agendamento";
            this.agendamentoBindingSource.DataSource = this.oficinaMecDataSet;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.OrcamentosTableAdapter = null;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(8, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 123;
            this.label4.Text = "DATA CONSULTA:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 8F);
            this.button1.Location = new System.Drawing.Point(12, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 125;
            this.button1.Text = "Consultar Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Moccasin;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(251, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 290);
            this.listBox1.TabIndex = 127;
            // 
            // TAData
            // 
            this.TAData.BackColor = System.Drawing.Color.Moccasin;
            this.TAData.Location = new System.Drawing.Point(12, 245);
            this.TAData.Name = "TAData";
            this.TAData.Size = new System.Drawing.Size(164, 20);
            this.TAData.TabIndex = 128;
            this.TAData.ValidatingType = typeof(System.DateTime);
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.Color.Moccasin;
            this.textbox2.Location = new System.Drawing.Point(12, 309);
            this.textbox2.Mask = "00/00/0000";
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(164, 20);
            this.textbox2.TabIndex = 129;
            this.textbox2.ValidatingType = typeof(System.DateTime);
            // 
            // TAHorario
            // 
            this.TAHorario.BackColor = System.Drawing.Color.Moccasin;
            this.TAHorario.Location = new System.Drawing.Point(665, 271);
            this.TAHorario.Name = "TAHorario";
            this.TAHorario.Size = new System.Drawing.Size(131, 20);
            this.TAHorario.TabIndex = 130;
            this.TAHorario.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Moccasin;
            this.label6.Location = new System.Drawing.Point(297, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 24);
            this.label6.TabIndex = 132;
            this.label6.Text = "CONSULTA DE AGENDAMENTO";
            // 
            // TACPF
            // 
            this.TACPF.BackColor = System.Drawing.Color.Moccasin;
            this.TACPF.Location = new System.Drawing.Point(648, 168);
            this.TACPF.Mask = "000,000,000-00";
            this.TACPF.Name = "TACPF";
            this.TACPF.Size = new System.Drawing.Size(148, 20);
            this.TACPF.TabIndex = 133;
            // 
            // TATelefone
            // 
            this.TATelefone.BackColor = System.Drawing.Color.Moccasin;
            this.TATelefone.Location = new System.Drawing.Point(665, 246);
            this.TATelefone.Mask = "(99) 00000-0000";
            this.TATelefone.Name = "TATelefone";
            this.TATelefone.Size = new System.Drawing.Size(131, 20);
            this.TATelefone.TabIndex = 134;
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 460);
            this.Controls.Add(this.TATelefone);
            this.Controls.Add(this.TACPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TAHorario);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.TAData);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BALimpar);
            this.Controls.Add(this.BASair);
            this.Controls.Add(this.BAAgendar);
            this.Controls.Add(this.TADescritivo);
            this.Controls.Add(this.Descritivo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TAModelo);
            this.Controls.Add(this.TAANO);
            this.Controls.Add(this.TANome);
            this.Controls.Add(this.TAPlaca);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AnoFabricacao);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.Informacoes);
            this.Name = "TelaAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela Agendamento";
            this.Load += new System.EventHandler(this.TelaAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BASair;
        private System.Windows.Forms.Button BAAgendar;
        private System.Windows.Forms.TextBox TADescritivo;
        private System.Windows.Forms.Label Descritivo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TAModelo;
        private System.Windows.Forms.TextBox TAANO;
        private System.Windows.Forms.TextBox TANome;
        private System.Windows.Forms.TextBox TAPlaca;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label AnoFabricacao;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label Informacoes;
        private System.Windows.Forms.Button BALimpar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private OficinaMecDataSetTableAdapters.AgendamentoTableAdapter agendamentoTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox TAData;
        private System.Windows.Forms.MaskedTextBox textbox2;
        private System.Windows.Forms.MaskedTextBox TAHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TACPF;
        private System.Windows.Forms.MaskedTextBox TATelefone;
    }
}

