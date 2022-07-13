
namespace Silkroski_C969.Forms
{
    partial class AppointmentForm
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
            this.AptCancelBtn = new System.Windows.Forms.Button();
            this.AptSaveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AptTitleTB = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.AptTitleLabel = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.AptDescLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AptCancelBtn
            // 
            this.AptCancelBtn.Location = new System.Drawing.Point(1054, 633);
            this.AptCancelBtn.Name = "AptCancelBtn";
            this.AptCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.AptCancelBtn.TabIndex = 17;
            this.AptCancelBtn.Text = "Cancel";
            this.AptCancelBtn.UseVisualStyleBackColor = true;
            // 
            // AptSaveButton
            // 
            this.AptSaveButton.Location = new System.Drawing.Point(1135, 633);
            this.AptSaveButton.Name = "AptSaveButton";
            this.AptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AptSaveButton.TabIndex = 16;
            this.AptSaveButton.Text = "Save";
            this.AptSaveButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // AptTitleTB
            // 
            this.AptTitleTB.Location = new System.Drawing.Point(118, 196);
            this.AptTitleTB.Name = "AptTitleTB";
            this.AptTitleTB.Size = new System.Drawing.Size(157, 20);
            this.AptTitleTB.TabIndex = 19;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(115, 124);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(160, 13);
            this.UserIdLabel.TabIndex = 20;
            this.UserIdLabel.Text = "Employee Handling Appointment";
            // 
            // AptTitleLabel
            // 
            this.AptTitleLabel.AutoSize = true;
            this.AptTitleLabel.Location = new System.Drawing.Point(115, 180);
            this.AptTitleLabel.Name = "AptTitleLabel";
            this.AptTitleLabel.Size = new System.Drawing.Size(93, 13);
            this.AptTitleLabel.TabIndex = 20;
            this.AptTitleLabel.Text = "Appointment Type";
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Location = new System.Drawing.Point(115, 70);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(63, 13);
            this.CustomerId.TabIndex = 22;
            this.CustomerId.Text = "Customer Id";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // AptDescLabel
            // 
            this.AptDescLabel.AutoSize = true;
            this.AptDescLabel.Location = new System.Drawing.Point(115, 245);
            this.AptDescLabel.Name = "AptDescLabel";
            this.AptDescLabel.Size = new System.Drawing.Size(101, 13);
            this.AptDescLabel.TabIndex = 24;
            this.AptDescLabel.Text = "Appointment Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 23;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AptDescLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.AptTitleLabel);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.AptTitleTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AptCancelBtn);
            this.Controls.Add(this.AptSaveButton);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AptCancelBtn;
        private System.Windows.Forms.Button AptSaveButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox AptTitleTB;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label AptTitleLabel;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label AptDescLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}