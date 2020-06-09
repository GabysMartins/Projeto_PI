namespace OficinaMec
{
    partial class TelaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConsulta));
            this.BCSair = new System.Windows.Forms.Button();
            this.BCConsultar = new System.Windows.Forms.Button();
            this.TCCPF = new System.Windows.Forms.TextBox();
            this.TCPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCSair
            // 
            this.BCSair.BackColor = System.Drawing.Color.Moccasin;
            this.BCSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCSair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCSair.Location = new System.Drawing.Point(313, 381);
            this.BCSair.Name = "BCSair";
            this.BCSair.Size = new System.Drawing.Size(136, 57);
            this.BCSair.TabIndex = 54;
            this.BCSair.Text = "SAIR";
            this.BCSair.UseVisualStyleBackColor = false;
            this.BCSair.Click += new System.EventHandler(this.BCSair_Click);
            // 
            // BCConsultar
            // 
            this.BCConsultar.BackColor = System.Drawing.Color.Moccasin;
            this.BCConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCConsultar.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BCConsultar.Location = new System.Drawing.Point(461, 222);
            this.BCConsultar.Name = "BCConsultar";
            this.BCConsultar.Size = new System.Drawing.Size(136, 57);
            this.BCConsultar.TabIndex = 53;
            this.BCConsultar.Text = "CONSULTAR";
            this.BCConsultar.UseVisualStyleBackColor = false;
            // 
            // TCCPF
            // 
            this.TCCPF.BackColor = System.Drawing.Color.Moccasin;
            this.TCCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCCPF.Location = new System.Drawing.Point(240, 212);
            this.TCCPF.Name = "TCCPF";
            this.TCCPF.Size = new System.Drawing.Size(148, 20);
            this.TCCPF.TabIndex = 52;
            // 
            // TCPlaca
            // 
            this.TCPlaca.BackColor = System.Drawing.Color.Moccasin;
            this.TCPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCPlaca.Location = new System.Drawing.Point(240, 272);
            this.TCPlaca.Name = "TCPlaca";
            this.TCPlaca.Size = new System.Drawing.Size(148, 20);
            this.TCPlaca.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(165, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "CPF:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Moccasin;
            this.Nome.Location = new System.Drawing.Point(165, 271);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(60, 21);
            this.Nome.TabIndex = 49;
            this.Nome.Text = "PLACA:";
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCSair);
            this.Controls.Add(this.BCConsultar);
            this.Controls.Add(this.TCCPF);
            this.Controls.Add(this.TCPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome);
            this.Name = "TelaConsulta";
            this.Text = "TelaConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCSair;
        private System.Windows.Forms.Button BCConsultar;
        private System.Windows.Forms.TextBox TCCPF;
        private System.Windows.Forms.TextBox TCPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nome;
    }
}