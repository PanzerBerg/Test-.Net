namespace Conta_Corrente.UI
{
    partial class TransferenciaForm
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
            this.digitoLabel = new System.Windows.Forms.Label();
            this.agenciaLabel = new System.Windows.Forms.Label();
            this.contaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.digitoTxtBoxTrans = new System.Windows.Forms.TextBox();
            this.agenciaTxtBoxTrans = new System.Windows.Forms.TextBox();
            this.contaTxtBoxTrans = new System.Windows.Forms.TextBox();
            this.transButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saldoLabelTrans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.saldoDolLabel = new System.Windows.Forms.Label();
            this.realRadio = new System.Windows.Forms.RadioButton();
            this.dolRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // digitoLabel
            // 
            this.digitoLabel.AutoSize = true;
            this.digitoLabel.Location = new System.Drawing.Point(137, 119);
            this.digitoLabel.Name = "digitoLabel";
            this.digitoLabel.Size = new System.Drawing.Size(36, 13);
            this.digitoLabel.TabIndex = 14;
            this.digitoLabel.Text = "Dígito";
            // 
            // agenciaLabel
            // 
            this.agenciaLabel.AutoSize = true;
            this.agenciaLabel.Location = new System.Drawing.Point(65, 119);
            this.agenciaLabel.Name = "agenciaLabel";
            this.agenciaLabel.Size = new System.Drawing.Size(46, 13);
            this.agenciaLabel.TabIndex = 13;
            this.agenciaLabel.Text = "Agência";
            // 
            // contaLabel
            // 
            this.contaLabel.AutoSize = true;
            this.contaLabel.Location = new System.Drawing.Point(17, 119);
            this.contaLabel.Name = "contaLabel";
            this.contaLabel.Size = new System.Drawing.Size(35, 13);
            this.contaLabel.TabIndex = 12;
            this.contaLabel.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // digitoTxtBoxTrans
            // 
            this.digitoTxtBoxTrans.Location = new System.Drawing.Point(140, 138);
            this.digitoTxtBoxTrans.MaxLength = 1;
            this.digitoTxtBoxTrans.Name = "digitoTxtBoxTrans";
            this.digitoTxtBoxTrans.Size = new System.Drawing.Size(27, 20);
            this.digitoTxtBoxTrans.TabIndex = 10;
            // 
            // agenciaTxtBoxTrans
            // 
            this.agenciaTxtBoxTrans.Location = new System.Drawing.Point(68, 138);
            this.agenciaTxtBoxTrans.MaxLength = 6;
            this.agenciaTxtBoxTrans.Name = "agenciaTxtBoxTrans";
            this.agenciaTxtBoxTrans.Size = new System.Drawing.Size(50, 20);
            this.agenciaTxtBoxTrans.TabIndex = 9;
            // 
            // contaTxtBoxTrans
            // 
            this.contaTxtBoxTrans.BackColor = System.Drawing.SystemColors.Window;
            this.contaTxtBoxTrans.Location = new System.Drawing.Point(17, 138);
            this.contaTxtBoxTrans.MaxLength = 4;
            this.contaTxtBoxTrans.Name = "contaTxtBoxTrans";
            this.contaTxtBoxTrans.Size = new System.Drawing.Size(43, 20);
            this.contaTxtBoxTrans.TabIndex = 8;
            // 
            // transButton
            // 
            this.transButton.Location = new System.Drawing.Point(277, 164);
            this.transButton.Name = "transButton";
            this.transButton.Size = new System.Drawing.Size(75, 23);
            this.transButton.TabIndex = 16;
            this.transButton.Text = "Transferir";
            this.transButton.UseVisualStyleBackColor = true;
            this.transButton.Click += new System.EventHandler(this.transButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor da transferencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Saldo em conta:";
            // 
            // saldoLabelTrans
            // 
            this.saldoLabelTrans.BackColor = System.Drawing.SystemColors.Control;
            this.saldoLabelTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoLabelTrans.ForeColor = System.Drawing.Color.ForestGreen;
            this.saldoLabelTrans.Location = new System.Drawing.Point(13, 49);
            this.saldoLabelTrans.Name = "saldoLabelTrans";
            this.saldoLabelTrans.Size = new System.Drawing.Size(133, 22);
            this.saldoLabelTrans.TabIndex = 19;
            this.saldoLabelTrans.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Insira a conta que deseja transferir:";
            // 
            // transTxtBox
            // 
            this.transTxtBox.Location = new System.Drawing.Point(228, 138);
            this.transTxtBox.Name = "transTxtBox";
            this.transTxtBox.Size = new System.Drawing.Size(124, 20);
            this.transTxtBox.TabIndex = 21;
            // 
            // saldoDolLabel
            // 
            this.saldoDolLabel.BackColor = System.Drawing.SystemColors.Control;
            this.saldoDolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoDolLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.saldoDolLabel.Location = new System.Drawing.Point(204, 49);
            this.saldoDolLabel.Name = "saldoDolLabel";
            this.saldoDolLabel.Size = new System.Drawing.Size(133, 22);
            this.saldoDolLabel.TabIndex = 19;
            this.saldoDolLabel.Text = "label6";
            // 
            // realRadio
            // 
            this.realRadio.AutoSize = true;
            this.realRadio.Checked = true;
            this.realRadio.Location = new System.Drawing.Point(17, 167);
            this.realRadio.Name = "realRadio";
            this.realRadio.Size = new System.Drawing.Size(39, 17);
            this.realRadio.TabIndex = 22;
            this.realRadio.TabStop = true;
            this.realRadio.Text = "R$";
            this.realRadio.UseVisualStyleBackColor = true;
            // 
            // dolRadio
            // 
            this.dolRadio.AutoSize = true;
            this.dolRadio.Location = new System.Drawing.Point(62, 167);
            this.dolRadio.Name = "dolRadio";
            this.dolRadio.Size = new System.Drawing.Size(31, 17);
            this.dolRadio.TabIndex = 22;
            this.dolRadio.Text = "$";
            this.dolRadio.UseVisualStyleBackColor = true;
            // 
            // TransferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.dolRadio);
            this.Controls.Add(this.realRadio);
            this.Controls.Add(this.transTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldoDolLabel);
            this.Controls.Add(this.saldoLabelTrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transButton);
            this.Controls.Add(this.digitoLabel);
            this.Controls.Add(this.agenciaLabel);
            this.Controls.Add(this.contaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digitoTxtBoxTrans);
            this.Controls.Add(this.agenciaTxtBoxTrans);
            this.Controls.Add(this.contaTxtBoxTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TransferenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferenciaForm";
            this.Load += new System.EventHandler(this.TransferenciaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label digitoLabel;
        private System.Windows.Forms.Label agenciaLabel;
        private System.Windows.Forms.Label contaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox digitoTxtBoxTrans;
        private System.Windows.Forms.TextBox agenciaTxtBoxTrans;
        private System.Windows.Forms.TextBox contaTxtBoxTrans;
        private System.Windows.Forms.Button transButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label saldoLabelTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox transTxtBox;
        private System.Windows.Forms.Label saldoDolLabel;
        private System.Windows.Forms.RadioButton realRadio;
        private System.Windows.Forms.RadioButton dolRadio;
    }
}