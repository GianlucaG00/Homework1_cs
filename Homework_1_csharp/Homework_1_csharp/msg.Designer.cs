namespace Homework_1_csharp
{
    partial class msg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 40);
            this.panel1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Close.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(574, 226);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 46);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "The text fields have been cleaned";
            // 
            // msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button Close;
        private Label label1;
    }
}