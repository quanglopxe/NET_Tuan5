namespace BT_LamThem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_amount_SNT = new System.Windows.Forms.TextBox();
            this.txt_Sum_Chan = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng số nguyên tố";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng các số chẵn";
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(293, 44);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(307, 30);
            this.txt_X.TabIndex = 1;
            this.txt_X.TextChanged += new System.EventHandler(this.txt_X_TextChanged);
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(293, 92);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(307, 30);
            this.txt_Y.TabIndex = 2;
            this.txt_Y.TextChanged += new System.EventHandler(this.txt_Y_TextChanged);
            // 
            // txt_amount_SNT
            // 
            this.txt_amount_SNT.Enabled = false;
            this.txt_amount_SNT.Location = new System.Drawing.Point(293, 140);
            this.txt_amount_SNT.Name = "txt_amount_SNT";
            this.txt_amount_SNT.Size = new System.Drawing.Size(307, 30);
            this.txt_amount_SNT.TabIndex = 1;
            // 
            // txt_Sum_Chan
            // 
            this.txt_Sum_Chan.Enabled = false;
            this.txt_Sum_Chan.Location = new System.Drawing.Point(293, 190);
            this.txt_Sum_Chan.Name = "txt_Sum_Chan";
            this.txt_Sum_Chan.Size = new System.Drawing.Size(307, 30);
            this.txt_Sum_Chan.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(323, 289);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(80, 38);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Xử lý";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(482, 289);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 38);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 489);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Sum_Chan);
            this.Controls.Add(this.txt_amount_SNT);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bai 1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_amount_SNT;
        private System.Windows.Forms.TextBox txt_Sum_Chan;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

