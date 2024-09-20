namespace WindowsFormsDemo
{
    partial class ListBox
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
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblCoursePromt = new System.Windows.Forms.Label();
            this.lblIndexPromp = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblCourseIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCourse
            // 
            this.lstCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.ItemHeight = 25;
            this.lstCourse.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Oracle",
            "SQL",
            "VB",
            "Visual C++",
            "MS.Net",
            "Testing tools"});
            this.lstCourse.Location = new System.Drawing.Point(43, 79);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(145, 254);
            this.lstCourse.TabIndex = 0;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(38, 51);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(196, 25);
            this.lblSelectCourse.TabIndex = 1;
            this.lblSelectCourse.Text = "Select Courses here:";
            // 
            // lblCoursePromt
            // 
            this.lblCoursePromt.AutoSize = true;
            this.lblCoursePromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePromt.Location = new System.Drawing.Point(286, 106);
            this.lblCoursePromt.Name = "lblCoursePromt";
            this.lblCoursePromt.Size = new System.Drawing.Size(164, 25);
            this.lblCoursePromt.TabIndex = 2;
            this.lblCoursePromt.Text = "Selected Course:";
            // 
            // lblIndexPromp
            // 
            this.lblIndexPromp.AutoSize = true;
            this.lblIndexPromp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexPromp.Location = new System.Drawing.Point(289, 207);
            this.lblIndexPromp.Name = "lblIndexPromp";
            this.lblIndexPromp.Size = new System.Drawing.Size(217, 25);
            this.lblIndexPromp.TabIndex = 3;
            this.lblIndexPromp.Text = "Selected Course Index:";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCourse.Location = new System.Drawing.Point(581, 106);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(153, 25);
            this.lblSelectedCourse.TabIndex = 4;
            this.lblSelectedCourse.Text = "SelectedCourse";
            this.lblSelectedCourse.Click += new System.EventHandler(this.lblSelectedCourse_Click);
            // 
            // lblCourseIndex
            // 
            this.lblCourseIndex.AutoSize = true;
            this.lblCourseIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseIndex.Location = new System.Drawing.Point(594, 207);
            this.lblCourseIndex.Name = "lblCourseIndex";
            this.lblCourseIndex.Size = new System.Drawing.Size(124, 25);
            this.lblCourseIndex.TabIndex = 5;
            this.lblCourseIndex.Text = "CourseIndex";
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCourseIndex);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblIndexPromp);
            this.Controls.Add(this.lblCoursePromt);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lstCourse);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblCoursePromt;
        private System.Windows.Forms.Label lblIndexPromp;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblCourseIndex;
    }
}