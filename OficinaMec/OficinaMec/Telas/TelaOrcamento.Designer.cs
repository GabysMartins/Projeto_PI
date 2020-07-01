namespace OficinaMec
{
    partial class TelaOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaOrcamento));
            this.TOKM = new System.Windows.Forms.TextBox();
            this.Km = new System.Windows.Forms.Label();
            this.BOSair = new System.Windows.Forms.Button();
            this.BOCancelar = new System.Windows.Forms.Button();
            this.BOAbrir = new System.Windows.Forms.Button();
            this.BOEliminar = new System.Windows.Forms.Button();
            this.BOAcrescentar = new System.Windows.Forms.Button();
            this.TODescritivo = new System.Windows.Forms.TextBox();
            this.Descritivo = new System.Windows.Forms.Label();
            this.TOTelefone = new System.Windows.Forms.TextBox();
            this.TOModelo = new System.Windows.Forms.TextBox();
            this.TOANO = new System.Windows.Forms.TextBox();
            this.TONome = new System.Windows.Forms.TextBox();
            this.TOPlaca = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.AnoFabricacao = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.Label();
            this.Informacoes = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.TOMao = new System.Windows.Forms.TextBox();
            this.ValorMao = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.Label();
            this.oficinaMecDataSet = new OficinaMec.OficinaMecDataSet();
            this.orcamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orcamentosTableAdapter = new OficinaMec.OficinaMecDataSetTableAdapters.OrcamentosTableAdapter();
            this.tableAdapterManager = new OficinaMec.OficinaMecDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TOCPF = new System.Windows.Forms.MaskedTextBox();
            this.ValorServico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TOKM
            // 
            this.TOKM.BackColor = System.Drawing.Color.Moccasin;
            this.TOKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOKM.Location = new System.Drawing.Point(95, 344);
            this.TOKM.Name = "TOKM";
            this.TOKM.Size = new System.Drawing.Size(148, 20);
            this.TOKM.TabIndex = 59;
            // 
            // Km
            // 
            this.Km.AutoSize = true;
            this.Km.BackColor = System.Drawing.Color.Transparent;
            this.Km.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Km.ForeColor = System.Drawing.Color.Moccasin;
            this.Km.Location = new System.Drawing.Point(29, 342);
            this.Km.Name = "Km";
            this.Km.Size = new System.Drawing.Size(39, 21);
            this.Km.TabIndex = 58;
            this.Km.Text = "KM:";
            // 
            // BOSair
            // 
            this.BOSair.BackColor = System.Drawing.Color.Moccasin;
            this.BOSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOSair.Location = new System.Drawing.Point(666, 396);
            this.BOSair.Name = "BOSair";
            this.BOSair.Size = new System.Drawing.Size(122, 57);
            this.BOSair.TabIndex = 57;
            this.BOSair.Text = "SAIR";
            this.BOSair.UseVisualStyleBackColor = false;
            this.BOSair.Click += new System.EventHandler(this.BOSair_Click);
            // 
            // BOCancelar
            // 
            this.BOCancelar.BackColor = System.Drawing.Color.Moccasin;
            this.BOCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOCancelar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOCancelar.Location = new System.Drawing.Point(538, 396);
            this.BOCancelar.Name = "BOCancelar";
            this.BOCancelar.Size = new System.Drawing.Size(122, 57);
            this.BOCancelar.TabIndex = 56;
            this.BOCancelar.Text = "CONSULTAR ORDEM";
            this.BOCancelar.UseVisualStyleBackColor = false;
            this.BOCancelar.Click += new System.EventHandler(this.BOCancelar_Click);
            // 
            // BOAbrir
            // 
            this.BOAbrir.BackColor = System.Drawing.Color.Moccasin;
            this.BOAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOAbrir.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOAbrir.Location = new System.Drawing.Point(410, 396);
            this.BOAbrir.Name = "BOAbrir";
            this.BOAbrir.Size = new System.Drawing.Size(122, 57);
            this.BOAbrir.TabIndex = 55;
            this.BOAbrir.Text = "GERAR ORDEM ";
            this.BOAbrir.UseVisualStyleBackColor = false;
            this.BOAbrir.Click += new System.EventHandler(this.BOAbrir_Click);
            // 
            // BOEliminar
            // 
            this.BOEliminar.BackColor = System.Drawing.Color.Moccasin;
            this.BOEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOEliminar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOEliminar.Location = new System.Drawing.Point(282, 396);
            this.BOEliminar.Name = "BOEliminar";
            this.BOEliminar.Size = new System.Drawing.Size(122, 57);
            this.BOEliminar.TabIndex = 54;
            this.BOEliminar.Text = "ELIMINAR ITENS";
            this.BOEliminar.UseVisualStyleBackColor = false;
            this.BOEliminar.Click += new System.EventHandler(this.BOEliminar_Click);
            // 
            // BOAcrescentar
            // 
            this.BOAcrescentar.BackColor = System.Drawing.Color.Moccasin;
            this.BOAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOAcrescentar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOAcrescentar.Location = new System.Drawing.Point(154, 396);
            this.BOAcrescentar.Name = "BOAcrescentar";
            this.BOAcrescentar.Size = new System.Drawing.Size(122, 57);
            this.BOAcrescentar.TabIndex = 53;
            this.BOAcrescentar.Text = "ACRESCENTAR ITENS";
            this.BOAcrescentar.UseVisualStyleBackColor = false;
            this.BOAcrescentar.Click += new System.EventHandler(this.BOAcrescentar_Click);
            // 
            // TODescritivo
            // 
            this.TODescritivo.BackColor = System.Drawing.Color.Moccasin;
            this.TODescritivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TODescritivo.Location = new System.Drawing.Point(27, 36);
            this.TODescritivo.Multiline = true;
            this.TODescritivo.Name = "TODescritivo";
            this.TODescritivo.Size = new System.Drawing.Size(227, 112);
            this.TODescritivo.TabIndex = 52;
            // 
            // Descritivo
            // 
            this.Descritivo.AutoSize = true;
            this.Descritivo.BackColor = System.Drawing.Color.Transparent;
            this.Descritivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descritivo.ForeColor = System.Drawing.Color.Moccasin;
            this.Descritivo.Location = new System.Drawing.Point(21, 10);
            this.Descritivo.Name = "Descritivo";
            this.Descritivo.Size = new System.Drawing.Size(239, 24);
            this.Descritivo.TabIndex = 50;
            this.Descritivo.Text = "DESCRITIVO DO PROBLEMA:";
            // 
            // TOTelefone
            // 
            this.TOTelefone.BackColor = System.Drawing.Color.Moccasin;
            this.TOTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOTelefone.Location = new System.Drawing.Point(112, 268);
            this.TOTelefone.Name = "TOTelefone";
            this.TOTelefone.Size = new System.Drawing.Size(131, 20);
            this.TOTelefone.TabIndex = 51;
            // 
            // TOModelo
            // 
            this.TOModelo.BackColor = System.Drawing.Color.Moccasin;
            this.TOModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOModelo.Location = new System.Drawing.Point(112, 319);
            this.TOModelo.Name = "TOModelo";
            this.TOModelo.Size = new System.Drawing.Size(131, 20);
            this.TOModelo.TabIndex = 49;
            // 
            // TOANO
            // 
            this.TOANO.BackColor = System.Drawing.Color.Moccasin;
            this.TOANO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOANO.Location = new System.Drawing.Point(112, 294);
            this.TOANO.Name = "TOANO";
            this.TOANO.Size = new System.Drawing.Size(131, 20);
            this.TOANO.TabIndex = 48;
            // 
            // TONome
            // 
            this.TONome.BackColor = System.Drawing.Color.Moccasin;
            this.TONome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TONome.Location = new System.Drawing.Point(95, 244);
            this.TONome.Name = "TONome";
            this.TONome.Size = new System.Drawing.Size(148, 20);
            this.TONome.TabIndex = 46;
            this.TONome.TextChanged += new System.EventHandler(this.TONome_TextChanged);
            // 
            // TOPlaca
            // 
            this.TOPlaca.BackColor = System.Drawing.Color.Moccasin;
            this.TOPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOPlaca.Location = new System.Drawing.Point(95, 221);
            this.TOPlaca.Name = "TOPlaca";
            this.TOPlaca.Size = new System.Drawing.Size(148, 20);
            this.TOPlaca.TabIndex = 45;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Telefone.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Moccasin;
            this.Telefone.Location = new System.Drawing.Point(29, 266);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(84, 21);
            this.Telefone.TabIndex = 44;
            this.Telefone.Text = "TELEFONE:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.Color.Moccasin;
            this.CPF.Location = new System.Drawing.Point(29, 197);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(41, 21);
            this.CPF.TabIndex = 43;
            this.CPF.Text = "CPF:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Moccasin;
            this.Nome.Location = new System.Drawing.Point(29, 242);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(60, 21);
            this.Nome.TabIndex = 42;
            this.Nome.Text = "NOME:";
            // 
            // AnoFabricacao
            // 
            this.AnoFabricacao.AutoSize = true;
            this.AnoFabricacao.BackColor = System.Drawing.Color.Transparent;
            this.AnoFabricacao.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoFabricacao.ForeColor = System.Drawing.Color.Moccasin;
            this.AnoFabricacao.Location = new System.Drawing.Point(29, 292);
            this.AnoFabricacao.Name = "AnoFabricacao";
            this.AnoFabricacao.Size = new System.Drawing.Size(81, 21);
            this.AnoFabricacao.TabIndex = 41;
            this.AnoFabricacao.Text = "ANO FAB.:";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.BackColor = System.Drawing.Color.Transparent;
            this.Modelo.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelo.ForeColor = System.Drawing.Color.Moccasin;
            this.Modelo.Location = new System.Drawing.Point(29, 317);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(77, 21);
            this.Modelo.TabIndex = 40;
            this.Modelo.Text = "MODELO:";
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.BackColor = System.Drawing.Color.Transparent;
            this.placa.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.ForeColor = System.Drawing.Color.Moccasin;
            this.placa.Location = new System.Drawing.Point(29, 221);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(60, 21);
            this.placa.TabIndex = 39;
            this.placa.Text = "PLACA:";
            // 
            // Informacoes
            // 
            this.Informacoes.AutoSize = true;
            this.Informacoes.BackColor = System.Drawing.Color.Transparent;
            this.Informacoes.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacoes.ForeColor = System.Drawing.Color.Moccasin;
            this.Informacoes.Location = new System.Drawing.Point(28, 161);
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(214, 24);
            this.Informacoes.TabIndex = 38;
            this.Informacoes.Text = "INFORMAÇÕES CLIENTES";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Moccasin;
            this.label37.Location = new System.Drawing.Point(593, 316);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(196, 21);
            this.label37.TabIndex = 68;
            this.label37.Text = "VALOR TOTAL DO SERVIÇO:";
            // 
            // TOMao
            // 
            this.TOMao.BackColor = System.Drawing.Color.Moccasin;
            this.TOMao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TOMao.Location = new System.Drawing.Point(595, 242);
            this.TOMao.Name = "TOMao";
            this.TOMao.Size = new System.Drawing.Size(184, 20);
            this.TOMao.TabIndex = 67;
            this.TOMao.Text = "0";
            // 
            // ValorMao
            // 
            this.ValorMao.AutoSize = true;
            this.ValorMao.BackColor = System.Drawing.Color.Transparent;
            this.ValorMao.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorMao.ForeColor = System.Drawing.Color.Moccasin;
            this.ValorMao.Location = new System.Drawing.Point(593, 218);
            this.ValorMao.Name = "ValorMao";
            this.ValorMao.Size = new System.Drawing.Size(190, 21);
            this.ValorMao.TabIndex = 66;
            this.ValorMao.Text = "VALOR DA MÃO DE OBRA:";
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.ValorTotal.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotal.ForeColor = System.Drawing.Color.Moccasin;
            this.ValorTotal.Location = new System.Drawing.Point(591, 166);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(188, 21);
            this.ValorTotal.TabIndex = 64;
            this.ValorTotal.Text = "VALOR TOTAL DAS PEÇAS:";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.Location = new System.Drawing.Point(26, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 57);
            this.button1.TabIndex = 71;
            this.button1.Text = "PREENCHER INFORAÇÕES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Moccasin;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(259, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 232);
            this.listBox1.TabIndex = 72;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(170, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(29, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "CODIGO DA PECA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(591, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 8F);
            this.button2.Location = new System.Drawing.Point(626, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 77;
            this.button2.Text = "TOTAL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(716, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(599, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "NUMERO O.S:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Moccasin;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 8F);
            this.button3.Location = new System.Drawing.Point(603, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 80;
            this.button3.Text = "GERAR NUMERO DE OS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TOCPF
            // 
            this.TOCPF.BackColor = System.Drawing.Color.Moccasin;
            this.TOCPF.Location = new System.Drawing.Point(76, 195);
            this.TOCPF.Mask = "000,000,000-00";
            this.TOCPF.Name = "TOCPF";
            this.TOCPF.Size = new System.Drawing.Size(167, 20);
            this.TOCPF.TabIndex = 81;
            // 
            // ValorServico
            // 
            this.ValorServico.BackColor = System.Drawing.Color.Moccasin;
            this.ValorServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValorServico.Location = new System.Drawing.Point(595, 340);
            this.ValorServico.Name = "ValorServico";
            this.ValorServico.Size = new System.Drawing.Size(184, 20);
            this.ValorServico.TabIndex = 82;
            this.ValorServico.Text = "0";
            // 
            // TelaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.ValorServico);
            this.Controls.Add(this.TOCPF);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.TOMao);
            this.Controls.Add(this.ValorMao);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.TOKM);
            this.Controls.Add(this.Km);
            this.Controls.Add(this.BOSair);
            this.Controls.Add(this.BOCancelar);
            this.Controls.Add(this.BOAbrir);
            this.Controls.Add(this.BOEliminar);
            this.Controls.Add(this.BOAcrescentar);
            this.Controls.Add(this.TODescritivo);
            this.Controls.Add(this.Descritivo);
            this.Controls.Add(this.TOTelefone);
            this.Controls.Add(this.TOModelo);
            this.Controls.Add(this.TOANO);
            this.Controls.Add(this.TONome);
            this.Controls.Add(this.TOPlaca);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.AnoFabricacao);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.Informacoes);
            this.Name = "TelaOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaOrcamento";
            this.Load += new System.EventHandler(this.TelaOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oficinaMecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TOKM;
        private System.Windows.Forms.Label Km;
        private System.Windows.Forms.Button BOSair;
        private System.Windows.Forms.Button BOCancelar;
        private System.Windows.Forms.Button BOAbrir;
        private System.Windows.Forms.Button BOEliminar;
        private System.Windows.Forms.Button BOAcrescentar;
        private System.Windows.Forms.TextBox TODescritivo;
        private System.Windows.Forms.Label Descritivo;
        private System.Windows.Forms.TextBox TOTelefone;
        private System.Windows.Forms.TextBox TOModelo;
        private System.Windows.Forms.TextBox TOANO;
        private System.Windows.Forms.TextBox TONome;
        private System.Windows.Forms.TextBox TOPlaca;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label AnoFabricacao;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label Informacoes;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox TOMao;
        private System.Windows.Forms.Label ValorMao;
        private System.Windows.Forms.Label ValorTotal;
        private OficinaMecDataSet oficinaMecDataSet;
        private System.Windows.Forms.BindingSource orcamentosBindingSource;
        private OficinaMecDataSetTableAdapters.OrcamentosTableAdapter orcamentosTableAdapter;
        private OficinaMecDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox TOCPF;
        private System.Windows.Forms.TextBox ValorServico;
    }
}