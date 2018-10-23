using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private object reportViewer1;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int[] iArray = new int[] { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value, (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value, (int)numericUpDown10.Value };
            int i = iArray.Max();
            int d = iArray.Min();
            MessageBox.Show("MAX: "+i.ToString()+ " MIN: "+d.ToString());
        }

    }
}
