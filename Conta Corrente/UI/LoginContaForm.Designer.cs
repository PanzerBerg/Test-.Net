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
            this.agenciaTxtBox = new System.Windows.Forms.TextBox();
            this.digitoTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acessoButton = new System.Windows.Forms.Button();
            this.contaLabel = new System.Windows.Forms.Label();
            this.agenciaLabel = new System.Windows.Forms.Label();
            this.digitoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.novaContaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.divLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contaTxtBox
            // 
            this.contaTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.contaTxtBox.Location = new System.Drawing.Point(200, 45);
            this.contaTxtBox.MaxLength = 4;
            this.contaTxtBox.Name = "contaTxtBox";
            this.contaTxtBox.Size = new System.Drawing.Size(43, 20);
            this.contaTxtBox.TabIndex = 0;
            this.contaTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberCheck_KeyPress);
            // 
            // agenciaTxtBox
            // 
            this.agenciaTxtBox.Location = new System.Drawing.Point(249, 45);
            this.agenciaTxtBox.MaxLength = 6;
            this.agenciaTxtBox.Name = "agenciaTxtBox";
            this.agenciaTxtBox.Size = new System.Drawing.Size(50, 20);
            this.agenciaTxtBox.TabIndex = 1;
            // 
            // digitoTxtBox
            // 
            this.digitoTxtBox.Location = new System.Drawing.Point(321, 45);
            this.digitoTxtBox.MaxLength = 1;
            this.digitoTxtBox.Name = "digitoTxtBox";
            this.digitoTxtBox.Size = new System.Drawing.Size(27, 20);
            this.digitoTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // acessoButton
            // 
            this.acessoButton.Location = new System.Drawing.Point(289, 71);
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
            this.contaLabel.Location = new System.Drawing.Point(197, 26);
            this.contaLabel.Name = "contaLabel";
            this.contaLabel.Size = new System.Drawing.Size(35, 13);
            this.contaLabel.TabIndex = 5;
            this.contaLabel.Text = "Conta";
            // 
            // agenciaLabel
            // 
            this.agenciaLabel.AutoSize = true;
            this.agenciaLabel.Location = new System.Drawing.Point(246, 26);
            this.agenciaLabel.Name = "agenciaLabel";
            this.agenciaLabel.Size = new System.Drawing.Size(46, 13);
            this.agenciaLabel.TabIndex = 6;
            this.agenciaLabel.Text = "Agência";
            // 
            // digitoLabel
            // 
            this.digitoLabel.AutoSize = true;
            this.digitoLabel.Location = new System.Drawing.Point(318, 26);
            this.digitoLabel.Name = "digitoLabel";
            this.digitoLabel.Size = new System.Drawing.Size(36, 13);
            this.digitoLabel.TabIndex = 7;
            this.digitoLabel.Text = "Dígito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seja bem vindo de volta!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insira os dados da\r\nsua conta:";
            // 
            // novaContaButton
            // 
            this.novaContaButton.Location = new System.Drawing.Point(246, 154);
            this.novaContaButton.Name = "novaContaButton";
            this.novaContaButton.Size = new System.Drawing.Size(102, 23);
            this.novaContaButton.TabIndex = 10;
            this.novaContaButton.Text = "Abrir nova conta";
            this.novaContaButton.UseVisualStyleBackColor = true;
            this.novaContaButton.Click += new System.EventHandler(this.novaContaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Novo por aqui?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Abra sua conta agora!";
            // 
            // divLabel
            // 
            this.divLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divLabel.Location = new System.Drawing.Point(-1, 115);
            this.divLabel.Name = "divLabel";
            this.divLabel.Size = new System.Drawing.Size(368, 2);
            this.divLabel.TabIndex = 13;
            // 
            // LoginContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 207);
            this.Controls.Add(this.divLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.novaContaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.digitoLabel);
            this.Controls.Add(this.agenciaLabel);
            this.Controls.Add(this.contaLabel);
            this.Controls.Add(this.acessoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digitoTxtBox);
            this.Controls.Add(this.agenciaTxtBox);
            this.Controls.Add(this.contaTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginContaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesse a conta";
            this.Load += new System.EventHandler(this.LoginContaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contaTxtBox;
        private System.Windows.Forms.TextBox agenciaTxtBox;
        private System.Windows.Forms.TextBox digitoTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acessoButton;
        private System.Windows.Forms.Label contaLabel;
        private System.Windows.Forms.Label agenciaLabel;
        private System.Windows.Forms.Label digitoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button novaContaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label divLabel;
    }
}

