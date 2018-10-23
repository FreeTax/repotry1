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
        //global Var 
        int[] iArray;

        public Form1()
        {
            InitializeComponent();
        }//costructor
        private void button1_Click_1(object sender, EventArgs e)
        {
            getter();
            int i = iArray.Max();
            int d = iArray.Min();
            MessageBox.Show("MAX: "+i.ToString()+ " MIN: "+d.ToString());
        }//find Max and Min datas
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                getter();
                Array.Sort(iArray);
                setter();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }//array sorting 
        private void getter()
        {
            iArray = new int[] { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value, (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value, (int)numericUpDown10.Value };
        }//take data to NumericUpDown
        private void setter()
        {
            numericUpDown1.Value = iArray[0];
            numericUpDown2.Value = iArray[1];
            numericUpDown3.Value = iArray[2];
            numericUpDown4.Value = iArray[3];
            numericUpDown5.Value = iArray[4];
            numericUpDown6.Value = iArray[5];
            numericUpDown7.Value = iArray[6];
            numericUpDown8.Value = iArray[7];
            numericUpDown9.Value = iArray[8];
            numericUpDown10.Value = iArray[9];
        }//insert data into NumericUpDown
    }
}
