namespace ShiftsManager
{
    partial class UserHomePage
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
            this.clock_in_button = new System.Windows.Forms.Button();
            this.clock_out_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.confirmation_label = new System.Windows.Forms.Label();
            this.log_out_button = new System.Windows.Forms.Button();
            this.welcome_text = new System.Windows.Forms.Label();
            this.owed_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clock_in_button
            // 
            this.clock_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_in_button.Location = new System.Drawing.Point(288, 115);
            this.clock_in_button.Name = "clock_in_button";
            this.clock_in_button.Size = new System.Drawing.Size(240, 155);
            this.clock_in_button.TabIndex = 0;
            this.clock_in_button.Text = "Clock In";
            this.clock_in_button.UseVisualStyleBackColor = true;
            this.clock_in_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // clock_out_button
            // 
            this.clock_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_out_button.Location = new System.Drawing.Point(288, 115);
            this.clock_out_button.Name = "clock_out_button";
            this.clock_out_button.Size = new System.Drawing.Size(240, 155);
            this.clock_out_button.TabIndex = 1;
            this.clock_out_button.Text = "Clock Out";
            this.clock_out_button.UseVisualStyleBackColor = true;
            this.clock_out_button.Click += new System.EventHandler(this.clock_out_button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(288, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "History";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // confirmation_label
            // 
            this.confirmation_label.AutoSize = true;
            this.confirmation_label.Location = new System.Drawing.Point(215, 295);
            this.confirmation_label.Name = "confirmation_label";
            this.confirmation_label.Size = new System.Drawing.Size(0, 16);
            this.confirmation_label.TabIndex = 3;
            // 
            // log_out_button
            // 
            this.log_out_button.Location = new System.Drawing.Point(17, 23);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(131, 55);
            this.log_out_button.TabIndex = 4;
            this.log_out_button.Text = "Log out";
            this.log_out_button.UseVisualStyleBackColor = true;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.Location = new System.Drawing.Point(261, 23);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(0, 39);
            this.welcome_text.TabIndex = 5;
            // 
            // owed_label
            // 
            this.owed_label.AutoSize = true;
            this.owed_label.Location = new System.Drawing.Point(143, 283);
            this.owed_label.Name = "owed_label";
            this.owed_label.Size = new System.Drawing.Size(0, 16);
            this.owed_label.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 10;
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.owed_label);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.confirmation_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clock_out_button);
            this.Controls.Add(this.clock_in_button);
            this.Name = "UserHomePage";
            this.Text = "UserHomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHomePage_FormClosed);
            this.Load += new System.EventHandler(this.UserHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clock_in_button;
        private System.Windows.Forms.Button clock_out_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label confirmation_label;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Label owed_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}