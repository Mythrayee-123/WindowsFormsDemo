namespace WindowsFormsDemo
{
    partial class ListBox1
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
            this.grpCities = new System.Windows.Forms.GroupBox();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblCitiName = new System.Windows.Forms.Label();
            this.txtCitiName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.grpCities.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCities
            // 
            this.grpCities.Controls.Add(this.lstCities);
            this.grpCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCities.Location = new System.Drawing.Point(39, 63);
            this.grpCities.Name = "grpCities";
            this.grpCities.Size = new System.Drawing.Size(200, 306);
            this.grpCities.TabIndex = 0;
            this.grpCities.TabStop = false;
            this.grpCities.Text = "Cities";
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 25;
            this.lstCities.Items.AddRange(new object[] {
            "Vijayawada",
            "Hydrabad",
            "Pune",
            "New Delhi",
            "Bangalore"});
            this.lstCities.Location = new System.Drawing.Point(28, 33);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(120, 204);
            this.lstCities.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnCount);
            this.grpOptions.Controls.Add(this.btnClear);
            this.grpOptions.Controls.Add(this.btnRemove);
            this.grpOptions.Controls.Add(this.btnAdd);
            this.grpOptions.Controls.Add(this.txtCitiName);
            this.grpOptions.Controls.Add(this.lblCitiName);
            this.grpOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(324, 63);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(438, 286);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "options:";
            // 
            // lblCitiName
            // 
            this.lblCitiName.AutoSize = true;
            this.lblCitiName.Location = new System.Drawing.Point(19, 22);
            this.lblCitiName.Name = "lblCitiName";
            this.lblCitiName.Size = new System.Drawing.Size(148, 25);
            this.lblCitiName.TabIndex = 0;
            this.lblCitiName.Text = "New CitiName";
            // 
            // txtCitiName
            // 
            this.txtCitiName.Location = new System.Drawing.Point(180, 15);
            this.txtCitiName.Name = "txtCitiName";
            this.txtCitiName.Size = new System.Drawing.Size(154, 30);
            this.txtCitiName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(35, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(254, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove selected Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(35, 227);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(192, 34);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Show Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // ListBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpCities);
            this.Name = "ListBox1";
            this.Text = "ListBox1";
            this.grpCities.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCities;
        private System.Windows.Forms.ListBox lstCities;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtCitiName;
        private System.Windows.Forms.Label lblCitiName;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}