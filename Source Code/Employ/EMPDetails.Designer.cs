namespace Employ
{
    partial class EMPDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.Slry = new System.Windows.Forms.Label();
            this.HDate = new System.Windows.Forms.Label();
            this.CLength = new System.Windows.Forms.Label();
            this.BName = new System.Windows.Forms.Label();
            this.JTitle = new System.Windows.Forms.Label();
            this.EID = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Slry);
            this.panel4.Controls.Add(this.HDate);
            this.panel4.Controls.Add(this.CLength);
            this.panel4.Controls.Add(this.BName);
            this.panel4.Controls.Add(this.JTitle);
            this.panel4.Controls.Add(this.EID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 43);
            this.panel4.TabIndex = 5;
            // 
            // Slry
            // 
            this.Slry.AutoSize = true;
            this.Slry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slry.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Slry.Location = new System.Drawing.Point(732, 11);
            this.Slry.Name = "Slry";
            this.Slry.Size = new System.Drawing.Size(49, 20);
            this.Slry.TabIndex = 10;
            this.Slry.Text = "Salary";
            // 
            // HDate
            // 
            this.HDate.AutoSize = true;
            this.HDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HDate.Location = new System.Drawing.Point(617, 11);
            this.HDate.Name = "HDate";
            this.HDate.Size = new System.Drawing.Size(73, 20);
            this.HDate.TabIndex = 9;
            this.HDate.Text = "Hire Date";
            // 
            // CLength
            // 
            this.CLength.AutoSize = true;
            this.CLength.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLength.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CLength.Location = new System.Drawing.Point(514, 11);
            this.CLength.Name = "CLength";
            this.CLength.Size = new System.Drawing.Size(25, 20);
            this.CLength.TabIndex = 8;
            this.CLength.Text = "32";
            // 
            // BName
            // 
            this.BName.AutoSize = true;
            this.BName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BName.Location = new System.Drawing.Point(327, 11);
            this.BName.Name = "BName";
            this.BName.Size = new System.Drawing.Size(98, 20);
            this.BName.TabIndex = 7;
            this.BName.Text = "Branch Name";
            // 
            // JTitle
            // 
            this.JTitle.AutoSize = true;
            this.JTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.JTitle.Location = new System.Drawing.Point(207, 11);
            this.JTitle.Name = "JTitle";
            this.JTitle.Size = new System.Drawing.Size(65, 20);
            this.JTitle.TabIndex = 6;
            this.JTitle.Text = "Job Title";
            // 
            // EID
            // 
            this.EID.AutoSize = true;
            this.EID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EID.Location = new System.Drawing.Point(46, 11);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(90, 20);
            this.EID.TabIndex = 5;
            this.EID.Text = "EmployeeID";
            // 
            // EMPDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "EMPDetails";
            this.Size = new System.Drawing.Size(833, 43);
            this.Load += new System.EventHandler(this.EMPDetails_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Slry;
        private System.Windows.Forms.Label HDate;
        private System.Windows.Forms.Label CLength;
        private System.Windows.Forms.Label BName;
        private System.Windows.Forms.Label JTitle;
        private System.Windows.Forms.Label EID;
    }
}
