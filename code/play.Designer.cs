namespace GDDownloader
{
    partial class play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(11, 197);
            button1.Name = "button1";
            button1.Size = new Size(111, 202);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(1081, 213);
            button2.Name = "button2";
            button2.Size = new Size(111, 213);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 285);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(946, 285);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Unkown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(946, 338);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Unknown";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 338);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 5;
            label4.Text = "Version";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Location = new Point(11, 22);
            button3.Name = "button3";
            button3.Size = new Size(93, 95);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 443);
            label5.Name = "label5";
            label5.Size = new Size(223, 25);
            label5.TabIndex = 7;
            label5.Text = "If this is your inst click play";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Location = new Point(543, 488);
            button4.Name = "button4";
            button4.Size = new Size(186, 165);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // play
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1206, 665);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "play";
            Text = "play";
            Load += play_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Button button4;
    }
}