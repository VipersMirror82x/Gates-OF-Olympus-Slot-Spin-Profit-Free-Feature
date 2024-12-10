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
using Guna.UI2.WinForms;


namespace carbon.wtf_new_frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Show();
            guna2GradientPanel3.Hide();
            panel2.Hide();
            panel3.Hide();
            panel8.Show();
            panel6.Show();
            panel12.Hide();
            panel10.Hide();
        }
        private void guna2button1_Click(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Hallo");
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            guna2GradientPanel2.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel8.Show();
            panel6.Show();
            panel12.Hide();
            panel10.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Hide();
            guna2GradientPanel3.Hide();
            guna2GradientPanel2.Show();
            panel2.Show();
            panel3.Show();
            panel8.Hide();
            panel6.Hide();
            panel12.Hide();
            panel10.Hide();
        }

        private void Profilebutton_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Hide();
            guna2GradientPanel2.Hide();
            guna2GradientPanel3.Show();
            panel2.Hide();
            panel3.Hide();
            panel8.Hide();
            panel6.Hide();
            panel12.Show();
            panel10.Show();
        }
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 7;
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 16, FontStyle.Bold);
            richTextBox1.AppendText("WORKING");
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText("try:\n");
            richTextBox1.AppendText("    print t.bold_green + \"Checking if up-to-date || ctr + c to cancel\" + t.normal\n");
            richTextBox1.AppendText("    gitrev = subprocess.check_output(['git', 'rev-parse', 'HEAD']).rstrip()\n");
            richTextBox1.AppendText("    gitlsremote = subprocess.check_output(['git', 'ls-remote', 'origin', 'master']).split()[0]\n");
            richTextBox1.AppendText("    if gitrev != gitlsremote:\n");
            richTextBox1.AppendText("        updateornah = raw_input(t.bold_red + \"Do you want to update WinPayloads? y/[n]: \" + t.normal)\n");
            richTextBox1.AppendText("        if updateornah.lower() == \"y\":\n");
            richTextBox1.AppendText("            p = subprocess.Popen(['git','pull'])\n");
            richTextBox1.AppendText("            p.wait()\n");
            richTextBox1.AppendText("            print t.bold_yellow + \"Reload Winpayloads...\" + t.normal\n");
            richTextBox1.AppendText("            sys.exit()\n");
            richTextBox1.AppendText("except subprocess.CalledProcessError:\n");
            richTextBox1.AppendText("    print  t.bold_red + \"[!] No Connection to Github\" + t.normal\n");
            richTextBox1.AppendText("except KeyboardInterrupt:\n");
            richTextBox1.AppendText("    pass\n\n");

            richTextBox1.AppendText("from lib.listener import StartAsync\n");
            richTextBox1.AppendText("async = StartAsync()\n");
            richTextBox1.AppendText("async.start()\n\n");

            richTextBox1.AppendText("try:\n");
            richTextBox1.AppendText("    getAndRunMainMenu()\n");
            richTextBox1.AppendText("except KeyboardInterrupt:\n");
            richTextBox1.AppendText("    print t.bold_green + '\\n[*] Cleaning Up\\n' + t.normal\n");
            richTextBox1.AppendText("    subprocess.call(['rm *.rc'], shell=True,\n");
            richTextBox1.AppendText("                    stdout=subprocess.PIPE, stderr=subprocess.PIPE)\n");
            richTextBox1.AppendText("    subprocess.call(['rm *.ps1'], shell=True,\n");
            richTextBox1.AppendText("                    stdout=subprocess.PIPE, stderr=subprocess.PIPE)\n");
            richTextBox1.AppendText("    subprocess.call(['rm logdict*'], shell=True,\n");
            richTextBox1.AppendText("                    stdout=subprocess.PIPE, stderr=subprocess.PIPE)\n");
            richTextBox1.AppendText("    sys.exit()\n\n");

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving, Please Wait", "Alert!!", MessageBoxButtons.OK);
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }
    }
}
