namespace CS_Week01_25017093_MyBusinessCard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary> testttt
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(668, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 171);
            textBox1.TabIndex = 3;
            textBox1.Text = "홍시언";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox2.ForeColor = SystemColors.MenuHighlight;
            textBox2.Location = new Point(668, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(694, 64);
            textBox2.TabIndex = 5;
            textBox2.Text = "수원대 컴퓨터SW 25학번";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            textBox3.Location = new Point(668, 393);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(552, 50);
            textBox3.TabIndex = 6;
            textBox3.Text = "gorhanhee01@gmail.com";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(799, 642);
            button1.Name = "button1";
            button1.Size = new Size(599, 136);
            button1.TabIndex = 7;
            button1.Text = "배경색　바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Caret;
            pictureBox1.Image = CS_Week01_25017093_MyBusinessCard.Properties.Resources.photo;
            pictureBox1.Location = new Point(106, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 620);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter_1;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave_1;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(668, 475);
            button2.Name = "button2";
            button2.Size = new Size(264, 103);
            button2.TabIndex = 9;
            button2.Text = "Github";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(165, 693);
            button3.Name = "button3";
            button3.Size = new Size(304, 99);
            button3.TabIndex = 10;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 826);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}
