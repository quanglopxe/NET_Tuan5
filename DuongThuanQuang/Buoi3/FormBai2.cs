using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Buoi5
{
    public partial class FormBai2 : Form
    {

        public FormBai2()
        {
            InitializeComponent();
        }

        private void FormBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Bắt buộc nhập User Name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }
        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (string.IsNullOrEmpty(ctr.Text))
            {
                errorProvider1.SetError(ctr, "Bắt buộc nhập Email");
            }
            else
            {
                if (!IsValidEmail(ctr.Text))
                    errorProvider1.SetError(ctr, "Email không đúng định dạng");
                else
                    errorProvider1.Clear();
            }
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            string RetypePassword = txtRetypePassword.Text;
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Mat khau khong duoc de trong!");
                txtPassword.Focus();
            }
            else
            {
                if (Password == RetypePassword)
                {
                    string result = "UserName: " + txtUserName.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Password: " + txtPassword.Text + "\n";
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp");
                    txtRetypePassword.Focus();
                }
            }
           
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (string.IsNullOrEmpty(ctr.Text))
            {
                errorProvider1.SetError(ctr, "Bắt buộc nhập Password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
