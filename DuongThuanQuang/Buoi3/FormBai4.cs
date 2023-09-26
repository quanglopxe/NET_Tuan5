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
    public partial class FormBai4 : Form
    {
        private List<int> numberList;
        public FormBai4()
        {
            InitializeComponent();
            numberList = new List<int>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(txtSo.Text, 0) == true)
            {
                numberList.Add(int.Parse(txtSo.Text));
                txtString.Text = string.Join(" ", numberList);
                txtSo.Clear();
                txtSo.Focus();
                txtSumString.Text = numberList.Sum().ToString();
                txtSumChan.Text = numberList.Where(x => x % 2 == 0).Sum().ToString();
                txtSumLe.Text = numberList.Where(x => x % 2 != 0).Sum().ToString();
            }
            else
                MessageBox.Show("Giá trị nhập phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            txtString.Clear();
            txtSumString.Clear();
            txtSumChan.Clear();
            txtSumLe.Clear();
            txtSo.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
