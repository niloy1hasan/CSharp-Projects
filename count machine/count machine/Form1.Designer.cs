namespace count_machine
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
            count = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // count
            // 
            count.AutoSize = true;
            count.BackColor = Color.Khaki;
            count.Location = new Point(177, 109);
            count.Name = "count";
            count.Padding = new Padding(20);
            count.Size = new Size(53, 55);
            count.TabIndex = 0;
            count.Text = "0";
            count.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(252, 89);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(55, 85);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(100, 89);
            button3.Name = "button3";
            button3.Padding = new Padding(10);
            button3.Size = new Size(55, 85);
            button3.TabIndex = 3;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(146, 180);
            button1.Name = "button1";
            button1.Size = new Size(115, 40);
            button1.TabIndex = 4;
            button1.Text = "RESET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(count);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(53, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 297);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(557, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Count Machine";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label count;
        private Button button2;
        private Button button3;
        private Button button1;
        private Panel panel1;
    }
}
