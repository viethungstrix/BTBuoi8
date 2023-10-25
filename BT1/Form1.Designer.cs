namespace BT1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btnadd = new Button();
            btnfix = new Button();
            btndel = new Button();
            label2 = new Label();
            dssv = new ComboBox();
            btnload = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 98);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(266, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(266, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 34);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 164);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 4;
            label3.Text = "Tên khoa";
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(87, 322);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(117, 50);
            btnadd.TabIndex = 5;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnfix
            // 
            btnfix.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnfix.Location = new Point(236, 322);
            btnfix.Name = "btnfix";
            btnfix.Size = new Size(117, 50);
            btnfix.TabIndex = 6;
            btnfix.Text = "Sửa";
            btnfix.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            btndel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btndel.Location = new Point(380, 322);
            btndel.Name = "btndel";
            btndel.Size = new Size(117, 50);
            btndel.TabIndex = 7;
            btndel.Text = "Xoá";
            btndel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 232);
            label2.Name = "label2";
            label2.Size = new Size(228, 32);
            label2.TabIndex = 8;
            label2.Text = "Danh sách sinh viên";
            // 
            // dssv
            // 
            dssv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dssv.FormattingEnabled = true;
            dssv.Location = new Point(340, 232);
            dssv.Name = "dssv";
            dssv.Size = new Size(303, 36);
            dssv.TabIndex = 9;
            dssv.SelectedIndexChanged += dssv_SelectedIndexChanged;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnload.Location = new Point(526, 322);
            btnload.Name = "btnload";
            btnload.Size = new Size(117, 50);
            btnload.TabIndex = 10;
            btnload.Text = "Reset";
            btnload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnload);
            Controls.Add(dssv);
            Controls.Add(label2);
            Controls.Add(btndel);
            Controls.Add(btnfix);
            Controls.Add(btnadd);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btnadd;
        private Button btnfix;
        private Button btndel;
        private Label label2;
        private ComboBox dssv;
        private Button btnload;
    }
}