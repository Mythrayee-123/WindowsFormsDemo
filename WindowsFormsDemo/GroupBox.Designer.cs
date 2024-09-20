namespace WindowsFormsDemo
{
    partial class GroupBox
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
            this.txtMytextBox = new System.Windows.Forms.TextBox();
            this.grpBackgroundColor = new System.Windows.Forms.GroupBox();
            this.grpForeGroundColor = new System.Windows.Forms.GroupBox();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.grpBackgroundColor.SuspendLayout();
            this.grpForeGroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMytextBox
            // 
            this.txtMytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMytextBox.Location = new System.Drawing.Point(119, 31);
            this.txtMytextBox.Name = "txtMytextBox";
            this.txtMytextBox.Size = new System.Drawing.Size(445, 30);
            this.txtMytextBox.TabIndex = 0;
            // 
            // grpBackgroundColor
            // 
            this.grpBackgroundColor.Controls.Add(this.rbYellow);
            this.grpBackgroundColor.Controls.Add(this.rbRed);
            this.grpBackgroundColor.Controls.Add(this.rbWhite);
            this.grpBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBackgroundColor.Location = new System.Drawing.Point(24, 125);
            this.grpBackgroundColor.Name = "grpBackgroundColor";
            this.grpBackgroundColor.Size = new System.Drawing.Size(268, 240);
            this.grpBackgroundColor.TabIndex = 1;
            this.grpBackgroundColor.TabStop = false;
            this.grpBackgroundColor.Text = "Text Box Background color";
            // 
            // grpForeGroundColor
            // 
            this.grpForeGroundColor.Controls.Add(this.rbOrange);
            this.grpForeGroundColor.Controls.Add(this.rbGreen);
            this.grpForeGroundColor.Controls.Add(this.rbBlue);
            this.grpForeGroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpForeGroundColor.Location = new System.Drawing.Point(456, 125);
            this.grpForeGroundColor.Name = "grpForeGroundColor";
            this.grpForeGroundColor.Size = new System.Drawing.Size(305, 212);
            this.grpForeGroundColor.TabIndex = 2;
            this.grpForeGroundColor.TabStop = false;
            this.grpForeGroundColor.Text = "TextBox ForeGround Color";
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(27, 42);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(84, 29);
            this.rbWhite.TabIndex = 0;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(27, 90);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(68, 29);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(27, 146);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(90, 29);
            this.rbYellow.TabIndex = 2;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.rbYellow_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(28, 42);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(72, 29);
            this.rbBlue.TabIndex = 0;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(28, 105);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(87, 29);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(28, 159);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(99, 29);
            this.rbOrange.TabIndex = 2;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpForeGroundColor);
            this.Controls.Add(this.grpBackgroundColor);
            this.Controls.Add(this.txtMytextBox);
            this.Name = "GroupBox";
            this.Text = "GroupBox";
            this.grpBackgroundColor.ResumeLayout(false);
            this.grpBackgroundColor.PerformLayout();
            this.grpForeGroundColor.ResumeLayout(false);
            this.grpForeGroundColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMytextBox;
        private System.Windows.Forms.GroupBox grpBackgroundColor;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.GroupBox grpForeGroundColor;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
    }
}