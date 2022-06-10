using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show2();
        }

        private void Show1()
        {
            //System.Threading.Thread.Sleep(5000);
            label1.Text = label1.Text + "/n " + DateTime.Now.ToString();
        }
        private void Show2()
        {
            //label1.Text = label1.Text + "/n " + DateTime.Now.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            System.Threading.Thread thread = new System.Threading.Thread(Show1);
            thread.Start();


        }
    }
}
