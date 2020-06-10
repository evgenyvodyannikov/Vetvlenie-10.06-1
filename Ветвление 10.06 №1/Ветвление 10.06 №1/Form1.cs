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
            try
            {
                checkedListBox1.SelectedItems.Clear();
                int k = Int32.Parse(textBox1.Text);
                for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                {
                    if (radioButton2.Checked)
                    {
                        if (Convert.ToInt32(checkedListBox1.Items[i]) == k)
                            checkedListBox1.SelectedIndex = i;
                    }
                    if (radioButton1.Checked)
                    {
                        if (i == k)
                            checkedListBox1.SelectedIndex = i;
                    }
                    if (radioButton3.Checked)
                    {
                        string s = checkedListBox1.Items[i].ToString();
                        string kk = k.ToString();
                        for (int l = 0; l < s.Length; l++)
                        {
                            if (s[l] == kk[l])
                                checkedListBox1.SelectedIndex = i;
                        }
                    }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны целое число k (1<k<252) и последовательность цифр 505152...9899100101...149150, в которой выписаны подряд все натуральные числа от 50 до 250. Определить k-ю цифру.", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
