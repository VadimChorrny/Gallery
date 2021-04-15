using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form3 : Form
    {
        public double size;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            size++;
            this.Opacity = size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size--;
            this.Opacity = size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
