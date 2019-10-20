namespace Conta_Corrente.UI
{
    partial class SenhaContaForm
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
            this.senhaTxtBox = new System.Windows.Forms.TextBox();
            this.validarSenhaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.contaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senhaTxtBox
            // 
            this.senhaTxtBox.Location = new System.Drawing.Point(217, 141);
            this.senhaTxtBox.MaxLength = 4;
            this.senhaTxtBox.Name = "senhaTxtBox";
            this.senhaTxtBox.PasswordChar = '*';
            this.senhaTxtBox.Size = new System.Drawing.Size(135, 20);
            this.senhaTxtBox.TabIndex = 0;
            // 
            // validarSenhaButton
            // 
            this.validarSenhaButton.Location = new System.Drawing.Point(276, 168);
            this.validarSenhaButton.Name = "validarSenhaButton";
            this.validarSenhaButton.Size = new System.Drawing.Size(75, 23);
            this.validarSenhaButton.TabIndex = 1;
            this.validarSenhaButton.Text = "Validar";
            this.validarSenhaButton.UseVisualStyleBackColor = true;
            this.validarSenhaButton.Click += new System.EventHandler(this.validarSenhaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conta: ";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(61, 13);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 5;
            this.nomeLabel.Text = "label4";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(61, 30);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(35, 13);
            this.cpfLabel.TabIndex = 6;
            this.cpfLabel.Text = "label5";
            // 
            // contaLabel
            // 
            this.contaLabel.AutoSize = true;
            this.contaLabel.Location = new System.Drawing.Point(61, 47);
            this.contaLabel.Name = "contaLabel";
            this.contaLabel.Size = new System.Drawing.Size(35, 13);
            this.contaLabel.TabIndex = 7;
            this.contaLabel.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha eletrônica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(143, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Antes de continuar, \r\nverifique se os dados\r\n estão corretos!";
            // 
            // SenhaContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contaLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validarSenhaButton);
            this.Controls.Add(this.senhaTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SenhaContaForm";
            this.Text = "SenhaContaForm";
            this.Load += new System.EventHandler(this.SenhaContaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senhaTxtBox;
        private System.Windows.Forms.Button validarSenhaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label contaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}