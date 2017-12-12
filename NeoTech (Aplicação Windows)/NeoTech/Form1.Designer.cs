namespace NeoTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.campoOrcamento = new System.Windows.Forms.TextBox();
            this.campoMargemLucro = new System.Windows.Forms.TextBox();
            this.campoTaxaTributo = new System.Windows.Forms.TextBox();
            this.campoValorLucro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campoValorTributo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoOrcamentoFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campoOrcamento
            // 
            this.campoOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoOrcamento.Location = new System.Drawing.Point(217, 13);
            this.campoOrcamento.Name = "campoOrcamento";
            this.campoOrcamento.Size = new System.Drawing.Size(115, 26);
            this.campoOrcamento.TabIndex = 0;
            // 
            // campoMargemLucro
            // 
            this.campoMargemLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoMargemLucro.Location = new System.Drawing.Point(217, 45);
            this.campoMargemLucro.Name = "campoMargemLucro";
            this.campoMargemLucro.Size = new System.Drawing.Size(115, 26);
            this.campoMargemLucro.TabIndex = 1;
            // 
            // campoTaxaTributo
            // 
            this.campoTaxaTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTaxaTributo.Location = new System.Drawing.Point(217, 77);
            this.campoTaxaTributo.Name = "campoTaxaTributo";
            this.campoTaxaTributo.Size = new System.Drawing.Size(115, 26);
            this.campoTaxaTributo.TabIndex = 2;
            // 
            // campoValorLucro
            // 
            this.campoValorLucro.Enabled = false;
            this.campoValorLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoValorLucro.Location = new System.Drawing.Point(12, 231);
            this.campoValorLucro.Name = "campoValorLucro";
            this.campoValorLucro.Size = new System.Drawing.Size(320, 26);
            this.campoValorLucro.TabIndex = 3;
            this.campoValorLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor do Lucro (R$)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor do Orçamento (R$):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Margem de Lucro (%):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa Tributária(%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor dos Tributos (R$)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoValorTributo
            // 
            this.campoValorTributo.Enabled = false;
            this.campoValorTributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoValorTributo.Location = new System.Drawing.Point(12, 286);
            this.campoValorTributo.Name = "campoValorTributo";
            this.campoValorTributo.Size = new System.Drawing.Size(320, 26);
            this.campoValorTributo.TabIndex = 8;
            this.campoValorTributo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Final do Orçamento (R$)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoOrcamentoFinal
            // 
            this.campoOrcamentoFinal.Enabled = false;
            this.campoOrcamentoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoOrcamentoFinal.Location = new System.Drawing.Point(12, 341);
            this.campoOrcamentoFinal.Name = "campoOrcamentoFinal";
            this.campoOrcamentoFinal.Size = new System.Drawing.Size(320, 26);
            this.campoOrcamentoFinal.TabIndex = 10;
            this.campoOrcamentoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "RESULTADOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(344, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoOrcamentoFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoValorTributo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoValorLucro);
            this.Controls.Add(this.campoTaxaTributo);
            this.Controls.Add(this.campoMargemLucro);
            this.Controls.Add(this.campoOrcamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NeoTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoOrcamento;
        private System.Windows.Forms.TextBox campoMargemLucro;
        private System.Windows.Forms.TextBox campoTaxaTributo;
        private System.Windows.Forms.TextBox campoValorLucro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoValorTributo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoOrcamentoFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

