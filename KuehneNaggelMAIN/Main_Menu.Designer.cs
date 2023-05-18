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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dock_window = new Button();
            close_window = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 720);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.kuehne_and_nagel_name;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 720);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(dock_window);
            panel3.Controls.Add(close_window);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1030, 50);
            panel3.TabIndex = 0;
            // 
            // dock_window
            // 
            dock_window.BackColor = Color.Transparent;
            dock_window.BackgroundImage = Properties.Resources.Minimise_window;
            dock_window.BackgroundImageLayout = ImageLayout.Stretch;
            dock_window.Cursor = Cursors.Hand;
            dock_window.Location = new Point(930, 3);
            dock_window.Name = "dock_window";
            dock_window.Size = new Size(42, 40);
            dock_window.TabIndex = 1;
            dock_window.UseVisualStyleBackColor = false;
            // 
            // close_window
            // 
            close_window.BackColor = Color.Transparent;
            close_window.BackgroundImage = Properties.Resources.close;
            close_window.BackgroundImageLayout = ImageLayout.Stretch;
            close_window.Cursor = Cursors.Hand;
            close_window.FlatStyle = FlatStyle.Flat;
            close_window.Location = new Point(978, 3);
            close_window.Name = "close_window";
            close_window.Size = new Size(42, 40);
            close_window.TabIndex = 0;
            close_window.UseVisualStyleBackColor = false;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MinimizeBox = false;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Main_Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dock_window;
        private Panel panel3;
        private Button close_window;
    }
}