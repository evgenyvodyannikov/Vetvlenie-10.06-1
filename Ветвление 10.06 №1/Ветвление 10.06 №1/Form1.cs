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
            button2.Enabled = false;
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                checkedListBox1.SelectedItems.Clear();
                int k = Int32.Parse(textBox1.Text);
                for (int i = 0; i <= checkedListBox1.Items.Count - 1; i++)
                {
                    if (rb2.Checked)
                    {
                        if (Convert.ToInt32(checkedListBox1.Items[i]) == k)
                            checkedListBox1.SelectedIndex = i;
                        if (k > 250) textBox1.Text = "250";
                    }
                    if (rb1.Checked)
                    {
                        if (i == k)
                            checkedListBox1.SelectedIndex = i;
                        if (k > 200) textBox1.Text = "200";
                    }
                    if (rb3.Checked)
                    {
                        string s = checkedListBox1.Items[i].ToString();
                        string kk = k.ToString();
                        for (int l = 0; l < s.Length; l++)
                        {
                            for (int j = 0; j < kk.Length; j++)
                            {
                                if (s[l] == kk[j])
                                    checkedListBox1.SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
            catch {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны целое число k (1<k<252) и последовательность цифр 505152...9899100101...149150, в которой выписаны подряд все натуральные числа от 50 до 250. Определить k-ю цифру.\nЗадание я понял не до конца, поэтому добавил несколько режимов работы.\nПри выборе поиска по цифре, будут искаться элементы в которых данная цифра присутствует. Так же можно записывать несколько цифр для поиска.", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Name)
            {
                case "rb1":
                    {
                        textBox1.MaxLength = 3;
                        textBox1.Text = "";
                    }
                    break;
                case "rb2":
                    {
                        textBox1.MaxLength = 3;
                        textBox1.Text = "";
                    }
                    break;
                case "rb3":
                    {
                        textBox1.MaxLength = 9;
                        textBox1.Text = "";
                    }
                    break;

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 9 && textBox1.Text.Length <= 9)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }
    }
}
