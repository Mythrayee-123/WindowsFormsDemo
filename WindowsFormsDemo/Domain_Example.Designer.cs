namespace WindowsFormsDemo
{
    partial class Domain_Example
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
            this.txtMyText = new System.Windows.Forms.TextBox();
            this.donFont = new System.Windows.Forms.DomainUpDown();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMyText
            // 
            this.txtMyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyText.Location = new System.Drawing.Point(201, 42);
            this.txtMyText.Name = "txtMyText";
            this.txtMyText.Size = new System.Drawing.Size(349, 30);
            this.txtMyText.TabIndex = 0;
            // 
            // donFont
            // 
            this.donFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donFont.Items.Add("Times New Roman");
            this.donFont.Items.Add(" Tahoma");
            this.donFont.Items.Add(" Arial");
            this.donFont.Items.Add(" Arial Black");
            this.donFont.Items.Add("Century Gothic");
            this.donFont.Items.Add("Trebuchet MS ");
            this.donFont.Items.Add("Palatino Linotype");
            this.donFont.Location = new System.Drawing.Point(291, 142);
            this.donFont.Name = "donFont";
            this.donFont.Size = new System.Drawing.Size(120, 30);
            this.donFont.TabIndex = 1;
            this.donFont.Text = "Tahoma";
            this.donFont.SelectedItemChanged += new System.EventHandler(this.donFont_SelectedItemChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(76, 142);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(55, 25);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Font";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(76, 244);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 25);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // numSize
            // 
            this.numSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSize.Location = new System.Drawing.Point(291, 244);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 30);
            this.numSize.TabIndex = 5;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // Domain_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.donFont);
            this.Controls.Add(this.txtMyText);
            this.Name = "Domain_Example";
            this.Text = "Domain_Example";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMyText;
        private System.Windows.Forms.DomainUpDown donFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown numSize;
    }
}