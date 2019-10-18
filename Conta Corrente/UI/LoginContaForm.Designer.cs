namespace Conta_Corrente
{
    partial class LoginContaForm
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
            this.contaTxtBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acessoButton = new System.Windows.Forms.Button();
            this.contaLabel = new System.Windows.Forms.Label();
            this.agenciaLabel = new System.Windows.Forms.Label();
            this.digitoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contaTxtBox
            // 
            this.contaTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.contaTxtBox.Location = new System.Drawing.Point(191, 112);
            this.contaTxtBox.MaxLength = 4;
            this.contaTxtBox.Name = "contaTxtBox";
            this.contaTxtBox.Size = new System.Drawing.Size(43, 20);
            this.contaTxtBox.TabIndex = 0;
            this.contaTxtBox.TextChanged += new System.EventHandler(this.contaTxtBox_TextChanged);
            this.contaTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberCheck_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 112);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 112);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // acessoButton
            // 
            this.acessoButton.Location = new System.Drawing.Point(280, 138);
            this.acessoButton.Name = "acessoButton";
            this.acessoButton.Size = new System.Drawing.Size(59, 23);
            this.acessoButton.TabIndex = 4;
            this.acessoButton.Text = "Acessar";
            this.acessoButton.UseVisualStyleBackColor = true;
            this.acessoButton.Click += new System.EventHandler(this.acessar_Click);
            // 
            // contaLabel
            // 
            this.contaLabel.AutoSize = true;
            this.contaLabel.Location = new System.Drawing.Point(188, 93);
            this.contaLabel.Name = "contaLabel";
            this.contaLabel.Size = new System.Drawing.Size(35, 13);
            this.contaLabel.TabIndex = 5;
            this.contaLabel.Text = "Conta";
            // 
            // agenciaLabel
            // 
            this.agenciaLabel.AutoSize = true;
            this.agenciaLabel.Location = new System.Drawing.Point(237, 93);
            this.agenciaLabel.Name = "agenciaLabel";
            this.agenciaLabel.Size = new System.Drawing.Size(46, 13);
            this.agenciaLabel.TabIndex = 6;
            this.agenciaLabel.Text = "Agência";
            // 
            // digitoLabel
            // 
            this.digitoLabel.AutoSize = true;
            this.digitoLabel.Location = new System.Drawing.Point(309, 93);
            this.digitoLabel.Name = "digitoLabel";
            this.digitoLabel.Size = new System.Drawing.Size(36, 13);
            this.digitoLabel.TabIndex = 7;
            this.digitoLabel.Text = "Dígito";
            // 
            // LoginContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.digitoLabel);
            this.Controls.Add(this.agenciaLabel);
            this.Controls.Add(this.contaLabel);
            this.Controls.Add(this.acessoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contaTxtBox);
            this.Name = "LoginContaForm";
            this.Text = "Acesse a conta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contaTxtBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acessoButton;
        private System.Windows.Forms.Label contaLabel;
        private System.Windows.Forms.Label agenciaLabel;
        private System.Windows.Forms.Label digitoLabel;
    }
}

