using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void FormBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.error1.SetError(ctr, "This is not a valid number");
            else
                this.error1.Clear();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.error1.SetError(ctr, "This is not a valid number");
            else
                this.error1.Clear();
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số.");
            }
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số.");
            }
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text.Contains(".") || textBoxB.Text.Contains("."))
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double result = a + b;
                textBoxKetQua.Text = result.ToString();
            } 
            else
            {
                try
                {
                    int a = Convert.ToInt32(textBoxA.Text);
                    int b = Convert.ToInt32(textBoxB.Text);
                    int result = a + b;
                    textBoxKetQua.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui long khong de trong!");
                    if(string.IsNullOrEmpty(textBoxA.Text))
                        textBoxA.Focus();
                    else
                        textBoxB.Focus();
                }
            }
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text.Contains(".") || textBoxB.Text.Contains("."))
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double result = a - b;
                textBoxKetQua.Text = result.ToString();
            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(textBoxA.Text);
                    int b = Convert.ToInt32(textBoxB.Text);
                    int result = a - b;
                    textBoxKetQua.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui long khong de trong!");
                    if (string.IsNullOrEmpty(textBoxA.Text))
                        textBoxA.Focus();
                    else
                        textBoxB.Focus();
                }
            }
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text.Contains(".") || textBoxB.Text.Contains("."))
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double result = a * b;
                textBoxKetQua.Text = result.ToString();
            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(textBoxA.Text);
                    int b = Convert.ToInt32(textBoxB.Text);
                    int result = a * b;
                    textBoxKetQua.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui long khong de trong!");
                    if (string.IsNullOrEmpty(textBoxA.Text))
                        textBoxA.Focus();
                    else
                        textBoxB.Focus();
                }
            }
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text.Contains(".") || textBoxB.Text.Contains("."))
            {
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                double result = a / b;
                textBoxKetQua.Text = result.ToString();
            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(textBoxA.Text);
                    int b = Convert.ToInt32(textBoxB.Text);
                    double result = a / b;
                    textBoxKetQua.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui long khong de trong!");
                    if (string.IsNullOrEmpty(textBoxA.Text))
                        textBoxA.Focus();
                    else
                        textBoxB.Focus();
                }
                
            }
        }
    }
}
