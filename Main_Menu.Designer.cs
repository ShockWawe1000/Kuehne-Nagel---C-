namespace KuehneNaggelMAIN
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            panel2 = new Panel();
            panelDesktopPane = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            NameWindow = new Label();
            Close = new Button();
            panel3 = new Panel();
            Settings = new Button();
            Database = new Button();
            Statistics = new Button();
            Network = new Button();
            RouteFinder = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            panel2.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panelDesktopPane);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1478, 964);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackgroundImage = Properties.Resources.bckrgnd1;
            panelDesktopPane.BackgroundImageLayout = ImageLayout.Stretch;
            panelDesktopPane.Controls.Add(panel4);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(329, 44);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1149, 920);
            panelDesktopPane.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(28, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(1094, 827);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(35, 44, 75);
            label1.Location = new Point(28, 48);
            label1.Name = "label1";
            label1.Size = new Size(293, 54);
            label1.TabIndex = 2;
            label1.Text = "Welcome, User";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.kuehne_and_nagel_logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(14, 550);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1065, 253);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1065, 619);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(238, 243, 246);
            panel5.Controls.Add(NameWindow);
            panel5.Controls.Add(Close);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(329, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30);
            panel5.Size = new Size(1149, 44);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // NameWindow
            // 
            NameWindow.AutoSize = true;
            NameWindow.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            NameWindow.ForeColor = Color.FromArgb(35, 44, 75);
            NameWindow.Location = new Point(0, 4);
            NameWindow.Name = "NameWindow";
            NameWindow.Size = new Size(173, 37);
            NameWindow.TabIndex = 1;
            NameWindow.Text = "Route Finder";
            // 
            // Close
            // 
            Close.BackColor = Color.FromArgb(238, 243, 246);
            Close.BackgroundImage = Properties.Resources.close;
            Close.BackgroundImageLayout = ImageLayout.Zoom;
            Close.Location = new Point(1101, 0);
            Close.Name = "Close";
            Close.Size = new Size(45, 42);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(238, 243, 246);
            panel3.Controls.Add(Settings);
            panel3.Controls.Add(Database);
            panel3.Controls.Add(Statistics);
            panel3.Controls.Add(Network);
            panel3.Controls.Add(RouteFinder);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Left;
            panel3.ForeColor = SystemColors.AppWorkspace;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 964);
            panel3.TabIndex = 1;
            // 
            // Settings
            // 
            Settings.BackColor = Color.FromArgb(238, 243, 246);
            Settings.BackgroundImage = (Image)resources.GetObject("Settings.BackgroundImage");
            Settings.BackgroundImageLayout = ImageLayout.None;
            Settings.Dock = DockStyle.Bottom;
            Settings.FlatStyle = FlatStyle.Flat;
            Settings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Settings.ForeColor = Color.FromArgb(35, 44, 75);
            Settings.ImageAlign = ContentAlignment.BottomLeft;
            Settings.Location = new Point(0, 890);
            Settings.Name = "Settings";
            Settings.Size = new Size(329, 74);
            Settings.TabIndex = 10;
            Settings.Text = "Settings";
            Settings.TextAlign = ContentAlignment.MiddleRight;
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += button2_Click;
            // 
            // Database
            // 
            Database.BackColor = Color.FromArgb(238, 243, 246);
            Database.BackgroundImageLayout = ImageLayout.None;
            Database.Dock = DockStyle.Top;
            Database.FlatStyle = FlatStyle.Flat;
            Database.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Database.ForeColor = Color.FromArgb(35, 44, 75);
            Database.Image = Properties.Resources.server;
            Database.ImageAlign = ContentAlignment.MiddleLeft;
            Database.Location = new Point(0, 298);
            Database.Name = "Database";
            Database.Padding = new Padding(0, 5, 0, 5);
            Database.Size = new Size(329, 74);
            Database.TabIndex = 9;
            Database.Text = "Database";
            Database.TextAlign = ContentAlignment.MiddleRight;
            Database.UseVisualStyleBackColor = false;
            Database.Click += button9_Click;
            // 
            // Statistics
            // 
            Statistics.BackColor = Color.FromArgb(238, 243, 246);
            Statistics.Dock = DockStyle.Top;
            Statistics.FlatStyle = FlatStyle.Flat;
            Statistics.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Statistics.ForeColor = Color.FromArgb(35, 44, 75);
            Statistics.Image = Properties.Resources.connections;
            Statistics.ImageAlign = ContentAlignment.MiddleLeft;
            Statistics.Location = new Point(0, 224);
            Statistics.Name = "Statistics";
            Statistics.Padding = new Padding(0, 5, 0, 5);
            Statistics.Size = new Size(329, 74);
            Statistics.TabIndex = 8;
            Statistics.Text = "Statistics";
            Statistics.TextAlign = ContentAlignment.MiddleRight;
            Statistics.UseVisualStyleBackColor = false;
            Statistics.Click += button8_Click;
            // 
            // Network
            // 
            Network.BackColor = Color.FromArgb(238, 243, 246);
            Network.Dock = DockStyle.Top;
            Network.FlatStyle = FlatStyle.Flat;
            Network.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Network.ForeColor = Color.FromArgb(35, 44, 75);
            Network.Image = Properties.Resources.wrl;
            Network.ImageAlign = ContentAlignment.MiddleLeft;
            Network.Location = new Point(0, 150);
            Network.Name = "Network";
            Network.Padding = new Padding(0, 5, 0, 5);
            Network.Size = new Size(329, 74);
            Network.TabIndex = 7;
            Network.Text = "Network";
            Network.TextAlign = ContentAlignment.MiddleRight;
            Network.UseVisualStyleBackColor = false;
            Network.Click += button7_Click;
            // 
            // RouteFinder
            // 
            RouteFinder.BackColor = Color.FromArgb(238, 243, 246);
            RouteFinder.Cursor = Cursors.Hand;
            RouteFinder.Dock = DockStyle.Top;
            RouteFinder.FlatStyle = FlatStyle.Flat;
            RouteFinder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RouteFinder.ForeColor = Color.FromArgb(35, 44, 75);
            RouteFinder.Image = Properties.Resources.trip;
            RouteFinder.ImageAlign = ContentAlignment.MiddleLeft;
            RouteFinder.Location = new Point(0, 76);
            RouteFinder.Name = "RouteFinder";
            RouteFinder.Padding = new Padding(0, 5, 0, 5);
            RouteFinder.Size = new Size(329, 74);
            RouteFinder.TabIndex = 1;
            RouteFinder.Text = "Route Finder";
            RouteFinder.TextAlign = ContentAlignment.MiddleRight;
            RouteFinder.UseVisualStyleBackColor = false;
            RouteFinder.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 243, 246);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 76);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.kuehne_and_nagel_name;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 74);
            panel6.TabIndex = 0;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 964);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            MinimumSize = new Size(900, 700);
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kuehne+Nagel";
            Load += Main_Menu_Load;
            panel2.ResumeLayout(false);
            panelDesktopPane.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Button RouteFinder;
        private Panel panel1;
        private Button Settings;
        private Button Database;
        private Button Statistics;
        private Button Network;
        private Panel panelDesktopPane;
        private Button Close;
        private Label NameWindow;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel6;
    }
}