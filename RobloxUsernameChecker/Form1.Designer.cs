namespace RobloxUsernameChecker
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.AvailableCount = new System.Windows.Forms.Label();
            this.TotalCount = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(423, 184);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 206);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(423, 184);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 396);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(423, 31);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AvailableCount
            // 
            this.AvailableCount.AutoSize = true;
            this.AvailableCount.Location = new System.Drawing.Point(143, 430);
            this.AvailableCount.Name = "AvailableCount";
            this.AvailableCount.Size = new System.Drawing.Size(62, 13);
            this.AvailableCount.TabIndex = 3;
            this.AvailableCount.Text = "Available: 0";
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.Location = new System.Drawing.Point(242, 430);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(43, 13);
            this.TotalCount.TabIndex = 4;
            this.TotalCount.Text = "Total: 0";
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(91, 463);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(260, 13);
            this.Link.TabIndex = 5;
            this.Link.Text = "https://github.com/PY44N/RobloxUsernameChecker";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(117, 450);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(205, 13);
            this.Credits.TabIndex = 6;
            this.Credits.Text = "Open Source Username Checker by Pyan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 485);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.AvailableCount);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Roblox Username Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label AvailableCount;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label Link;
        private System.Windows.Forms.Label Credits;
    }
}

