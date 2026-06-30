namespace Lab1_Discussion
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
            panel1 = new Panel();
            buttonSL1 = new Button();
            progressBarSL1 = new ProgressBar();
            labelSL1 = new Label();
            panel2 = new Panel();
            buttonST1 = new Button();
            progressBarST1 = new ProgressBar();
            labelST1 = new Label();
            panel3 = new Panel();
            buttonSL2 = new Button();
            progressBarSL2 = new ProgressBar();
            labelSL2 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(buttonSL1);
            panel1.Controls.Add(progressBarSL1);
            panel1.Controls.Add(labelSL1);
            panel1.Location = new Point(43, 73);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 80);
            panel1.TabIndex = 0;
            // 
            // buttonSL1
            // 
            buttonSL1.BackColor = Color.Black;
            buttonSL1.ForeColor = SystemColors.Control;
            buttonSL1.Location = new Point(578, 11);
            buttonSL1.Margin = new Padding(2);
            buttonSL1.Name = "buttonSL1";
            buttonSL1.Size = new Size(78, 21);
            buttonSL1.TabIndex = 2;
            buttonSL1.Text = "TURN ON";
            buttonSL1.UseVisualStyleBackColor = false;
            buttonSL1.Click += buttonSL1_Click;
            // 
            // progressBarSL1
            // 
            progressBarSL1.Location = new Point(15, 36);
            progressBarSL1.Margin = new Padding(2);
            progressBarSL1.Name = "progressBarSL1";
            progressBarSL1.Size = new Size(641, 35);
            progressBarSL1.TabIndex = 1;
            // 
            // labelSL1
            // 
            labelSL1.AutoSize = true;
            labelSL1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSL1.Location = new Point(15, 11);
            labelSL1.Margin = new Padding(2, 0, 2, 0);
            labelSL1.Name = "labelSL1";
            labelSL1.Size = new Size(114, 21);
            labelSL1.TabIndex = 0;
            labelSL1.Text = "Smart Light #1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(buttonST1);
            panel2.Controls.Add(progressBarST1);
            panel2.Controls.Add(labelST1);
            panel2.Location = new Point(43, 157);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 80);
            panel2.TabIndex = 1;
            // 
            // buttonST1
            // 
            buttonST1.BackColor = Color.Black;
            buttonST1.ForeColor = SystemColors.Control;
            buttonST1.Location = new Point(578, 11);
            buttonST1.Margin = new Padding(2);
            buttonST1.Name = "buttonST1";
            buttonST1.Size = new Size(78, 22);
            buttonST1.TabIndex = 2;
            buttonST1.Text = "TURN ON";
            buttonST1.UseVisualStyleBackColor = false;
            buttonST1.Click += buttonST1_Click;
            // 
            // progressBarST1
            // 
            progressBarST1.Location = new Point(15, 36);
            progressBarST1.Margin = new Padding(2);
            progressBarST1.Maximum = 30;
            progressBarST1.Minimum = 16;
            progressBarST1.Name = "progressBarST1";
            progressBarST1.Size = new Size(641, 33);
            progressBarST1.TabIndex = 1;
            progressBarST1.Value = 16;
            // 
            // labelST1
            // 
            labelST1.AutoSize = true;
            labelST1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelST1.Location = new Point(15, 11);
            labelST1.Margin = new Padding(2, 0, 2, 0);
            labelST1.Name = "labelST1";
            labelST1.Size = new Size(160, 21);
            labelST1.TabIndex = 0;
            labelST1.Text = "Smart Thermostat #1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(buttonSL2);
            panel3.Controls.Add(progressBarSL2);
            panel3.Controls.Add(labelSL2);
            panel3.Location = new Point(43, 241);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(677, 81);
            panel3.TabIndex = 2;
            // 
            // buttonSL2
            // 
            buttonSL2.BackColor = Color.Black;
            buttonSL2.ForeColor = SystemColors.Control;
            buttonSL2.Location = new Point(578, 8);
            buttonSL2.Margin = new Padding(2);
            buttonSL2.Name = "buttonSL2";
            buttonSL2.Size = new Size(78, 22);
            buttonSL2.TabIndex = 2;
            buttonSL2.Text = "TURN ON";
            buttonSL2.UseVisualStyleBackColor = false;
            buttonSL2.Click += buttonSL2_Click;
            // 
            // progressBarSL2
            // 
            progressBarSL2.Location = new Point(15, 34);
            progressBarSL2.Margin = new Padding(2);
            progressBarSL2.Name = "progressBarSL2";
            progressBarSL2.Size = new Size(641, 35);
            progressBarSL2.TabIndex = 1;
            // 
            // labelSL2
            // 
            labelSL2.AutoSize = true;
            labelSL2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSL2.Location = new Point(15, 11);
            labelSL2.Margin = new Padding(2, 0, 2, 0);
            labelSL2.Name = "labelSL2";
            labelSL2.Size = new Size(115, 21);
            labelSL2.TabIndex = 0;
            labelSL2.Text = "Smart Light #2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label4.Location = new Point(637, 39);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Progress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 29);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 4;
            label1.Text = "SMART HOME IoT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(765, 343);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonSL1;
        private ProgressBar progressBarSL1;
        private Label labelSL1;
        private Panel panel2;
        private Button buttonST1;
        private ProgressBar progressBarST1;
        private Label labelST1;
        private Panel panel3;
        private Button buttonSL2;
        private ProgressBar progressBarSL2;
        private Label labelSL2;
        private Label label4;
        private Label label1;
    }
}
