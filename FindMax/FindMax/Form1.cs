using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text, 0) == false)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị nhập không hợp lệ");
                MessageBox.Show("Vui lòng nhập kiểu dữ liệu số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.errorProvider1.Clear();
        }
        private void b_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text, 0) == false)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị nhập không hợp lệ");
                MessageBox.Show("Vui lòng nhập kiểu dữ liệu số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.errorProvider1.Clear();
        }
        private void c_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text, 0) == false)
            {
                this.errorProvider1.SetError(ctrl, "Giá trị nhập không hợp lệ");
                MessageBox.Show("Vui lòng nhập kiểu dữ liệu số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = int.Parse(a.Text);
            if(int.Parse(b.Text)>max)
            {
                max = int.Parse(b.Text);
            }
            if (int.Parse(c.Text) > max)
            {
                max = int.Parse(c.Text);
            }
            result.Text = max.ToString();
        }

        private void a_Validating(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(ctrl.Text) == true)
            {
                e.Cancel = true;
                ctrl.Focus();
                errorProvider1.SetError(ctrl, "Bắt buộc nhập giá trị!");

            }
            else
                errorProvider1.Clear();
        }



        
    }
}
