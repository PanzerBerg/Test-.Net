﻿using Conta_Corrente.entities;
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
    public partial class ContaForm : Form
    {
        public ContaForm()
        {
            InitializeComponent();
        }

        private void ContaForm_Load(object sender, EventArgs e)
        {
            nomeLabelConta.Text = ContaController.NomeString();
            cpfLabelConta.Text = ContaController.CpfString();
            contaLabelConta.Text = ContaController.ContaString();
            saldoLabelConta.Text = ContaController.SaldoString();
            dolarLabelConta.Text = ContaController.DolarSaldoString();
        }

        private void TrocaFormTrans()
        {
            Program.Context.MainForm = new TransferenciaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transContaButton_Click(object sender, EventArgs e)
        {
            TrocaFormTrans();
        }

    }
}
