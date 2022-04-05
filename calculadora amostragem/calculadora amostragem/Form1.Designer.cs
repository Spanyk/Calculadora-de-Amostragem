namespace calculadora_amostragem
{
    partial class Form1
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
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEstimativa = new System.Windows.Forms.TextBox();
            this.txterroAmostral = new System.Windows.Forms.TextBox();
            this.cbox_nivelConfia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.BackColor = System.Drawing.Color.White;
            this.txtPopulacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPopulacao.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPopulacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPopulacao.Location = new System.Drawing.Point(12, 32);
            this.txtPopulacao.MaxLength = 100;
            this.txtPopulacao.Multiline = true;
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPopulacao.Size = new System.Drawing.Size(394, 53);
            this.txtPopulacao.TabIndex = 0;
            this.txtPopulacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 133);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEstimativa
            // 
            this.txtEstimativa.BackColor = System.Drawing.Color.White;
            this.txtEstimativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstimativa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtEstimativa.Location = new System.Drawing.Point(12, 117);
            this.txtEstimativa.Multiline = true;
            this.txtEstimativa.Name = "txtEstimativa";
            this.txtEstimativa.Size = new System.Drawing.Size(266, 55);
            this.txtEstimativa.TabIndex = 8;
            this.txtEstimativa.TextChanged += new System.EventHandler(this.txtEstimativa_TextChanged);
            // 
            // txterroAmostral
            // 
            this.txterroAmostral.BackColor = System.Drawing.Color.White;
            this.txterroAmostral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txterroAmostral.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txterroAmostral.Location = new System.Drawing.Point(16, 198);
            this.txterroAmostral.Multiline = true;
            this.txterroAmostral.Name = "txterroAmostral";
            this.txterroAmostral.Size = new System.Drawing.Size(390, 56);
            this.txterroAmostral.TabIndex = 9;
            this.txterroAmostral.TextChanged += new System.EventHandler(this.txterroAmostral_TextChanged);
            // 
            // cbox_nivelConfia
            // 
            this.cbox_nivelConfia.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.cbox_nivelConfia.FormattingEnabled = true;
            this.cbox_nivelConfia.Items.AddRange(new object[] {
            "90%",
            "95%",
            "95.5%",
            "99%"});
            this.cbox_nivelConfia.Location = new System.Drawing.Point(288, 117);
            this.cbox_nivelConfia.Name = "cbox_nivelConfia";
            this.cbox_nivelConfia.Size = new System.Drawing.Size(118, 29);
            this.cbox_nivelConfia.TabIndex = 10;
            this.cbox_nivelConfia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "População";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Margem de erro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estimativa Verdadeira proporção";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nível Confiança";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(421, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_nivelConfia);
            this.Controls.Add(this.txterroAmostral);
            this.Controls.Add(this.txtEstimativa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPopulacao);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Amostragem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEstimativa;
        private System.Windows.Forms.TextBox txterroAmostral;
        private System.Windows.Forms.ComboBox cbox_nivelConfia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

