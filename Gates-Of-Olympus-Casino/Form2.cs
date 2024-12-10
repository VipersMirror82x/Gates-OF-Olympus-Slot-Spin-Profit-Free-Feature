using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace carbon.wtf_new_frontend

{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox3.Text;
            string password = guna2TextBox5.Text;

            if (username == "admin" && password == "admin")
            {
                Form1 ui = new Form1();
                ui.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Or Password Wrong!!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
