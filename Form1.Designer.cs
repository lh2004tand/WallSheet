namespace CHAT_WALLSHEET
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UserName = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            userControl11 = new UserControl1();
            panel5 = new Panel();
            pictureBox11 = new PictureBox();
            label2 = new Label();
            pictureBox9 = new PictureBox();
            panel6 = new Panel();
            textBox1 = new TextBox();
            pictureBox10 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            userControl21 = new UserControl2();
            userControl31 = new UserControl3();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(55, 27);
            UserName.Name = "UserName";
            UserName.Size = new Size(185, 46);
            UserName.TabIndex = 0;
            UserName.Text = "User Name";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(-3, 225);
            button1.Name = "button1";
            button1.Size = new Size(252, 29);
            button1.TabIndex = 1;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 153);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSpringGreen;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserName);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(250, 753);
            panel1.MinimumSize = new Size(60, 753);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 753);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.unnamed__1_;
            pictureBox2.Image = Properties.Resources.unnamed__1_;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 266);
            panel2.TabIndex = 5;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.chat;
            pictureBox8.Location = new Point(0, 90);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(49, 36);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.help;
            pictureBox7.Location = new Point(0, 132);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(49, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.HOME;
            pictureBox6.Location = new Point(-3, 48);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(65, 132);
            button4.Name = "button4";
            button4.Size = new Size(184, 38);
            button4.TabIndex = 7;
            button4.Text = "HELP";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(65, 90);
            button3.Name = "button3";
            button3.Size = new Size(184, 36);
            button3.TabIndex = 6;
            button3.Text = "CHAT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 48);
            button2.Name = "button2";
            button2.Size = new Size(184, 36);
            button2.TabIndex = 5;
            button2.Text = "HOME";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(250, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 44);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Cyan;
            pictureBox3.BackgroundImage = Properties.Resources.unnamed__1_;
            pictureBox3.Image = Properties.Resources.bacham;
            pictureBox3.Location = new Point(601, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Location = new Point(541, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 75);
            panel4.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2024_06_02_083834;
            pictureBox5.Location = new Point(3, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Honeydew;
            pictureBox4.Image = Properties.Resources.accout;
            pictureBox4.Location = new Point(3, -4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.Location = new Point(0, -4);
            button6.Name = "button6";
            button6.Size = new Size(157, 41);
            button6.TabIndex = 3;
            button6.Text = "Account";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(3, 29);
            button5.Name = "button5";
            button5.Size = new Size(154, 46);
            button5.TabIndex = 2;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(userControl11);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(541, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(159, 406);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // userControl11
            // 
            userControl11.Dock = DockStyle.Top;
            userControl11.Icon = null;
            userControl11.Location = new Point(3, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(243, 10);
            userControl11.TabIndex = 0;
            userControl11.Title = null;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox11);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBox9);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(250, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(291, 64);
            panel5.TabIndex = 8;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox11.Image = Properties.Resources.sangphai;
            pictureBox11.Location = new Point(226, 0);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(59, 56);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 5;
            pictureBox11.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(74, 12);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(6, 6);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(62, 49);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(pictureBox10);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(250, 391);
            panel6.Name = "panel6";
            panel6.Size = new Size(291, 59);
            panel6.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Chartreuse;
            textBox1.Location = new Point(0, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 56);
            textBox1.TabIndex = 2;
            textBox1.Text = "Type Here";
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox10.Image = Properties.Resources.send;
            pictureBox10.Location = new Point(226, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(59, 56);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(userControl21);
            flowLayoutPanel2.Controls.Add(userControl31);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(250, 108);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(291, 283);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // userControl21
            // 
            userControl21.BackColor = Color.DarkViolet;
            userControl21.Location = new Point(3, 3);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(288, 27);
            userControl21.TabIndex = 0;
            userControl21.Title = null;
            // 
            // userControl31
            // 
            userControl31.Icon = null;
            userControl31.Location = new Point(3, 36);
            userControl31.Name = "userControl31";
            userControl31.Size = new Size(288, 37);
            userControl31.TabIndex = 1;
            userControl31.Title = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(700, 450);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Cursor = Cursors.Cross;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label UserName;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Button button6;
        private Button button5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private FlowLayoutPanel flowLayoutPanel1;
        private UserControl1 userControl11;
        private Panel panel5;
        private Label label2;
        private PictureBox pictureBox9;
        private Panel panel6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
    }
}
