
namespace PipitGasConversion
{
    partial class EntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstall = new System.Windows.Forms.TextBox();
            this.txtToday = new System.Windows.Forms.TextBox();
            this.txtDaysInstall = new System.Windows.Forms.TextBox();
            this.txtDeltaPerDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installation Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today\'s Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days Installed:";
            // 
            // txtInstall
            // 
            this.txtInstall.BackColor = System.Drawing.SystemColors.Menu;
            this.txtInstall.Location = new System.Drawing.Point(136, 35);
            this.txtInstall.Name = "txtInstall";
            this.txtInstall.ReadOnly = true;
            this.txtInstall.Size = new System.Drawing.Size(115, 23);
            this.txtInstall.TabIndex = 2;
            // 
            // txtToday
            // 
            this.txtToday.BackColor = System.Drawing.SystemColors.Menu;
            this.txtToday.Location = new System.Drawing.Point(135, 64);
            this.txtToday.Name = "txtToday";
            this.txtToday.ReadOnly = true;
            this.txtToday.Size = new System.Drawing.Size(115, 23);
            this.txtToday.TabIndex = 3;
            // 
            // txtDaysInstall
            // 
            this.txtDaysInstall.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDaysInstall.Location = new System.Drawing.Point(136, 93);
            this.txtDaysInstall.Name = "txtDaysInstall";
            this.txtDaysInstall.ReadOnly = true;
            this.txtDaysInstall.Size = new System.Drawing.Size(115, 23);
            this.txtDaysInstall.TabIndex = 4;
            // 
            // txtDeltaPerDay
            // 
            this.txtDeltaPerDay.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDeltaPerDay.Location = new System.Drawing.Point(135, 122);
            this.txtDeltaPerDay.Name = "txtDeltaPerDay";
            this.txtDeltaPerDay.ReadOnly = true;
            this.txtDeltaPerDay.Size = new System.Drawing.Size(115, 23);
            this.txtDeltaPerDay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delta Per Day";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(289, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meter Reading";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(160, 78);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(147, 33);
            this.txtOutput.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Reading to Supplier:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(160, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(147, 23);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reading from Pipit:";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDeltaPerDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDaysInstall);
            this.Controls.Add(this.txtToday);
            this.Controls.Add(this.txtInstall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EntryForm";
            this.Text = "Pipit Gas Reading Conversion";
            this.Activated += new System.EventHandler(this.EntryForm_Activated);
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstall;
        private System.Windows.Forms.TextBox txtToday;
        private System.Windows.Forms.TextBox txtDaysInstall;
        private System.Windows.Forms.TextBox txtDeltaPerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label5;
    }
}

