using Conta_Corrente.entities;
using Conta_Corrente.entities.Db;
using Conta_Corrente.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Conta_Corrente.entities.Db.DbController;

namespace Conta_Corrente
{
    public partial class LoginContaForm : Form
    {
        

        public LoginContaForm()
        {
            InitializeComponent();
        }

        private void LoginContaForm_Load(object sender, EventArgs e)
        {

        }

        private void numberCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TrocarForm()
        {
            Program.Context.MainForm = new SenhaContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private bool PuxarDados()
        {
            DbController dbController = new DbController();
            List <Clientes> list = new List<Clientes>();
            list = dbController.Consultar();

            foreach(Clientes c in list)
            {
                if (c.Conta == int.Parse(contaTxtBox.Text) && c.Agencia == int.Parse(agenciaTxtBox.Text) && c.Digito == int.Parse(digitoTxtBox.Text))
                {
                    ContaController.RecebeDados(c.Id, c.Nome, c.Cpf, c.Saldo);
                    ContaController.PassaDados(c.Conta, c.Agencia, c.Digito);
                    return true;
                }
            }
            return false;
        }

        private void Alert(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);

        }

        private void acessar_Click(object sender, EventArgs e)
        {
            if(contaTxtBox.Text.Length > 3 && agenciaTxtBox.Text.Length > 5 && digitoTxtBox.Text.Length > 0)
            {
                if (PuxarDados())
                {
                    TrocarForm();
                } else
                {
                    string message = "Conta / Agencia / Dígito não encontrados";
                    string caption = "Nenhuma conta encontrada";
                    Alert(message, caption);
                }

            } else
            {
                string message = "Conta, Agencia ou Dígito incompletos.";
                string caption = "Não é possivel acessar.";
                Alert(message, caption);
            };



        }

    }
}
