namespace PHP_Solution
{
    partial class frm_rootDir
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
            this.btn_newSalesReport = new System.Windows.Forms.Button();
            this.btn_editSalesData = new System.Windows.Forms.Button();
            this.btn_disData = new System.Windows.Forms.Button();
            this.btn_disReport = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_disPrediction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newSalesReport
            // 
            this.btn_newSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newSalesReport.Location = new System.Drawing.Point(218, 22);
            this.btn_newSalesReport.Name = "btn_newSalesReport";
            this.btn_newSalesReport.Size = new System.Drawing.Size(152, 100);
            this.btn_newSalesReport.TabIndex = 0;
            this.btn_newSalesReport.Text = "New Sales Report";
            this.btn_newSalesReport.UseVisualStyleBackColor = true;
            // 
            // btn_editSalesData
            // 
            this.btn_editSalesData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSalesData.Location = new System.Drawing.Point(218, 268);
            this.btn_editSalesData.Name = "btn_editSalesData";
            this.btn_editSalesData.Size = new System.Drawing.Size(152, 100);
            this.btn_editSalesData.TabIndex = 1;
            this.btn_editSalesData.Text = "Edit Sales Data";
            this.btn_editSalesData.UseVisualStyleBackColor = true;
            // 
            // btn_disData
            // 
            this.btn_disData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disData.Location = new System.Drawing.Point(27, 144);
            this.btn_disData.Name = "btn_disData";
            this.btn_disData.Size = new System.Drawing.Size(152, 100);
            this.btn_disData.TabIndex = 3;
            this.btn_disData.Text = "Display Data";
            this.btn_disData.UseVisualStyleBackColor = true;
            // 
            // btn_disReport
            // 
            this.btn_disReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disReport.Location = new System.Drawing.Point(218, 144);
            this.btn_disReport.Name = "btn_disReport";
            this.btn_disReport.Size = new System.Drawing.Size(152, 100);
            this.btn_disReport.TabIndex = 4;
            this.btn_disReport.Text = "Display Report";
            this.btn_disReport.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(503, 345);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_disPrediction
            // 
            this.btn_disPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disPrediction.Location = new System.Drawing.Point(408, 144);
            this.btn_disPrediction.Name = "btn_disPrediction";
            this.btn_disPrediction.Size = new System.Drawing.Size(152, 100);
            this.btn_disPrediction.TabIndex = 6;
            this.btn_disPrediction.Text = "Display Predictions";
            this.btn_disPrediction.UseVisualStyleBackColor = true;
            this.btn_disPrediction.Click += new System.EventHandler(this.btn_disPrediction_Click);
            // 
            // frm_rootDir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 395);
            this.Controls.Add(this.btn_disPrediction);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_disReport);
            this.Controls.Add(this.btn_disData);
            this.Controls.Add(this.btn_editSalesData);
            this.Controls.Add(this.btn_newSalesReport);
            this.Name = "frm_rootDir";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newSalesReport;
        private System.Windows.Forms.Button btn_editSalesData;
        private System.Windows.Forms.Button btn_disData;
        private System.Windows.Forms.Button btn_disReport;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_disPrediction;
    }
}

