using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_LamThem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_X_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if(ctrl.Text.Length>0)
            {
                if (Char.IsDigit(ctrl.Text, 0) == false || int.Parse(ctrl.Text) <= 10)
                {
                    this.errorProvider1.SetError(ctrl, "Giá trị phải là chữ số và > 10");
                    ctrl.Focus();
                }
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txt_Y_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0)
            {
                if (Char.IsDigit(ctrl.Text, 0) == false || int.Parse(ctrl.Text) <= 10)
                {
                    this.errorProvider1.SetError(ctrl, "Giá trị phải là chữ số và > 10");
                    ctrl.Focus();
                }
                else
                    this.errorProvider1.Clear();
            }
        }
        private int ktraSNT(int n)
        {
            int kq = 1;
            if (n < 2)
                kq = 0;
            else
            {
                for(int i=2;i<n/2;i++)
                {
                    if (n % i == 0)
                    {
                        kq = 0;
                        break;
                    }
                    else
                        kq = 1;
                }
            }
            return kq;
        }
        
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt_X.Text);
            int y = int.Parse(txt_Y.Text);
            int count = 0;
            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    if (ktraSNT(i) == 1)
                        count++;
                    else
                        txt_amount_SNT.Text = "";
                }
                txt_amount_SNT.Text = count.ToString();
                int sum = 0;
                for(int j=y;j<=x;j++)
                {
                    if (j % 2 == 0)
                    {
                        sum += j;
                    }
                }
                txt_Sum_Chan.Text = sum.ToString();
            }
            else
                MessageBox.Show("Giá trị x phải lớn hơn y !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
