
namespace Buoi5
{
    partial class FormBai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.Label();
            this.textBoxKetQua = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.Label();
            this.buttonCong = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Location = new System.Drawing.Point(34, 36);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(22, 13);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "a =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(97, 36);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(76, 20);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(293, 36);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(76, 20);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // txtB
            // 
            this.txtB.AutoSize = true;
            this.txtB.Location = new System.Drawing.Point(228, 36);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(22, 13);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "b =";
            // 
            // textBoxKetQua
            // 
            this.textBoxKetQua.Location = new System.Drawing.Point(97, 80);
            this.textBoxKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKetQua.Name = "textBoxKetQua";
            this.textBoxKetQua.Size = new System.Drawing.Size(272, 20);
            this.textBoxKetQua.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.AutoSize = true;
            this.txtKetQua.Location = new System.Drawing.Point(34, 80);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(44, 13);
            this.txtKetQua.TabIndex = 4;
            this.txtKetQua.Text = "Kết quả";
            // 
            // buttonCong
            // 
            this.buttonCong.Location = new System.Drawing.Point(47, 136);
            this.buttonCong.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(64, 33);
            this.buttonCong.TabIndex = 6;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.buttonCong_Click);
            // 
            // buttonTru
            // 
            this.buttonTru.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTru.Location = new System.Drawing.Point(130, 136);
            this.buttonTru.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(62, 33);
            this.buttonTru.TabIndex = 7;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.buttonTru_Click);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Location = new System.Drawing.Point(212, 136);
            this.buttonNhan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(62, 33);
            this.buttonNhan.TabIndex = 8;
            this.buttonNhan.Text = "x";
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.buttonNhan_Click);
            // 
            // buttonChia
            // 
            this.buttonChia.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonChia.Location = new System.Drawing.Point(293, 136);
            this.buttonChia.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(60, 33);
            this.buttonChia.TabIndex = 9;
            this.buttonChia.Text = "/";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.buttonChia_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // FormBai1
            // 
            this.AcceptButton = this.buttonCong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 179);
            this.Controls.Add(this.buttonChia);
            this.Controls.Add(this.buttonNhan);
            this.Controls.Add(this.buttonTru);
            this.Controls.Add(this.buttonCong);
            this.Controls.Add(this.textBoxKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.txtA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBai1";
            this.Text = "FormBai1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBai1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label txtB;
        private System.Windows.Forms.TextBox textBoxKetQua;
        private System.Windows.Forms.Label txtKetQua;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button buttonChia;
        private System.Windows.Forms.ErrorProvider error1;
    }
}