namespace WindowsFormsDemo
{
    partial class Datetime_Example
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
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(73, 56);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(150, 25);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Set date of Birth";
            // 
            // dtpickerDOB
            // 
            this.dtpickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerDOB.Location = new System.Drawing.Point(389, 56);
            this.dtpickerDOB.Name = "dtpickerDOB";
            this.dtpickerDOB.Size = new System.Drawing.Size(200, 30);
            this.dtpickerDOB.TabIndex = 1;
            this.dtpickerDOB.ValueChanged += new System.EventHandler(this.dtpickerDOB_ValueChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(73, 185);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 25);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(389, 197);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(232, 30);
            this.txtage.TabIndex = 3;
            // 
            // Datetime_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dtpickerDOB);
            this.Controls.Add(this.lblDOB);
            this.Name = "Datetime_Example";
            this.Text = "Datetime_Example";
            this.Load += new System.EventHandler(this.Datetime_Example_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpickerDOB;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtage;
    }
}