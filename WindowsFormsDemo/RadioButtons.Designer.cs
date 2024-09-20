namespace WindowsFormsDemo
{
    partial class RadioButtons
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
            this.lblColor = new System.Windows.Forms.Label();
            this.rbBeige = new System.Windows.Forms.RadioButton();
            this.rbLightgreen = new System.Windows.Forms.RadioButton();
            this.rbLightyellow = new System.Windows.Forms.RadioButton();
            this.rbBisque = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(216, 32);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(276, 26);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Select Background Color";
            // 
            // rbBeige
            // 
            this.rbBeige.AutoSize = true;
            this.rbBeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeige.Location = new System.Drawing.Point(192, 93);
            this.rbBeige.Name = "rbBeige";
            this.rbBeige.Size = new System.Drawing.Size(94, 30);
            this.rbBeige.TabIndex = 1;
            this.rbBeige.TabStop = true;
            this.rbBeige.Text = "Beige";
            this.rbBeige.UseVisualStyleBackColor = true;
            this.rbBeige.CheckedChanged += new System.EventHandler(this.rbBeige_CheckedChanged);
            // 
            // rbLightgreen
            // 
            this.rbLightgreen.AutoSize = true;
            this.rbLightgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLightgreen.Location = new System.Drawing.Point(192, 154);
            this.rbLightgreen.Name = "rbLightgreen";
            this.rbLightgreen.Size = new System.Drawing.Size(150, 30);
            this.rbLightgreen.TabIndex = 2;
            this.rbLightgreen.TabStop = true;
            this.rbLightgreen.Text = "LightGreen";
            this.rbLightgreen.UseVisualStyleBackColor = true;
            this.rbLightgreen.CheckedChanged += new System.EventHandler(this.rbLightgreen_CheckedChanged);
            // 
            // rbLightyellow
            // 
            this.rbLightyellow.AutoSize = true;
            this.rbLightyellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLightyellow.Location = new System.Drawing.Point(192, 209);
            this.rbLightyellow.Name = "rbLightyellow";
            this.rbLightyellow.Size = new System.Drawing.Size(157, 30);
            this.rbLightyellow.TabIndex = 3;
            this.rbLightyellow.TabStop = true;
            this.rbLightyellow.Text = "LightYellow";
            this.rbLightyellow.UseVisualStyleBackColor = true;
            this.rbLightyellow.CheckedChanged += new System.EventHandler(this.rbLightyellow_CheckedChanged);
            // 
            // rbBisque
            // 
            this.rbBisque.AutoSize = true;
            this.rbBisque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBisque.Location = new System.Drawing.Point(192, 262);
            this.rbBisque.Name = "rbBisque";
            this.rbBisque.Size = new System.Drawing.Size(106, 30);
            this.rbBisque.TabIndex = 4;
            this.rbBisque.TabStop = true;
            this.rbBisque.Text = "Bisque";
            this.rbBisque.UseVisualStyleBackColor = true;
            this.rbBisque.CheckedChanged += new System.EventHandler(this.rbBisque_CheckedChanged);
            // 
            // RadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbBisque);
            this.Controls.Add(this.rbLightyellow);
            this.Controls.Add(this.rbLightgreen);
            this.Controls.Add(this.rbBeige);
            this.Controls.Add(this.lblColor);
            this.Name = "RadioButtons";
            this.Text = "RadioButtons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton rbBeige;
        private System.Windows.Forms.RadioButton rbLightgreen;
        private System.Windows.Forms.RadioButton rbLightyellow;
        private System.Windows.Forms.RadioButton rbBisque;
    }
}