namespace WindowsFormsDemo
{
    partial class TextBox
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
            this.lblSourceText = new System.Windows.Forms.Label();
            this.lblDestinationText = new System.Windows.Forms.Label();
            this.txtSourceText = new System.Windows.Forms.TextBox();
            this.txtDestinationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSourceText
            // 
            this.lblSourceText.AutoSize = true;
            this.lblSourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceText.Location = new System.Drawing.Point(141, 56);
            this.lblSourceText.Name = "lblSourceText";
            this.lblSourceText.Size = new System.Drawing.Size(145, 25);
            this.lblSourceText.TabIndex = 0;
            this.lblSourceText.Text = "Enter your Text";
            // 
            // lblDestinationText
            // 
            this.lblDestinationText.AutoSize = true;
            this.lblDestinationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationText.Location = new System.Drawing.Point(144, 160);
            this.lblDestinationText.Name = "lblDestinationText";
            this.lblDestinationText.Size = new System.Drawing.Size(119, 25);
            this.lblDestinationText.TabIndex = 1;
            this.lblDestinationText.Text = "Copied Text";
            // 
            // txtSourceText
            // 
            this.txtSourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceText.Location = new System.Drawing.Point(390, 56);
            this.txtSourceText.Name = "txtSourceText";
            this.txtSourceText.Size = new System.Drawing.Size(202, 30);
            this.txtSourceText.TabIndex = 2;
            this.txtSourceText.TextChanged += new System.EventHandler(this.txtSourceText_TextChanged);
            // 
            // txtDestinationText
            // 
            this.txtDestinationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationText.Location = new System.Drawing.Point(390, 153);
            this.txtDestinationText.Name = "txtDestinationText";
            this.txtDestinationText.ReadOnly = true;
            this.txtDestinationText.Size = new System.Drawing.Size(202, 30);
            this.txtDestinationText.TabIndex = 3;
            // 
            // TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDestinationText);
            this.Controls.Add(this.txtSourceText);
            this.Controls.Add(this.lblDestinationText);
            this.Controls.Add(this.lblSourceText);
            this.Name = "TextBox";
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceText;
        private System.Windows.Forms.Label lblDestinationText;
        private System.Windows.Forms.TextBox txtSourceText;
        private System.Windows.Forms.TextBox txtDestinationText;
    }
}