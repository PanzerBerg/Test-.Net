namespace Conta_Corrente.UI
{
    partial class ContaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeLabelConta = new System.Windows.Forms.Label();
            this.cpfLabelConta = new System.Windows.Forms.Label();
            this.contaLabelConta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saldoLabelConta = new System.Windows.Forms.Label();
            this.transContaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dolarLabelConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conta: ";
            // 
            // nomeLabelConta
            // 
            this.nomeLabelConta.AutoSize = true;
            this.nomeLabelConta.Location = new System.Drawing.Point(60, 9);
            this.nomeLabelConta.Name = "nomeLabelConta";
            this.nomeLabelConta.Size = new System.Drawing.Size(35, 13);
            this.nomeLabelConta.TabIndex = 4;
            this.nomeLabelConta.Text = "label4";
            // 
            // cpfLabelConta
            // 
            this.cpfLabelConta.AutoSize = true;
            this.cpfLabelConta.Location = new System.Drawing.Point(60, 40);
            this.cpfLabelConta.Name = "cpfLabelConta";
            this.cpfLabelConta.Size = new System.Drawing.Size(35, 13);
            this.cpfLabelConta.TabIndex = 5;
            this.cpfLabelConta.Text = "label5";
            // 
            // contaLabelConta
            // 
            this.contaLabelConta.AutoSize = true;
            this.contaLabelConta.Location = new System.Drawing.Point(60, 64);
            this.contaLabelConta.Name = "contaLabelConta";
            this.contaLabelConta.Size = new System.Drawing.Size(35, 13);
            this.contaLabelConta.TabIndex = 6;
            this.contaLabelConta.Text = "label6";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 2);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo da conta: ";
            // 
            // saldoLabelConta
            // 
            this.saldoLabelConta.BackColor = System.Drawing.SystemColors.Control;
            this.saldoLabelConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoLabelConta.ForeColor = System.Drawing.Color.ForestGreen;
            this.saldoLabelConta.Location = new System.Drawing.Point(59, 138);
            this.saldoLabelConta.Name = "saldoLabelConta";
            this.saldoLabelConta.Size = new System.Drawing.Size(179, 22);
            this.saldoLabelConta.TabIndex = 10;
            this.saldoLabelConta.Text = "label6";
            // 
            // transContaButton
            // 
            this.transContaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.transContaButton.Location = new System.Drawing.Point(244, 109);
            this.transContaButton.Name = "transContaButton";
            this.transContaButton.Size = new System.Drawing.Size(108, 23);
            this.transContaButton.TabIndex = 11;
            this.transContaButton.Text = "Fazer transferencia";
            this.transContaButton.UseVisualStyleBackColor = true;
            this.transContaButton.Click += new System.EventHandler(this.transContaButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Comprar Dólar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Pagar conta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(244, 35);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Sair da conta";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dolarLabelConta
            // 
            this.dolarLabelConta.BackColor = System.Drawing.SystemColors.Control;
            this.dolarLabelConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarLabelConta.ForeColor = System.Drawing.Color.ForestGreen;
            this.dolarLabelConta.Location = new System.Drawing.Point(59, 167);
            this.dolarLabelConta.Name = "dolarLabelConta";
            this.dolarLabelConta.Size = new System.Drawing.Size(179, 22);
            this.dolarLabelConta.TabIndex = 10;
            this.dolarLabelConta.Text = "label6";
            // 
            // ContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transContaButton);
            this.Controls.Add(this.dolarLabelConta);
            this.Controls.Add(this.saldoLabelConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contaLabelConta);
            this.Controls.Add(this.cpfLabelConta);
            this.Controls.Add(this.nomeLabelConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ContaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContaForm";
            this.Load += new System.EventHandler(this.ContaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomeLabelConta;
        private System.Windows.Forms.Label cpfLabelConta;
        private System.Windows.Forms.Label contaLabelConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label saldoLabelConta;
        private System.Windows.Forms.Button transContaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dolarLabelConta;
    }
}