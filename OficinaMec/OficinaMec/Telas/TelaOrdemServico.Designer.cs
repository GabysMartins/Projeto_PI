namespace OficinaMec
{
    partial class TelaOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaOrdemServico));
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ValorServico = new System.Windows.Forms.Label();
            this.TOMao = new System.Windows.Forms.TextBox();
            this.ValorMao = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.Label();
            this.TOKM = new System.Windows.Forms.TextBox();
            this.Km = new System.Windows.Forms.Label();
            this.BOSair = new System.Windows.Forms.Button();
            this.TODescritivo = new System.Windows.Forms.TextBox();
            this.Descritivo = new System.Windows.Forms.Label();
            this.TOTelefone = new System.Windows.Forms.TextBox();
            this.TOModelo = new System.Windows.Forms.TextBox();
            this.TOANO = new System.Windows.Forms.TextBox();
            this.TOCPF = new System.Windows.Forms.TextBox();
            this.TONome = new System.Windows.Forms.TextBox();
            this.TOPlaca = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.AnoFabricacao = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.Label();
            this.Informacoes = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.consulta_BancoTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.Consulta_BancoTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(572, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 113;
            this.label4.Text = "NUMERO O.S:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14F);
            this.button1.Location = new System.Drawing.Point(279, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 107;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ValorServico
            // 
            this.ValorServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValorServico.AutoSize = true;
            this.ValorServico.BackColor = System.Drawing.Color.Transparent;
            this.ValorServico.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorServico.ForeColor = System.Drawing.Color.Moccasin;
            this.ValorServico.Location = new System.Drawing.Point(581, 442);
            this.ValorServico.Name = "ValorServico";
            this.ValorServico.Size = new System.Drawing.Size(196, 21);
            this.ValorServico.TabIndex = 106;
            this.ValorServico.Text = "VALOR TOTAL DO SERVIÇO:";
            // 
            // TOMao
            // 
            this.TOMao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TOMao.BackColor = System.Drawing.Color.Moccasin;
            this.TOMao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOMao.Enabled = false;
            this.TOMao.Location = new System.Drawing.Point(585, 377);
            this.TOMao.Name = "TOMao";
            this.TOMao.Size = new System.Drawing.Size(184, 20);
            this.TOMao.TabIndex = 105;
            this.TOMao.Text = "0";
            this.TOMao.TextChanged += new System.EventHandler(this.TOMao_TextChanged);
            // 
            // ValorMao
            // 
            this.ValorMao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValorMao.AutoSize = true;
            this.ValorMao.BackColor = System.Drawing.Color.Transparent;
            this.ValorMao.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorMao.ForeColor = System.Drawing.Color.Moccasin;
            this.ValorMao.Location = new System.Drawing.Point(583, 353);
            this.ValorMao.Name = "ValorMao";
            this.ValorMao.Size = new System.Drawing.Size(190, 21);
            this.ValorMao.TabIndex = 104;
            this.ValorMao.Text = "VALOR DA MÃO DE OBRA:";
            // 
            // ValorTotal
            // 
            this.ValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.ValorTotal.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotal.ForeColor = System.Drawing.Color.Moccasin;
            this.ValorTotal.Location = new System.Drawing.Point(581, 254);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(188, 21);
            this.ValorTotal.TabIndex = 103;
            this.ValorTotal.Text = "VALOR TOTAL DAS PEÇAS:";
            // 
            // TOKM
            // 
            this.TOKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOKM.BackColor = System.Drawing.Color.Moccasin;
            this.TOKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOKM.Enabled = false;
            this.TOKM.Location = new System.Drawing.Point(98, 534);
            this.TOKM.Name = "TOKM";
            this.TOKM.Size = new System.Drawing.Size(148, 20);
            this.TOKM.TabIndex = 102;
            this.TOKM.TextChanged += new System.EventHandler(this.TOKM_TextChanged);
            // 
            // Km
            // 
            this.Km.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Km.AutoSize = true;
            this.Km.BackColor = System.Drawing.Color.Transparent;
            this.Km.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Km.ForeColor = System.Drawing.Color.Moccasin;
            this.Km.Location = new System.Drawing.Point(32, 532);
            this.Km.Name = "Km";
            this.Km.Size = new System.Drawing.Size(39, 21);
            this.Km.TabIndex = 101;
            this.Km.Text = "KM:";
            // 
            // BOSair
            // 
            this.BOSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOSair.BackColor = System.Drawing.Color.Moccasin;
            this.BOSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOSair.Location = new System.Drawing.Point(666, 672);
            this.BOSair.Name = "BOSair";
            this.BOSair.Size = new System.Drawing.Size(122, 57);
            this.BOSair.TabIndex = 100;
            this.BOSair.Text = "SAIR";
            this.BOSair.UseVisualStyleBackColor = false;
            this.BOSair.Click += new System.EventHandler(this.BOSair_Click);
            // 
            // TODescritivo
            // 
            this.TODescritivo.BackColor = System.Drawing.Color.Moccasin;
            this.TODescritivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TODescritivo.Enabled = false;
            this.TODescritivo.Location = new System.Drawing.Point(19, 30);
            this.TODescritivo.Multiline = true;
            this.TODescritivo.Name = "TODescritivo";
            this.TODescritivo.Size = new System.Drawing.Size(227, 112);
            this.TODescritivo.TabIndex = 95;
            this.TODescritivo.TextChanged += new System.EventHandler(this.TODescritivo_TextChanged);
            // 
            // Descritivo
            // 
            this.Descritivo.AutoSize = true;
            this.Descritivo.BackColor = System.Drawing.Color.Transparent;
            this.Descritivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descritivo.ForeColor = System.Drawing.Color.Moccasin;
            this.Descritivo.Location = new System.Drawing.Point(13, 4);
            this.Descritivo.Name = "Descritivo";
            this.Descritivo.Size = new System.Drawing.Size(239, 24);
            this.Descritivo.TabIndex = 93;
            this.Descritivo.Text = "DESCRITIVO DO PROBLEMA:";
            // 
            // TOTelefone
            // 
            this.TOTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOTelefone.BackColor = System.Drawing.Color.Moccasin;
            this.TOTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTelefone.Enabled = false;
            this.TOTelefone.Location = new System.Drawing.Point(116, 383);
            this.TOTelefone.Name = "TOTelefone";
            this.TOTelefone.Size = new System.Drawing.Size(131, 20);
            this.TOTelefone.TabIndex = 94;
            this.TOTelefone.TextChanged += new System.EventHandler(this.TOTelefone_TextChanged);
            // 
            // TOModelo
            // 
            this.TOModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOModelo.BackColor = System.Drawing.Color.Moccasin;
            this.TOModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOModelo.Enabled = false;
            this.TOModelo.Location = new System.Drawing.Point(116, 478);
            this.TOModelo.Name = "TOModelo";
            this.TOModelo.Size = new System.Drawing.Size(131, 20);
            this.TOModelo.TabIndex = 92;
            this.TOModelo.TextChanged += new System.EventHandler(this.TOModelo_TextChanged);
            // 
            // TOANO
            // 
            this.TOANO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOANO.BackColor = System.Drawing.Color.Moccasin;
            this.TOANO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOANO.Enabled = false;
            this.TOANO.Location = new System.Drawing.Point(115, 429);
            this.TOANO.Name = "TOANO";
            this.TOANO.Size = new System.Drawing.Size(131, 20);
            this.TOANO.TabIndex = 91;
            this.TOANO.TextChanged += new System.EventHandler(this.TOANO_TextChanged);
            // 
            // TOCPF
            // 
            this.TOCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOCPF.BackColor = System.Drawing.Color.Moccasin;
            this.TOCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOCPF.Enabled = false;
            this.TOCPF.Location = new System.Drawing.Point(100, 257);
            this.TOCPF.Name = "TOCPF";
            this.TOCPF.Size = new System.Drawing.Size(148, 20);
            this.TOCPF.TabIndex = 90;
            this.TOCPF.TextChanged += new System.EventHandler(this.TOCPF_TextChanged);
            // 
            // TONome
            // 
            this.TONome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TONome.BackColor = System.Drawing.Color.Moccasin;
            this.TONome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TONome.Enabled = false;
            this.TONome.Location = new System.Drawing.Point(99, 340);
            this.TONome.Name = "TONome";
            this.TONome.Size = new System.Drawing.Size(148, 20);
            this.TONome.TabIndex = 89;
            this.TONome.TextChanged += new System.EventHandler(this.TONome_TextChanged);
            // 
            // TOPlaca
            // 
            this.TOPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TOPlaca.BackColor = System.Drawing.Color.Moccasin;
            this.TOPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOPlaca.Enabled = false;
            this.TOPlaca.Location = new System.Drawing.Point(99, 301);
            this.TOPlaca.Name = "TOPlaca";
            this.TOPlaca.Size = new System.Drawing.Size(148, 20);
            this.TOPlaca.TabIndex = 88;
            this.TOPlaca.TextChanged += new System.EventHandler(this.TOPlaca_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Telefone.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Moccasin;
            this.Telefone.Location = new System.Drawing.Point(33, 381);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(84, 21);
            this.Telefone.TabIndex = 87;
            this.Telefone.Text = "TELEFONE:";
            // 
            // CPF
            // 
            this.CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.Color.Moccasin;
            this.CPF.Location = new System.Drawing.Point(34, 257);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(41, 21);
            this.CPF.TabIndex = 86;
            this.CPF.Text = "CPF:";
            // 
            // Nome
            // 
            this.Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Moccasin;
            this.Nome.Location = new System.Drawing.Point(33, 338);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(60, 21);
            this.Nome.TabIndex = 85;
            this.Nome.Text = "NOME:";
            // 
            // AnoFabricacao
            // 
            this.AnoFabricacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AnoFabricacao.AutoSize = true;
            this.AnoFabricacao.BackColor = System.Drawing.Color.Transparent;
            this.AnoFabricacao.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoFabricacao.ForeColor = System.Drawing.Color.Moccasin;
            this.AnoFabricacao.Location = new System.Drawing.Point(32, 427);
            this.AnoFabricacao.Name = "AnoFabricacao";
            this.AnoFabricacao.Size = new System.Drawing.Size(81, 21);
            this.AnoFabricacao.TabIndex = 84;
            this.AnoFabricacao.Text = "ANO FAB.:";
            // 
            // Modelo
            // 
            this.Modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Modelo.AutoSize = true;
            this.Modelo.BackColor = System.Drawing.Color.Transparent;
            this.Modelo.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.ForeColor = System.Drawing.Color.Moccasin;
            this.Modelo.Location = new System.Drawing.Point(33, 476);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(77, 21);
            this.Modelo.TabIndex = 83;
            this.Modelo.Text = "MODELO:";
            // 
            // placa
            // 
            this.placa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.placa.AutoSize = true;
            this.placa.BackColor = System.Drawing.Color.Transparent;
            this.placa.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.ForeColor = System.Drawing.Color.Moccasin;
            this.placa.Location = new System.Drawing.Point(33, 301);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(60, 21);
            this.placa.TabIndex = 82;
            this.placa.Text = "PLACA:";
            // 
            // Informacoes
            // 
            this.Informacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Informacoes.AutoSize = true;
            this.Informacoes.BackColor = System.Drawing.Color.Transparent;
            this.Informacoes.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacoes.ForeColor = System.Drawing.Color.Moccasin;
            this.Informacoes.Location = new System.Drawing.Point(33, 221);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(214, 24);
            this.Informacoes.TabIndex = 81;
            this.Informacoes.Text = "INFORMAÇÕES CLIENTES";
            this.Informacoes.Click += new System.EventHandler(this.Informacoes_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.Moccasin;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(585, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 115;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.Moccasin;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(685, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 20);
            this.textBox3.TabIndex = 116;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.Moccasin;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(585, 466);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 20);
            this.textBox4.TabIndex = 117;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 8F);
            this.button3.Location = new System.Drawing.Point(621, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 118;
            this.button3.Text = "Consultar OS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // oficinaMecDataSet
            // 
            this.oficinaMecDataSet.DataSetName = "OficinaMecDataSet";
            this.oficinaMecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulta_BancoTableAdapter
            // 
            this.consulta_BancoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_BancoTableAdapter = this.consulta_BancoTableAdapter;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.OrcamentoTableAdapter = null;
            this.tableAdapterManager.Pecas_estoqueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(279, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 493);
            this.textBox1.TabIndex = 122;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14F);
            this.button2.Location = new System.Drawing.Point(25, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 57);
            this.button2.TabIndex = 123;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Moccasin;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 14F);
            this.button4.Location = new System.Drawing.Point(469, 672);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 57);
            this.button4.TabIndex = 124;
            this.button4.Text = "ORDENS DE SERVIÇO ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TelaOrdemServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValorServico);
            this.Controls.Add(this.TOMao);
            this.Controls.Add(this.ValorMao);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.TOKM);
            this.Controls.Add(this.Km);
            this.Controls.Add(this.BOSair);
            this.Controls.Add(this.TODescritivo);
            this.Controls.Add(this.Descritivo);
            this.Controls.Add(this.TOTelefone);
            this.Controls.Add(this.TOModelo);
            this.Controls.Add(this.TOANO);
            this.Controls.Add(this.TOCPF);
            this.Controls.Add(this.TONome);
            this.Controls.Add(this.TOPlaca);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AnoFabricacao);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.Informacoes);
            this.Name = "TelaOrdemServico";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TelaOrdemServico";
            this.Load += new System.EventHandler(this.TelaOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ValorServico;
        private System.Windows.Forms.TextBox TOMao;
        private System.Windows.Forms.Label ValorMao;
        private System.Windows.Forms.Label ValorTotal;
        private System.Windows.Forms.TextBox TOKM;
        private System.Windows.Forms.Label Km;
        private System.Windows.Forms.Button BOSair;
        private System.Windows.Forms.TextBox TODescritivo;
        private System.Windows.Forms.Label Descritivo;
        private System.Windows.Forms.TextBox TOTelefone;
        private System.Windows.Forms.TextBox TOModelo;
        private System.Windows.Forms.TextBox TOANO;
        private System.Windows.Forms.TextBox TOCPF;
        private System.Windows.Forms.TextBox TONome;
        private System.Windows.Forms.TextBox TOPlaca;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label AnoFabricacao;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label Informacoes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private OficinaMecDataSet oficinaMecDataSet;
        private OficinaMecDataSetTableAdapters.Consulta_BancoTableAdapter consulta_BancoTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button4;
    }
}