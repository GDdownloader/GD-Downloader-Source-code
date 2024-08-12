namespace GDDownloader
{
    partial class crefrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crefrom));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(266, 242);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 0;
            button1.Text = "Summbit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(281, 8);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "Verision";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(281, 122);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(281, 387);
            button2.Name = "button2";
            button2.Size = new Size(96, 92);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(11, 302);
            label3.Name = "label3";
            label3.Size = new Size(618, 25);
            label3.TabIndex = 6;
            label3.Text = "Click the button below after filling out the boxes and cliking enter afterwords";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(119, 337);
            label4.Name = "label4";
            label4.Size = new Size(441, 25);
            label4.TabIndex = 7;
            label4.Text = "Just click the button below don't click the close button";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(281, 214);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 8;
            label5.Text = "DONT ADD SPACES";
            // 
            // crefrom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(636, 542);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crefrom";
            Text = "crefrom";
            Load += crefrom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}