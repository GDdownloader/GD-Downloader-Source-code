namespace GDDownloader
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(130, 195);
            label2.Name = "label2";
            label2.Size = new Size(546, 25);
            label2.TabIndex = 1;
            label2.Text = "Link :https://gddownloader.github.io/gdlauncher.github.io/help.pdf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(260, 95);
            label3.Name = "label3";
            label3.Size = new Size(265, 25);
            label3.TabIndex = 2;
            label3.Text = "Offical guide for gdDownloader";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(11, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 93);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // help
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(834, 468);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "help";
            Text = "help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}