namespace Conta_Corrente.UI
{
    partial class NovaContaForm
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
            this.nomeCadastro = new System.Windows.Forms.TextBox();
            this.cpfCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.divLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endTxtBox = new System.Windows.Forms.TextBox();
            this.bairroTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.enviarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.senhaTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira seus dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cpf:";
            // 
            // nomeCadastro
            // 
            this.nomeCadastro.Location = new System.Drawing.Point(69, 34);
            this.nomeCadastro.Name = "nomeCadastro";
            this.nomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.nomeCadastro.TabIndex = 1;
            // 
            // cpfCadastro
            // 
            this.cpfCadastro.Location = new System.Drawing.Point(69, 60);
            this.cpfCadastro.Mask = "999.999.999-99";
            this.cpfCadastro.Name = "cpfCadastro";
            this.cpfCadastro.Size = new System.Drawing.Size(100, 20);
            this.cpfCadastro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sexo:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(233, 34);
            this.maskedTextBox1.Mask = "(99) 99999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(119, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(215, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(294, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins "});
            this.comboBox1.Location = new System.Drawing.Point(233, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // divLabel
            // 
            this.divLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divLabel.Location = new System.Drawing.Point(-7, 98);
            this.divLabel.Name = "divLabel";
            this.divLabel.Size = new System.Drawing.Size(379, 3);
            this.divLabel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Estado:";
            // 
            // endTxtBox
            // 
            this.endTxtBox.Location = new System.Drawing.Point(69, 110);
            this.endTxtBox.Name = "endTxtBox";
            this.endTxtBox.Size = new System.Drawing.Size(100, 20);
            this.endTxtBox.TabIndex = 4;
            // 
            // bairroTxtBox
            // 
            this.bairroTxtBox.Location = new System.Drawing.Point(69, 136);
            this.bairroTxtBox.Name = "bairroTxtBox";
            this.bairroTxtBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTxtBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-7, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(379, 3);
            this.label9.TabIndex = 14;
            // 
            // enviarButton
            // 
            this.enviarButton.Location = new System.Drawing.Point(262, 176);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(90, 23);
            this.enviarButton.TabIndex = 15;
            this.enviarButton.Text = "Enviar dados";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(69, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Senha:";
            // 
            // senhaTxtBox
            // 
            this.senhaTxtBox.Location = new System.Drawing.Point(233, 136);
            this.senhaTxtBox.Mask = "9999";
            this.senhaTxtBox.Name = "senhaTxtBox";
            this.senhaTxtBox.PasswordChar = '*';
            this.senhaTxtBox.Size = new System.Drawing.Size(119, 20);
            this.senhaTxtBox.TabIndex = 7;
            // 
            // NovaContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 211);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.divLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.senhaTxtBox);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.cpfCadastro);
            this.Controls.Add(this.bairroTxtBox);
            this.Controls.Add(this.endTxtBox);
            this.Controls.Add(this.nomeCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NovaContaForm";
            this.Text = "NovaContaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeCadastro;
        private System.Windows.Forms.MaskedTextBox cpfCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label divLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox endTxtBox;
        private System.Windows.Forms.TextBox bairroTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button enviarButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox senhaTxtBox;
    }
}