namespace Homework_1_csharp
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
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(903, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(78, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1317, 46);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(470, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 39);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(470, 361);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 39);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(248, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(322, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(851, 90);
            this.label4.TabIndex = 8;
            this.label4.Text = "Insert your informations";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("MV Boli", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.Location = new System.Drawing.Point(78, 687);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(84, 55);
            this.info.TabIndex = 9;
            this.info.Text = "---";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Gold;
            this.Clear.Font = new System.Drawing.Font("MV Boli", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(903, 327);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(325, 73);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 801);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontDialog fontDialog1;
        private Label label4;
        private Label info;
        private Button Clear;
    }
}