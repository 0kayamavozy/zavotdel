namespace diplom
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonLBL = new System.Windows.Forms.Label();
            this.AvatarPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainBTN = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.InClassroomBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ProgressBTN = new Guna.UI2.WinForms.Guna2Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PersonLBL);
            this.panel3.Controls.Add(this.AvatarPB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(851, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 65);
            this.panel3.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 9);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(82, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Выход";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Зав. Отделением";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PersonLBL
            // 
            this.PersonLBL.AutoSize = true;
            this.PersonLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonLBL.ForeColor = System.Drawing.Color.White;
            this.PersonLBL.Location = new System.Drawing.Point(100, 9);
            this.PersonLBL.Name = "PersonLBL";
            this.PersonLBL.Size = new System.Drawing.Size(194, 20);
            this.PersonLBL.TabIndex = 3;
            this.PersonLBL.Text = "Фамилия Имя Отчество";
            this.PersonLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AvatarPB
            // 
            this.AvatarPB.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPB.Image")));
            this.AvatarPB.ImageRotate = 0F;
            this.AvatarPB.Location = new System.Drawing.Point(310, 1);
            this.AvatarPB.Name = "AvatarPB";
            this.AvatarPB.Size = new System.Drawing.Size(65, 65);
            this.AvatarPB.TabIndex = 2;
            this.AvatarPB.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MainBTN);
            this.flowLayoutPanel1.Controls.Add(this.StudentsBTN);
            this.flowLayoutPanel1.Controls.Add(this.InClassroomBTN);
            this.flowLayoutPanel1.Controls.Add(this.ProgressBTN);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(845, 65);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MainBTN
            // 
            this.MainBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.MainBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MainBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MainBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MainBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MainBTN.FillColor = System.Drawing.Color.RoyalBlue;
            this.MainBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainBTN.ForeColor = System.Drawing.Color.White;
            this.MainBTN.Image = ((System.Drawing.Image)(resources.GetObject("MainBTN.Image")));
            this.MainBTN.ImageOffset = new System.Drawing.Point(-5, 0);
            this.MainBTN.ImageSize = new System.Drawing.Size(35, 35);
            this.MainBTN.Location = new System.Drawing.Point(3, 3);
            this.MainBTN.Name = "MainBTN";
            this.MainBTN.Size = new System.Drawing.Size(200, 59);
            this.MainBTN.TabIndex = 0;
            this.MainBTN.Text = "Главное";
            this.MainBTN.Click += new System.EventHandler(this.MainBTN_Click);
            // 
            // StudentsBTN
            // 
            this.StudentsBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.StudentsBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentsBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentsBTN.FillColor = System.Drawing.Color.RoyalBlue;
            this.StudentsBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StudentsBTN.ForeColor = System.Drawing.Color.White;
            this.StudentsBTN.Image = ((System.Drawing.Image)(resources.GetObject("StudentsBTN.Image")));
            this.StudentsBTN.ImageOffset = new System.Drawing.Point(-7, 0);
            this.StudentsBTN.ImageSize = new System.Drawing.Size(35, 40);
            this.StudentsBTN.Location = new System.Drawing.Point(209, 3);
            this.StudentsBTN.Name = "StudentsBTN";
            this.StudentsBTN.Size = new System.Drawing.Size(200, 59);
            this.StudentsBTN.TabIndex = 3;
            this.StudentsBTN.Text = "Студенты";
            this.StudentsBTN.Click += new System.EventHandler(this.StudentsBTN_Click);
            // 
            // InClassroomBTN
            // 
            this.InClassroomBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.InClassroomBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InClassroomBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InClassroomBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InClassroomBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InClassroomBTN.FillColor = System.Drawing.Color.RoyalBlue;
            this.InClassroomBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InClassroomBTN.ForeColor = System.Drawing.Color.White;
            this.InClassroomBTN.Image = ((System.Drawing.Image)(resources.GetObject("InClassroomBTN.Image")));
            this.InClassroomBTN.ImageOffset = new System.Drawing.Point(-5, 0);
            this.InClassroomBTN.ImageSize = new System.Drawing.Size(35, 35);
            this.InClassroomBTN.Location = new System.Drawing.Point(415, 3);
            this.InClassroomBTN.Name = "InClassroomBTN";
            this.InClassroomBTN.Size = new System.Drawing.Size(200, 59);
            this.InClassroomBTN.TabIndex = 1;
            this.InClassroomBTN.Text = "Посещаемость";
            this.InClassroomBTN.Click += new System.EventHandler(this.InClassroomBTN_Click);
            // 
            // ProgressBTN
            // 
            this.ProgressBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.ProgressBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProgressBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProgressBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProgressBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProgressBTN.FillColor = System.Drawing.Color.RoyalBlue;
            this.ProgressBTN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBTN.ForeColor = System.Drawing.Color.White;
            this.ProgressBTN.Image = ((System.Drawing.Image)(resources.GetObject("ProgressBTN.Image")));
            this.ProgressBTN.ImageOffset = new System.Drawing.Point(-5, -3);
            this.ProgressBTN.ImageSize = new System.Drawing.Size(35, 35);
            this.ProgressBTN.Location = new System.Drawing.Point(621, 3);
            this.ProgressBTN.Name = "ProgressBTN";
            this.ProgressBTN.Size = new System.Drawing.Size(200, 59);
            this.ProgressBTN.TabIndex = 2;
            this.ProgressBTN.Text = "Успеваемость";
            this.ProgressBTN.Click += new System.EventHandler(this.ProgressBTN_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 106);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(1243, 617);
            this.MainContentPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.guna2ControlBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1243, 41);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.BorderRadius = 1;
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1195, 6);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 723);
            this.ControlBox = false;
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Главное окно ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPB)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button MainBTN;
        private Guna.UI2.WinForms.Guna2Button StudentsBTN;
        private Guna.UI2.WinForms.Guna2Button InClassroomBTN;
        private Guna.UI2.WinForms.Guna2Button ProgressBTN;
        private Guna.UI2.WinForms.Guna2PictureBox AvatarPB;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Label PersonLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

