using Conta_Corrente.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void contaTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void acessar_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new SenhaContaForm();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
