using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportImportDotNetTray.OtherForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public Boolean Validation = false;
        private void PasswordValidation(String WrittenPassword)
        {
            if (WrittenPassword == "GPIB") this.Validation = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            this.btn_ENTER_Click(new object(), new EventArgs());
        }

        private void btn_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ENTER_Click(object sender, EventArgs e)
        {
            this.PasswordValidation(this.textBox1.Text);
            if (this.Validation) this.Close();
            else
            {
                this.textBox1.SelectAll();
                this.textBox1.Focus();
            }
        }
    }
}
