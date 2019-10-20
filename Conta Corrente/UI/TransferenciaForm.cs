using Conta_Corrente.entities;
using Conta_Corrente.entities.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Conta_Corrente.entities.Db.DbController;

namespace Conta_Corrente.UI
{
    public partial class TransferenciaForm : Form
    {
        public TransferenciaForm()
        {
            InitializeComponent();
        }

        private void TransferenciaForm_Load(object sender, EventArgs e)
        {
            saldoLabelTrans.Text = ContaController.SaldoString();
        }

        private bool PuxarDados()
        {
            DbController dbController = new DbController();
            List<Clientes> list = new List<Clientes>();
            list = dbController.Consultar();

            foreach (Clientes c in list)
            {
                if (c.Conta == int.Parse(contaTxtBoxTrans.Text) && c.Agencia == int.Parse(agenciaTxtBoxTrans.Text) && c.Digito == int.Parse(digitoTxtBoxTrans.Text))
                {
                    TransferController.RecebeDados(c.Id, c.Conta, c.Agencia, c.Digito, c.Nome, c.Cpf, c.Saldo, c.Saldo_Dolar);
                    return true;
                }
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

        private void AlertReturn(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                TrocarForm();
            }

        }

        private void Transacao()
        {
            DbController dbController = new DbController();

            TransferController.TransferFirst(float.Parse(transTxtBox.Text));

            ContaController.AtualizarDb(dbController);
            TransferController.AtualizarDb(dbController);

            string sucesso = "O valor de R$" + transTxtBox.Text + " foi transferido com sucesso para " + TransferController.GetNome();
            string caption = "Transferencia concluida com sucesso";
            AlertReturn(sucesso, caption);
        }

        private void transButton_Click(object sender, EventArgs e)
        {
            if (PuxarDados())
            {
                if (transTxtBox.TextLength > 0) {
                    if (float.Parse(transTxtBox.Text) > ContaController.GetSaldo())
                    {
                        string message = "Saldo insuficiente para completar a transação. Retornando a conta.";
                        string caption = "Saldo insuficiente";
                        AlertReturn(message, caption);
                    } else
                    {
                        Transacao();
                    }
                }
                else
                {
                    string message = "Por favor, preencha todos os campos";
                    string caption = "Campos vazios";
                    Alert(message, caption);
                }
            }
            else
            {
                string message = "Conta inexistente, tente novamente";
                string caption = "Conta inexistente";
                Alert(message, caption);
            }
        }
    }
}
