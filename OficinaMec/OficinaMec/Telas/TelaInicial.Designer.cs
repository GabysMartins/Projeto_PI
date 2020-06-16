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
            this.SuspendLayout();
            // 
            // BIEntrar
            // 
            this.BIEntrar.BackColor = System.Drawing.Color.Moccasin;
            this.BIEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIEntrar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIEntrar.Location = new System.Drawing.Point(336, 381);
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
            this.TISenha.Location = new System.Drawing.Point(349, 310);
            this.TISenha.Multiline = true;
            this.TISenha.Name = "TISenha";
            this.TISenha.Size = new System.Drawing.Size(169, 23);
            this.TISenha.TabIndex = 14;
            // 
            // TIUsuario
            // 
            this.TIUsuario.BackColor = System.Drawing.Color.Moccasin;
            this.TIUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TIUsuario.Location = new System.Drawing.Point(349, 275);
            this.TIUsuario.Multiline = true;
            this.TIUsuario.Name = "TIUsuario";
            this.TIUsuario.Size = new System.Drawing.Size(169, 23);
            this.TIUsuario.TabIndex = 13;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.Transparent;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Moccasin;
            this.Senha.Location = new System.Drawing.Point(245, 310);
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
            this.Usuario.Location = new System.Drawing.Point(245, 275);
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
            this.Abelha.Location = new System.Drawing.Point(216, 187);
            this.Abelha.Name = "Abelha";
            this.Abelha.Size = new System.Drawing.Size(345, 85);
            this.Abelha.TabIndex = 10;
            this.Abelha.Text = "ABELHA";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BIEntrar);
            this.Controls.Add(this.TISenha);
            this.Controls.Add(this.TIUsuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Abelha);
            this.Name = "TelaInicial";
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
    }
}