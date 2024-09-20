namespace WindowsFormsDemo
{
    partial class CalculatorExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnumberTxt = new System.Windows.Forms.TextBox();
            this.snumberTxt = new System.Windows.Forms.TextBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.addTxt = new System.Windows.Forms.Button();
            this.subTxt = new System.Windows.Forms.Button();
            this.sumTxt = new System.Windows.Forms.Button();
            this.divTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First -Number";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second-Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // fnumberTxt
            // 
            this.fnumberTxt.Location = new System.Drawing.Point(181, 66);
            this.fnumberTxt.Name = "fnumberTxt";
            this.fnumberTxt.Size = new System.Drawing.Size(100, 22);
            this.fnumberTxt.TabIndex = 3;
            // 
            // snumberTxt
            // 
            this.snumberTxt.Location = new System.Drawing.Point(181, 124);
            this.snumberTxt.Name = "snumberTxt";
            this.snumberTxt.Size = new System.Drawing.Size(100, 22);
            this.snumberTxt.TabIndex = 4;
            // 
            // resultTxt
            // 
            this.resultTxt.Location = new System.Drawing.Point(181, 188);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(100, 22);
            this.resultTxt.TabIndex = 5;
            // 
            // addTxt
            // 
            this.addTxt.Location = new System.Drawing.Point(29, 292);
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(75, 23);
            this.addTxt.TabIndex = 6;
            this.addTxt.Text = "Add";
            this.addTxt.UseVisualStyleBackColor = true;
            this.addTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // subTxt
            // 
            this.subTxt.Location = new System.Drawing.Point(125, 291);
            this.subTxt.Name = "subTxt";
            this.subTxt.Size = new System.Drawing.Size(75, 23);
            this.subTxt.TabIndex = 7;
            this.subTxt.Text = "Sub";
            this.subTxt.UseVisualStyleBackColor = true;
            this.subTxt.Click += new System.EventHandler(this.button2_Click);
            // 
            // sumTxt
            // 
            this.sumTxt.Location = new System.Drawing.Point(230, 291);
            this.sumTxt.Name = "sumTxt";
            this.sumTxt.Size = new System.Drawing.Size(75, 23);
            this.sumTxt.TabIndex = 8;
            this.sumTxt.Text = "Sum";
            this.sumTxt.UseVisualStyleBackColor = true;
            this.sumTxt.Click += new System.EventHandler(this.button3_Click);
            // 
            // divTxt
            // 
            this.divTxt.Location = new System.Drawing.Point(341, 291);
            this.divTxt.Name = "divTxt";
            this.divTxt.Size = new System.Drawing.Size(75, 23);
            this.divTxt.TabIndex = 9;
            this.divTxt.Text = "Div";
            this.divTxt.UseVisualStyleBackColor = true;
            this.divTxt.Click += new System.EventHandler(this.button4_Click);
            // 
            // CalculatorExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 383);
            this.Controls.Add(this.divTxt);
            this.Controls.Add(this.sumTxt);
            this.Controls.Add(this.subTxt);
            this.Controls.Add(this.addTxt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.snumberTxt);
            this.Controls.Add(this.fnumberTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorExample";
            this.Text = "CaliculaterExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnumberTxt;
        private System.Windows.Forms.TextBox snumberTxt;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Button addTxt;
        private System.Windows.Forms.Button subTxt;
        private System.Windows.Forms.Button sumTxt;
        private System.Windows.Forms.Button divTxt;
    }
}