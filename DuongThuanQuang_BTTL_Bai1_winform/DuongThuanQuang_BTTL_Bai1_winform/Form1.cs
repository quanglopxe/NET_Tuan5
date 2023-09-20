﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuongThuanQuang_BTTL_Bai1_winform
{
    public partial class Form1 : Form
    {
        int kq = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnPlus(object sender, EventArgs e)
        {
            kq = Convert.ToInt32(a.Text) + Convert.ToInt32(b.Text);
            result.Text = kq.ToString();
        }

        private void btnMinus(object sender, EventArgs e)
        {
            kq = Convert.ToInt32(a.Text) - Convert.ToInt32(b.Text);
            result.Text = kq.ToString();
        }

        private void btnMultiply(object sender, EventArgs e)
        {
            kq = Convert.ToInt32(a.Text) * Convert.ToInt32(b.Text);
            result.Text = kq.ToString();
        }

        private void btnDevise(object sender, EventArgs e)
        {
            kq = Convert.ToInt32(a.Text) / Convert.ToInt32(b.Text);
            result.Text = kq.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text, 0) == false)//if (ctrl.Text.Length > 0 && !Char.IsDigit(ctrl.Text[ctrl.Text.Length-11])) //tại sao lại trừ 11?
                this.errorProvider1.SetError(ctrl, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length > 0 && Char.IsDigit(ctrl.Text, 0) == false)//if (ctrl.Text.Length > 0 && !Char.IsDigit(ctrl.Text[ctrl.Text.Length-11])) //tại sao lại trừ 11?
                this.errorProvider1.SetError(ctrl, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }
        

    }
}