using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang_winform
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }
        private void frmBT1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctrl, "You must enter your name");
            else
                this.errorProvider1.Clear();
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if(ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text,0)==false)//if (ctrl.Text.Length > 0 && !Char.IsDigit(ctrl.Text[ctrl.Text.Length-11])) //tại sao lại trừ 11?
                this.errorProvider1.SetError(ctrl, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - int.Parse(txtYear.Text);
            s = s + "Age: " + age; // .toString()
            MessageBox.Show(s);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

       
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
