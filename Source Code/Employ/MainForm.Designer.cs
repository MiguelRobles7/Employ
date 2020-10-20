namespace Employ
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeesDataButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeesData = new System.Windows.Forms.TabPage();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.TabManager = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(80)))), ((int)(((byte)(204)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(248, 720);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 177);
            this.panel2.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.Animated = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.CustomImages.Image = global::Employ.Properties.Resources.delete_480px;
            this.ExitButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExitButton.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.ImageSize = new System.Drawing.Size(0, 0);
            this.ExitButton.Location = new System.Drawing.Point(19, 105);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(140, 40);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Quit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.CustomImages.Image = global::Employ.Properties.Resources.minimize_window_480px;
            this.MinimizeButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MinimizeButton.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.MinimizeButton.CustomImages.Parent = this.MinimizeButton;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(0, 0);
            this.MinimizeButton.Location = new System.Drawing.Point(19, 59);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(162, 40);
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.Text = "Minimize";
            this.MinimizeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Employ.Properties.Resources.permanent_job_480px;
            this.pictureBox1.Location = new System.Drawing.Point(74, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.AddEmployeeButton);
            this.panel1.Controls.Add(this.EmployeesDataButton);
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 297);
            this.panel1.TabIndex = 11;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Animated = true;
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.CheckedState.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployeeButton.CustomImages.Image = global::Employ.Properties.Resources.resume_480px;
            this.AddEmployeeButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddEmployeeButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -50);
            this.AddEmployeeButton.CustomImages.ImageSize = new System.Drawing.Size(70, 70);
            this.AddEmployeeButton.CustomImages.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.FillColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.HoverState.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.ImageSize = new System.Drawing.Size(0, 0);
            this.AddEmployeeButton.Location = new System.Drawing.Point(20, 24);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.ShadowDecoration.Parent = this.AddEmployeeButton;
            this.AddEmployeeButton.Size = new System.Drawing.Size(208, 115);
            this.AddEmployeeButton.TabIndex = 7;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.TextOffset = new System.Drawing.Point(0, 40);
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // EmployeesDataButton
            // 
            this.EmployeesDataButton.Animated = true;
            this.EmployeesDataButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesDataButton.CheckedState.Parent = this.EmployeesDataButton;
            this.EmployeesDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeesDataButton.CustomImages.Image = global::Employ.Properties.Resources.identification_documents_480px;
            this.EmployeesDataButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmployeesDataButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -50);
            this.EmployeesDataButton.CustomImages.ImageSize = new System.Drawing.Size(80, 80);
            this.EmployeesDataButton.CustomImages.Parent = this.EmployeesDataButton;
            this.EmployeesDataButton.FillColor = System.Drawing.Color.Transparent;
            this.EmployeesDataButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesDataButton.ForeColor = System.Drawing.Color.White;
            this.EmployeesDataButton.HoverState.Parent = this.EmployeesDataButton;
            this.EmployeesDataButton.ImageSize = new System.Drawing.Size(0, 0);
            this.EmployeesDataButton.Location = new System.Drawing.Point(20, 145);
            this.EmployeesDataButton.Name = "EmployeesDataButton";
            this.EmployeesDataButton.ShadowDecoration.Parent = this.EmployeesDataButton;
            this.EmployeesDataButton.Size = new System.Drawing.Size(208, 115);
            this.EmployeesDataButton.TabIndex = 5;
            this.EmployeesDataButton.Text = "Employees Data";
            this.EmployeesDataButton.TextOffset = new System.Drawing.Point(0, 40);
            this.EmployeesDataButton.Click += new System.EventHandler(this.EmployeesDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "To give work, to give futures";
            // 
            // EmployeesData
            // 
            this.EmployeesData.Location = new System.Drawing.Point(4, 5);
            this.EmployeesData.Name = "EmployeesData";
            this.EmployeesData.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesData.Size = new System.Drawing.Size(857, 732);
            this.EmployeesData.TabIndex = 1;
            this.EmployeesData.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(4, 5);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(857, 732);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // TabManager
            // 
            this.TabManager.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabManager.Controls.Add(this.EmployeesData);
            this.TabManager.Controls.Add(this.AddEmployee);
            this.TabManager.Controls.Add(this.Start);
            this.TabManager.ItemSize = new System.Drawing.Size(0, 1);
            this.TabManager.Location = new System.Drawing.Point(242, -10);
            this.TabManager.Margin = new System.Windows.Forms.Padding(0);
            this.TabManager.Name = "TabManager";
            this.TabManager.Padding = new System.Drawing.Point(0, 0);
            this.TabManager.SelectedIndex = 0;
            this.TabManager.Size = new System.Drawing.Size(865, 741);
            this.TabManager.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(857, 732);
            this.Start.TabIndex = 2;
            this.Start.Text = "tabPage1";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.TabManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Button EmployeesDataButton;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private System.Windows.Forms.TabPage EmployeesData;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.TabControl TabManager;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage Start;
    }
}

