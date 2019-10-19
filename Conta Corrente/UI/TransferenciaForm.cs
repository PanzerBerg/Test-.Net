using Conta_Corrente.entities;
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

        private void transButton_Click(object sender, EventArgs e)
        {

        }
    }
}
