namespace Devop_DiceRoller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn1d4Roll = new Button();
            btn1d6Roll = new Button();
            btn1d8Roll = new Button();
            lblD4 = new Label();
            lblD6 = new Label();
            lblD8 = new Label();
            tbxD4 = new TextBox();
            tbxD6 = new TextBox();
            tbxD8 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1d4Roll
            // 
            btn1d4Roll.Location = new Point(40, 278);
            btn1d4Roll.Name = "btn1d4Roll";
            btn1d4Roll.Size = new Size(80, 35);
            btn1d4Roll.TabIndex = 0;
            btn1d4Roll.Text = "Roll";
            btn1d4Roll.UseVisualStyleBackColor = true;
            btn1d4Roll.Click += btn1d4Roll_Click;
            // 
            // btn1d6Roll
            // 
            btn1d6Roll.Location = new Point(181, 278);
            btn1d6Roll.Name = "btn1d6Roll";
            btn1d6Roll.Size = new Size(80, 35);
            btn1d6Roll.TabIndex = 1;
            btn1d6Roll.Text = "Roll";
            btn1d6Roll.UseVisualStyleBackColor = true;
            btn1d6Roll.Click += btn1d6Roll_Click;
            // 
            // btn1d8Roll
            // 
            btn1d8Roll.Location = new Point(328, 278);
            btn1d8Roll.Name = "btn1d8Roll";
            btn1d8Roll.Size = new Size(80, 35);
            btn1d8Roll.TabIndex = 2;
            btn1d8Roll.Text = "Roll";
            btn1d8Roll.UseVisualStyleBackColor = true;
            btn1d8Roll.Click += btn1d8Roll_Click;
            // 
            // lblD4
            // 
            lblD4.AutoSize = true;
            lblD4.Location = new Point(62, 255);
            lblD4.Name = "lblD4";
            lblD4.Size = new Size(34, 20);
            lblD4.TabIndex = 3;
            lblD4.Text = "1d4";
            // 
            // lblD6
            // 
            lblD6.AutoSize = true;
            lblD6.Location = new Point(206, 255);
            lblD6.Name = "lblD6";
            lblD6.Size = new Size(34, 20);
            lblD6.TabIndex = 4;
            lblD6.Text = "1d6";
            // 
            // lblD8
            // 
            lblD8.AutoSize = true;
            lblD8.Location = new Point(352, 255);
            lblD8.Name = "lblD8";
            lblD8.Size = new Size(34, 20);
            lblD8.TabIndex = 5;
            lblD8.Text = "1d8";
            // 
            // tbxD4
            // 
            tbxD4.ForeColor = SystemColors.ScrollBar;
            tbxD4.Location = new Point(40, 336);
            tbxD4.Name = "tbxD4";
            tbxD4.ReadOnly = true;
            tbxD4.Size = new Size(80, 27);
            tbxD4.TabIndex = 6;
            tbxD4.Text = "Result";
            tbxD4.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxD6
            // 
            tbxD6.ForeColor = SystemColors.ScrollBar;
            tbxD6.Location = new Point(181, 336);
            tbxD6.Name = "tbxD6";
            tbxD6.ReadOnly = true;
            tbxD6.Size = new Size(80, 27);
            tbxD6.TabIndex = 8;
            tbxD6.Text = "Result";
            tbxD6.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxD8
            // 
            tbxD8.ForeColor = SystemColors.ScrollBar;
            tbxD8.Location = new Point(328, 336);
            tbxD8.Name = "tbxD8";
            tbxD8.ReadOnly = true;
            tbxD8.Size = new Size(80, 27);
            tbxD8.TabIndex = 9;
            tbxD8.Text = "Result";
            tbxD8.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(84, 29);
            button1.TabIndex = 10;
            button1.Text = "Statistics";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(119, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 191);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 390);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tbxD8);
            Controls.Add(tbxD6);
            Controls.Add(tbxD4);
            Controls.Add(lblD8);
            Controls.Add(lblD6);
            Controls.Add(lblD4);
            Controls.Add(btn1d8Roll);
            Controls.Add(btn1d6Roll);
            Controls.Add(btn1d4Roll);
            Name = "MainForm";
            Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1d4Roll;
        private Button btn1d6Roll;
        private Button btn1d8Roll;
        private Label lblD4;
        private Label lblD6;
        private Label lblD8;
        private TextBox tbxD4;
        private TextBox tbxD6;
        private TextBox tbxD8;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
