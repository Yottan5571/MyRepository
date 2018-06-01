using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomPanel panel1 = new CustomPanel();
            panel1.Location = new Point(50, 50);
            panel1.Width = 400;
            panel1.Height = 300;
            panel1.BackColor = Color.LightGray;
            panel1.Visible = true;

            this.Controls.Add(panel1);

            CustomLabel lbl1 = new CustomLabel();
            lbl1.Width = 100;
            lbl1.Height = 100;
            lbl1.BackColor = Color.Blue;
            lbl1.Location = new Point(0, 0);

            CustomLabel lbl2 = new CustomLabel();
            lbl2.Width = 300;
            lbl2.Height = 100;
            lbl2.BackColor = Color.Yellow;
            lbl2.Location = new Point(100, 0);

            
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(lbl2);

            button1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            
            button1.Visible = true;
            button1.BringToFront();
            button1.Update();

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
