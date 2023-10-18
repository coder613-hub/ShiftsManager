namespace ShiftsManager
{
    partial class AdminHomePage
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
            this.pay_button = new System.Windows.Forms.Button();
            this.rate_button = new System.Windows.Forms.Button();
            this.time_button = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(267, 53);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(213, 76);
            this.pay_button.TabIndex = 0;
            this.pay_button.Text = "Pay Employee";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // rate_button
            // 
            this.rate_button.Location = new System.Drawing.Point(267, 167);
            this.rate_button.Name = "rate_button";
            this.rate_button.Size = new System.Drawing.Size(213, 76);
            this.rate_button.TabIndex = 1;
            this.rate_button.Text = "Change Employee Payrate";
            this.rate_button.UseVisualStyleBackColor = true;
            this.rate_button.Click += new System.EventHandler(this.rate_button_Click);
            // 
            // time_button
            // 
            this.time_button.Location = new System.Drawing.Point(267, 293);
            this.time_button.Name = "time_button";
            this.time_button.Size = new System.Drawing.Size(213, 76);
            this.time_button.TabIndex = 2;
            this.time_button.Text = "Modify timeclock records";
            this.time_button.UseVisualStyleBackColor = true;
            this.time_button.Click += new System.EventHandler(this.time_button_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.Location = new System.Drawing.Point(15, 19);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(106, 34);
            this.log_out_button.TabIndex = 3;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.UseVisualStyleBackColor = true;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.time_button);
            this.Controls.Add(this.rate_button);
            this.Controls.Add(this.pay_button);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHomePage_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Button rate_button;
        private System.Windows.Forms.Button time_button;
        private System.Windows.Forms.Button log_out_button;
    }
}