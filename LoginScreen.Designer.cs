

namespace KuehneNaggelMAIN
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            username_box = new TextBox();
            loginBtn = new Button();
            password_box = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // username_box
            // 
            username_box.BackColor = Color.FromArgb(119, 151, 173);
            username_box.BorderStyle = BorderStyle.None;
            username_box.Cursor = Cursors.IBeam;
            username_box.ForeColor = Color.FromArgb(35, 44, 75);
            username_box.Location = new Point(70, 10);
            username_box.Name = "username_box";
            username_box.Size = new Size(183, 16);
            username_box.TabIndex = 1;
            username_box.TextChanged += textBox2_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.BackgroundImage = Properties.Resources.login_button;
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(393, 18);
            loginBtn.Name = "loginBtn";
            loginBtn.Padding = new Padding(30);
            loginBtn.Size = new Size(119, 52);
            loginBtn.TabIndex = 2;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // password_box
            // 
            password_box.BackColor = Color.FromArgb(119, 151, 173);
            password_box.BorderStyle = BorderStyle.None;
            password_box.ForeColor = Color.FromArgb(35, 44, 75);
            password_box.Location = new Point(69, 10);
            password_box.Name = "password_box";
            password_box.Size = new Size(183, 16);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            password_box.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(149, 166, 174);
            label2.Location = new Point(808, 658);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 2;
            label2.Text = "Developed by\r\nCodeTree 2023";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 44, 75);
            label1.Location = new Point(151, 33);
            label1.Name = "label1";
            label1.Size = new Size(236, 78);
            label1.TabIndex = 1;
            label1.Text = "Welcome to\r\nDatabase Managment  \r\nSystem";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Cursor = Cursors.Hand;
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(35, 44, 75);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 700);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(898, 62);
            panel6.TabIndex = 12;
            panel6.MouseDown += panel6_MouseDown;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(846, 11);
            button2.Name = "button2";
            button2.Size = new Size(49, 45);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.login_button;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Controls.Add(loginBtn);
            panel5.Location = new Point(-1, 489);
            panel5.Name = "panel5";
            panel5.Size = new Size(900, 87);
            panel5.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.kuehne_and_nagel_logo;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 204);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(928, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(43, 33);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = SystemColors.ActiveCaption;
            linkLabel1.Location = new Point(108, 677);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 13);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "codetree@official.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gadugi", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(149, 166, 174);
            label4.Location = new Point(3, 648);
            label4.Name = "label4";
            label4.Size = new Size(283, 42);
            label4.TabIndex = 3;
            label4.Text = "Support\r\nTo obtain access to this app or any questions about it\r\nwrite an message to ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(username_box);
            panel3.Location = new Point(287, 391);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 34);
            panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(18, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(password_box);
            panel4.Location = new Point(288, 438);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 34);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(35, 44, 75);
            label3.Location = new Point(337, 350);
            label3.Name = "label3";
            label3.Size = new Size(228, 26);
            label3.TabIndex = 3;
            label3.Text = "Log in to your account";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox username_box;
        private Button loginBtn;
        private TextBox password_box;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button1;
        private Panel panel5;
        private Panel panel1;
        private Button button2;
        private Panel panel6;
    }
}