using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Conta_Corrente.entities;
using Conta_Corrente.entities.Db;
using static Conta_Corrente.entities.Db.DbController;

namespace Conta_Corrente.UI
{
    public partial class SenhaContaForm : Form
    {
        public SenhaContaForm()
        {
            InitializeComponent();
        }

        private void SenhaContaForm_Load(object sender, EventArgs e)
        {
            contaLabel.Text = ContaController.ContaString();
            nomeLabel.Text = ContaController.NomeString();
            cpfLabel.Text = ContaController.CpfString();
        }

        private bool PuxarDadosSenha()
        {
            DbController dbController = new DbController();
            List<Clientes_Senhas> list = new List<Clientes_Senhas>();
            list = dbController.ConsultarSenha();

            foreach (Clientes_Senhas c in list)
            {
                if (c.Cpf == ContaController.CpfString())
                {
                    SenhaController.RecebeDados(c.Id, c.Cpf, c.Senha);
                    return true;
                }
            }
            return false;
        }

        private bool ChecarSenha()
        {
            if (int.Parse(senhaTxtBox.Text) == SenhaController.GetSenha())
            {
                return true;
            }
            
            return false;
        }

        private void TrocarForm()
        {
            Program.Context.MainForm = new ContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Alert(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }


        private void validarSenhaButton_Click(object sender, EventArgs e)
        {
            if(senhaTxtBox.Text.Length > 3)
            {
                if (PuxarDadosSenha() && ChecarSenha())
                {
                    TrocarForm();
                } else
                {
                    string message = "Senha Incorreta, favor chegar se a conta pertence ao seu CPF";
                    string caption = "Senha Incorreta";
                    Alert(message, caption);
                }
            }
        }
    }
}
