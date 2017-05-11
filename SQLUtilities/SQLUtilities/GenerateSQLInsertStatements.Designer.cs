namespace SQLUtilities
{
    partial class GenerateSQLInsertStatements
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblRTableName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblFirstColumn = new System.Windows.Forms.Label();
            this.txtFirstColumn = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(111, 280);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Scripts";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblRTableName
            // 
            this.lblRTableName.AutoSize = true;
            this.lblRTableName.Location = new System.Drawing.Point(57, 86);
            this.lblRTableName.Name = "lblRTableName";
            this.lblRTableName.Size = new System.Drawing.Size(65, 13);
            this.lblRTableName.TabIndex = 1;
            this.lblRTableName.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(160, 86);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(200, 20);
            this.txtTableName.TabIndex = 2;
            // 
            // lblFirstColumn
            // 
            this.lblFirstColumn.AutoSize = true;
            this.lblFirstColumn.Location = new System.Drawing.Point(58, 134);
            this.lblFirstColumn.Name = "lblFirstColumn";
            this.lblFirstColumn.Size = new System.Drawing.Size(64, 13);
            this.lblFirstColumn.TabIndex = 3;
            this.lblFirstColumn.Text = "First Column";
            // 
            // txtFirstColumn
            // 
            this.txtFirstColumn.Location = new System.Drawing.Point(160, 131);
            this.txtFirstColumn.Name = "txtFirstColumn";
            this.txtFirstColumn.Size = new System.Drawing.Size(200, 20);
            this.txtFirstColumn.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(59, 176);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(58, 222);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(160, 170);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 9;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(160, 215);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 10;
            // 
            // GenerateSQLInsertStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 392);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtFirstColumn);
            this.Controls.Add(this.lblFirstColumn);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.lblRTableName);
            this.Controls.Add(this.btnGenerate);
            this.Name = "GenerateSQLInsertStatements";
            this.Text = "SQLUtilities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblRTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblFirstColumn;
        private System.Windows.Forms.TextBox txtFirstColumn;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
    }
}

