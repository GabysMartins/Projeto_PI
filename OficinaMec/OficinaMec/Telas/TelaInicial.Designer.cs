namespace OficinaMec
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.BIEntrar = new System.Windows.Forms.Button();
            this.TISenha = new System.Windows.Forms.TextBox();
            this.TIUsuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Abelha = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BIEntrar
            // 
            this.BIEntrar.BackColor = System.Drawing.Color.Moccasin;
            this.BIEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIEntrar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIEntrar.Location = new System.Drawing.Point(320, 321);
            this.BIEntrar.Name = "BIEntrar";
            this.BIEntrar.Size = new System.Drawing.Size(151, 57);
            this.BIEntrar.TabIndex = 15;
            this.BIEntrar.Text = "ENTRAR";
            this.BIEntrar.UseVisualStyleBackColor = false;
            this.BIEntrar.Click += new System.EventHandler(this.BIEntrar_Click);
            // 
            // TISenha
            // 
            this.TISenha.BackColor = System.Drawing.Color.Moccasin;
            this.TISenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TISenha.Location = new System.Drawing.Point(333, 255);
            this.TISenha.Name = "TISenha";
            this.TISenha.PasswordChar = '*';
            this.TISenha.Size = new System.Drawing.Size(169, 13);
            this.TISenha.TabIndex = 14;
            // 
            // TIUsuario
            // 
            this.TIUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.TIUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TIUsuario.Location = new System.Drawing.Point(333, 223);
            this.TIUsuario.Name = "TIUsuario";
            this.TIUsuario.Size = new System.Drawing.Size(169, 13);
            this.TIUsuario.TabIndex = 15;
            this.TIUsuario.TextChanged += new System.EventHandler(this.TIUsuario_TextChanged);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.Transparent;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Moccasin;
            this.Senha.Location = new System.Drawing.Point(229, 247);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(81, 24);
            this.Senha.TabIndex = 12;
            this.Senha.Text = "SENHA:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Moccasin;
            this.Usuario.Location = new System.Drawing.Point(229, 215);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(98, 24);
            this.Usuario.TabIndex = 11;
            this.Usuario.Text = "USUÁRIO:";
            // 
            // Abelha
            // 
            this.Abelha.AutoSize = true;
            this.Abelha.BackColor = System.Drawing.Color.Transparent;
            this.Abelha.Font = new System.Drawing.Font("Baskerville Old Face", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abelha.ForeColor = System.Drawing.Color.Moccasin;
            this.Abelha.Location = new System.Drawing.Point(200, 127);
            this.Abelha.Name = "Abelha";
            this.Abelha.Size = new System.Drawing.Size(345, 85);
            this.Abelha.TabIndex = 10;
            this.Abelha.Text = "ABELHA";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton4.Location = new System.Drawing.Point(583, 286);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 17);
            this.radioButton4.TabIndex = 90;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Estoquista";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton3.Location = new System.Drawing.Point(505, 286);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 89;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mecanico";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton2.Location = new System.Drawing.Point(426, 286);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 88;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Secretaria";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.Moccasin;
            this.radioButton1.Location = new System.Drawing.Point(332, 286);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 87;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Administrador";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(229, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 86;
            this.label1.Text = "PERMISSÃO:";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BIEntrar);
            this.Controls.Add(this.TISenha);
            this.Controls.Add(this.TIUsuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Abelha);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BIEntrar;
        private System.Windows.Forms.TextBox TISenha;
        private System.Windows.Forms.TextBox TIUsuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Abelha;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}