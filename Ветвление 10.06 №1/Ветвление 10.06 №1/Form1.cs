using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ветвление_10._06__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            for(int i = 50; i <= 250; i++)
            {
                checkedListBox1.Items.Add(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int k = Int32.Parse(textBox1.Text);
            for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
            {
                if (Convert.ToInt32(checkedListBox1.Items[i]) == k)
                    checkedListBox1.SelectedIndex = i;
            }
        }
    }
}
