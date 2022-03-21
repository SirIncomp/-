using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count1 = 0;
            int count0 = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '0')
                    count0++;
                else if(str[i] == '1')
                    count1++;
                i++;
            }
            label1.Text = "кол-во нулей = " + count0.ToString();
            label2.Text = "кол-во единиц = " +count1.ToString();

        }
    }
    }

