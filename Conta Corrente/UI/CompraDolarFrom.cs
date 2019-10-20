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

namespace Conta_Corrente.UI
{
    public partial class CompraDolarFrom : Form
    {
        public CompraDolarFrom()
        {
            InitializeComponent();
        }

        private void CompraDolarFrom_Load(object sender, EventArgs e)
        {
            cotacaoLabelDolar.Text = DolarCotacao.PrecoString();
            saldoLabelDolar.Text = ContaController.SaldoString();
            saldoDLabelDolar.Text = ContaController.DolarSaldoString();
        }

        private void TrocarForm()
        {
            Program.Context.MainForm = new ContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void cancelButtonDolar_Click(object sender, EventArgs e)
        {
            TrocarForm();
        }

        private void Alert(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        private void AlertReturn(float valor, float saldo)
        {
            string message = "Sua compra de $ " + valor.ToString("0.00") + " foi concluida com sucesso.\n Seu saldo atual é de R$ " + saldo.ToString("0.00");
            string caption = "Transação concluida";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                TrocarForm();
            }
        }

        private void ValidarReal()
        {
            if (ContaController.GetSaldo() < float.Parse(valorRealDolar.Text))
            {
                string message = "Saldo insuficiente para completar a operação.";
                string caption = "Saldo insuficiente";
                Alert(message, caption);
            }
            else
            {
                 
                float valor = float.Parse(valorRealDolar.Text);
                float dolar = DolarCotacao.GetPreco();
                float saldo = ContaController.GetSaldo();
                float saldo_dolar = ContaController.GetDolar();

                valor /= dolar;
                saldo -= valor;
                saldo_dolar += valor;

                ContaController.SaldoAtualizado(saldo);
                ContaController.SaldoDolAtualizado(saldo_dolar);

                DbController dbController = new DbController();
                ContaController.AtualizarDb(dbController);

                AlertReturn(valor, saldo);
            }
        }

        private void ValidarDol()
        {
            float valor = float.Parse(valorDolDolar.Text);
            float dolar = DolarCotacao.GetPreco();
            float gasto = valor * dolar;
            float saldo = ContaController.GetSaldo();
            float saldo_dolar = ContaController.GetDolar();
            
            if (saldo < gasto)
            {
                
            } else
            {
                saldo -= gasto;
                valor += saldo_dolar;

                ContaController.SaldoAtualizado(saldo);
                ContaController.SaldoDolAtualizado(valor);

                DbController dbController = new DbController();
                ContaController.AtualizarDb(dbController);

                string message = "Sua compra de $ " + valor.ToString("0.00") + " foi concluida com sucesso.\n Seu saldo atual é de R$ " + saldo.ToString("0.00");
                string caption = "Transação concluida";
                AlertReturn(valor, saldo);
            }
        }

        private bool CheckBoxes()
        {
            if (valorRealDolar.TextLength > 0 && valorDolDolar.TextLength > 0)
            {
                return false;
            } else if (valorRealDolar.TextLength > 0 && valorDolDolar.TextLength == 0)
            {
                return true;
            } else if (valorRealDolar.TextLength == 0 && valorDolDolar.TextLength > 0)
            {
                return true;
            }
            return false;
        }

        private void finalButtonDolar_Click(object sender, EventArgs e)
        {
            if (CheckBoxes())
            {
                if (valorRealDolar.TextLength > 0)
                {
                    ValidarReal();
                }
                else
                {
                    ValidarDol();
                }
            } else
            {
                string message = "Favor verificar os campos. Apenas um deve estar preenchido";
                string caption = "Erro ao validar";
                Alert(message, caption);
            }
        }
    }
}
