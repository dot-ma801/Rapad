using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Rapad
{
    public partial class Form1 : Form
    {
        private Point mousePoint;
        List<string> ListURLs = new List<string>();
        bool isClickingAlt = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.TopMost = true;
        }


        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Middle) == MouseButtons.Middle)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Middle) == MouseButtons.Middle)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            if (isClickingAlt)
            {
                this.Visible = false;
                Thread.Sleep(2000);
                this.Visible = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                isClickingAlt = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                isClickingAlt = false;
            }
        }
    }
}
