using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChat
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if ((usernameTextBox.Text == "kordonis" && passwordTextBox.Text == "123456" ) || (usernameTextBox.Text == "vasileiou" && passwordTextBox.Text == "123456"))
            {
                this.Hide();
                Form f1 = new GeekChat();
                f1.ShowDialog(); // Shows Form2
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
