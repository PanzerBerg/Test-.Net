using Conta_Corrente.entities;
using Conta_Corrente.entities.Db;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Conta_Corrente.entities.Db.DbController;

namespace Conta_Corrente.UI
{
    public partial class NovaContaForm : Form
    {
        public NovaContaForm()
        {
            InitializeComponent();
        }

        private void NovaContaForm_Load(object sender, EventArgs e)
        {

        }

        private void Alert(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new LoginContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private bool CheckVazio()
        {
            if (nomeCadastro.TextLength <= 0 || maskedTextBox1.Text.Length <= 0 || cpfCadastro.Text.Length < 14)
            {
                return false;
            }
            if (endTxtBox.TextLength <= 0 || bairroTxtBox.TextLength <= 0 || senhaTxtBox.Text.Length < 4)
            {
                return false;
            }
            return true;
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void TrocarForm()
        {
            Program.Context.MainForm = new ContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private bool PuxarDados(int conta, int agencia, int digito)
        {
            DbController dbController = new DbController();
            List<Clientes> list = new List<Clientes>();
            list = dbController.Consultar();

            foreach (Clientes c in list)
            {
                if (c.Conta == conta && c.Agencia == agencia && c.Digito == digito)
                {
                    ContaController.RecebeDados(c.Id, c.Nome, c.Cpf, c.Saldo, c.Saldo_Dolar);
                    ContaController.PassaDados(c.Conta, c.Agencia, c.Digito);
                    return true;
                }
            }
            return false;
        }

        private void AlertReturn(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                if (PuxarDados(ContaController.GetConta(), ContaController.GetAgencia(), ContaController.GetDigito()))
                {
                    TrocarForm();
                }
            }

        }

        private void CriarConta()
        {
            int conta = RandomNumber(1111, 9999);
            int agencia = RandomNumber(111111, 999999);
            int digito = RandomNumber(1, 9);
            float saldo = 0;

            ContaController.PassaDados(conta, agencia, digito);

            DbController dbController = new DbController();
            dbController.Inserir(5, nomeCadastro.Text, cpfCadastro.Text, conta, agencia, digito, saldo, saldo);
            dbController.InserirSenhas(cpfCadastro.Text, int.Parse(senhaTxtBox.Text));

            string message = "Sua conta foi criada e seus dados são:\n Conta: " + conta + " Agencia: " + agencia + " - " + digito;
            string caption = "Conta criada";
            AlertReturn(message, caption);
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            if (CheckVazio())
            {
                CriarConta();
            }
            else
            {
                string message = "Campos incompletos, favor verificar.";
                string caption = "Campos incompletos";
                Alert(message, caption);
            }
        }

    }
}
