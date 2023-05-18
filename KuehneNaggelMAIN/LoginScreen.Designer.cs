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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            username_box = new TextBox();
            loginBtn = new Button();
            password_box = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // username_box
            // 
            username_box.BackColor = Color.Gainsboro;
            username_box.Cursor = Cursors.IBeam;
            username_box.Location = new Point(80, 10);
            username_box.Margin = new Padding(3, 4, 3, 4);
            username_box.Name = "username_box";
            username_box.Size = new Size(341, 27);
            username_box.TabIndex = 1;
            username_box.TextChanged += textBox2_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveCaption;
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.FromArgb(35, 44, 75);
            loginBtn.Location = new Point(154, 358);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(138, 47);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // password_box
            // 
            password_box.BackColor = Color.Gainsboro;
            password_box.Cursor = Cursors.IBeam;
            password_box.Location = new Point(80, 10);
            password_box.Margin = new Padding(3, 4, 3, 4);
            password_box.Name = "password_box";
            password_box.Size = new Size(341, 27);
            password_box.TabIndex = 3;
            password_box.UseSystemPasswordChar = true;
            password_box.TextChanged += textBox1_TextChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(129, 157, 172);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(35, 44, 75);
            label2.Location = new Point(185, 483);
            label2.Name = "label2";
            label2.Size = new Size(109, 38);
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
            label1.Location = new Point(11, 233);
            label1.Name = "label1";
            label1.Size = new Size(286, 99);
            label1.TabIndex = 1;
            label1.Text = "Welcome to\r\nDatabase Managment\r\nSystem";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kuehne_and_nagel_logo;
            pictureBox1.Location = new Point(33, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(loginBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(35, 44, 75);
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 6;
            // 
            // close_window
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(396, 3);
            button1.Name = "close_window";
            button1.Size = new Size(49, 44);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = SystemColors.ActiveCaption;
            linkLabel1.Location = new Point(140, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 17);
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
            label4.Location = new Point(20, 472);
            label4.Name = "label4";
            label4.Size = new Size(322, 48);
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
            panel3.Location = new Point(-1, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 46);
            panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(20, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(password_box);
            panel4.Location = new Point(0, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 46);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 40);
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
            label3.Location = new Point(20, 172);
            label3.Name = "label3";
            label3.Size = new Size(269, 33);
            label3.TabIndex = 3;
            label3.Text = "Login to your accout";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox username_box;
        private Button loginBtn;
        private TextBox password_box;
        private Panel panel1;
        private PictureBox pictureBox1;
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
        private BindingSource bindingSource1;
        private Button button1;
    }
}