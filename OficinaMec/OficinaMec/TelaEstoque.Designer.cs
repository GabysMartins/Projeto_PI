namespace OficinaMec
{
    partial class TelaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            this.BESolicitacao = new System.Windows.Forms.Button();
            this.BEBaixa = new System.Windows.Forms.Button();
            this.BEExcluir = new System.Windows.Forms.Button();
            this.BEAcrescentar = new System.Windows.Forms.Button();
            this.BESair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BESolicitacao
            // 
            this.BESolicitacao.BackColor = System.Drawing.Color.Moccasin;
            this.BESolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BESolicitacao.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BESolicitacao.Location = new System.Drawing.Point(603, 381);
            this.BESolicitacao.Name = "BESolicitacao";
            this.BESolicitacao.Size = new System.Drawing.Size(122, 57);
            this.BESolicitacao.TabIndex = 44;
            this.BESolicitacao.Text = "SOLIC. DE COMPRA";
            this.BESolicitacao.UseVisualStyleBackColor = false;
            // 
            // BEBaixa
            // 
            this.BEBaixa.BackColor = System.Drawing.Color.Moccasin;
            this.BEBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEBaixa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEBaixa.Location = new System.Drawing.Point(475, 381);
            this.BEBaixa.Name = "BEBaixa";
            this.BEBaixa.Size = new System.Drawing.Size(122, 57);
            this.BEBaixa.TabIndex = 43;
            this.BEBaixa.Text = "BAIXA ESTOQUE";
            this.BEBaixa.UseVisualStyleBackColor = false;
            // 
            // BEExcluir
            // 
            this.BEExcluir.BackColor = System.Drawing.Color.Moccasin;
            this.BEExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEExcluir.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEExcluir.Location = new System.Drawing.Point(347, 381);
            this.BEExcluir.Name = "BEExcluir";
            this.BEExcluir.Size = new System.Drawing.Size(122, 57);
            this.BEExcluir.TabIndex = 42;
            this.BEExcluir.Text = "EXCLUIR ITENS";
            this.BEExcluir.UseVisualStyleBackColor = false;
            // 
            // BEAcrescentar
            // 
            this.BEAcrescentar.BackColor = System.Drawing.Color.Moccasin;
            this.BEAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEAcrescentar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEAcrescentar.Location = new System.Drawing.Point(219, 381);
            this.BEAcrescentar.Name = "BEAcrescentar";
            this.BEAcrescentar.Size = new System.Drawing.Size(122, 57);
            this.BEAcrescentar.TabIndex = 41;
            this.BEAcrescentar.Text = "ACRESCENTAR ITENS";
            this.BEAcrescentar.UseVisualStyleBackColor = false;
            // 
            // BESair
            // 
            this.BESair.BackColor = System.Drawing.Color.Moccasin;
            this.BESair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BESair.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BESair.Location = new System.Drawing.Point(91, 380);
            this.BESair.Name = "BESair";
            this.BESair.Size = new System.Drawing.Size(122, 57);
            this.BESair.TabIndex = 46;
            this.BESair.Text = "SAIR";
            this.BESair.UseVisualStyleBackColor = false;
            this.BESair.Click += new System.EventHandler(this.BESair_Click);
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BESair);
            this.Controls.Add(this.BESolicitacao);
            this.Controls.Add(this.BEBaixa);
            this.Controls.Add(this.BEExcluir);
            this.Controls.Add(this.BEAcrescentar);
            this.Name = "TelaEstoque";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "TelaEstoque";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BESolicitacao;
        private System.Windows.Forms.Button BEBaixa;
        private System.Windows.Forms.Button BEExcluir;
        private System.Windows.Forms.Button BEAcrescentar;
        private System.Windows.Forms.Button BESair;
    }
}