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

        //connect to the application by pressing the enter key -- actually trigger the connectButtonClick method
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("enter key pressed"); used to see if it gets into the if clause
                connectButton_Click(this, new EventArgs());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
