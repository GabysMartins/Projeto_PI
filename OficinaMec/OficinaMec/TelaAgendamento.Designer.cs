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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAgendamento));
            this.BASair = new System.Windows.Forms.Button();
            this.BAAgendar = new System.Windows.Forms.Button();
            this.TADescritivo = new System.Windows.Forms.TextBox();
            this.Descritivo = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TATelefone = new System.Windows.Forms.TextBox();
            this.TAModelo = new System.Windows.Forms.TextBox();
            this.TAANO = new System.Windows.Forms.TextBox();
            this.TACPF = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // BASair
            // 
            this.BASair.BackColor = System.Drawing.Color.Moccasin;
            this.BASair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BASair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASair.Location = new System.Drawing.Point(12, 383);
            this.BASair.Name = "BASair";
            this.BASair.Size = new System.Drawing.Size(151, 57);
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
            this.BAAgendar.Location = new System.Drawing.Point(180, 383);
            this.BAAgendar.Name = "BAAgendar";
            this.BAAgendar.Size = new System.Drawing.Size(151, 57);
            this.BAAgendar.TabIndex = 34;
            this.BAAgendar.Text = "AGENDAR";
            this.BAAgendar.UseVisualStyleBackColor = false;
            this.BAAgendar.Click += new System.EventHandler(this.BAAgendar_Click);
            // 
            // TADescritivo
            // 
            this.TADescritivo.BackColor = System.Drawing.Color.Moccasin;
            this.TADescritivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TADescritivo.Location = new System.Drawing.Point(586, 313);
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
            this.Descritivo.Location = new System.Drawing.Point(580, 287);
            this.Descritivo.Name = "Descritivo";
            this.Descritivo.Size = new System.Drawing.Size(239, 24);
            this.Descritivo.TabIndex = 31;
            this.Descritivo.Text = "DESCRITIVO DO PROBLEMA:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            // 
            // TATelefone
            // 
            this.TATelefone.BackColor = System.Drawing.Color.Moccasin;
            this.TATelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TATelefone.Location = new System.Drawing.Point(665, 246);
            this.TATelefone.Name = "TATelefone";
            this.TATelefone.Size = new System.Drawing.Size(131, 20);
            this.TATelefone.TabIndex = 30;
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
            // TACPF
            // 
            this.TACPF.BackColor = System.Drawing.Color.Moccasin;
            this.TACPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TACPF.Location = new System.Drawing.Point(648, 168);
            this.TACPF.Name = "TACPF";
            this.TACPF.Size = new System.Drawing.Size(148, 20);
            this.TACPF.TabIndex = 27;
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
            this.Informacoes.Location = new System.Drawing.Point(582, 85);
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
            this.BALimpar.Location = new System.Drawing.Point(350, 383);
            this.BALimpar.Name = "BALimpar";
            this.BALimpar.Size = new System.Drawing.Size(151, 57);
            this.BALimpar.TabIndex = 36;
            this.BALimpar.Text = "LIMPAR";
            this.BALimpar.UseVisualStyleBackColor = false;
            this.BALimpar.Click += new System.EventHandler(this.BALimpar_Click);
            // 
            // TelaAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.BALimpar);
            this.Controls.Add(this.BASair);
            this.Controls.Add(this.BAAgendar);
            this.Controls.Add(this.TADescritivo);
            this.Controls.Add(this.Descritivo);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TATelefone);
            this.Controls.Add(this.TAModelo);
            this.Controls.Add(this.TAANO);
            this.Controls.Add(this.TACPF);
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
            this.Text = "Tela Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BASair;
        private System.Windows.Forms.Button BAAgendar;
        private System.Windows.Forms.TextBox TADescritivo;
        private System.Windows.Forms.Label Descritivo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox TATelefone;
        private System.Windows.Forms.TextBox TAModelo;
        private System.Windows.Forms.TextBox TAANO;
        private System.Windows.Forms.TextBox TACPF;
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
    }
}

