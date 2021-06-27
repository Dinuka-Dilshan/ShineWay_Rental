
namespace ShineWay.UserInterfaces
{
    partial class HomeRceptionist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeRceptionist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeUserControl1 = new ShineWay.ControlPanels.HomeUserControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserType = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.pnlSelector = new System.Windows.Forms.Panel();
            this.btnOwnerPayment = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnVehicleOwners = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.homeUserControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-8, -38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1956, 1141);
            this.panel1.TabIndex = 0;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Location = new System.Drawing.Point(89, 159);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(1700, 900);
            this.homeUserControl1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtUserType);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.pnlSelector);
            this.panel2.Controls.Add(this.btnOwnerPayment);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnPayments);
            this.panel2.Controls.Add(this.btnVehicles);
            this.panel2.Controls.Add(this.btnVehicleOwners);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnBooking);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1956, 119);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtUserType
            // 
            this.txtUserType.AutoSize = true;
            this.txtUserType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtUserType.Location = new System.Drawing.Point(1525, 69);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(43, 19);
            this.txtUserType.TabIndex = 1;
            this.txtUserType.Text = "User";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtTime.Location = new System.Drawing.Point(1766, 66);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(0, 23);
            this.txtTime.TabIndex = 1;
            // 
            // pnlSelector
            // 
            this.pnlSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.pnlSelector.Location = new System.Drawing.Point(100, 93);
            this.pnlSelector.Name = "pnlSelector";
            this.pnlSelector.Size = new System.Drawing.Size(51, 10);
            this.pnlSelector.TabIndex = 8;
            // 
            // btnOwnerPayment
            // 
            this.btnOwnerPayment.FlatAppearance.BorderSize = 0;
            this.btnOwnerPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerPayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOwnerPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnOwnerPayment.Location = new System.Drawing.Point(878, 50);
            this.btnOwnerPayment.Name = "btnOwnerPayment";
            this.btnOwnerPayment.Size = new System.Drawing.Size(155, 51);
            this.btnOwnerPayment.TabIndex = 6;
            this.btnOwnerPayment.TabStop = false;
            this.btnOwnerPayment.Text = "Owner Payment";
            this.btnOwnerPayment.UseVisualStyleBackColor = true;
            this.btnOwnerPayment.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnUsers.Location = new System.Drawing.Point(595, 50);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(62, 51);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.TabStop = false;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnPayments.Location = new System.Drawing.Point(459, 50);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(99, 51);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.TabStop = false;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnVehicles.Location = new System.Drawing.Point(1065, 50);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(90, 51);
            this.btnVehicles.TabIndex = 7;
            this.btnVehicles.TabStop = false;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVehicleOwners
            // 
            this.btnVehicleOwners.FlatAppearance.BorderSize = 0;
            this.btnVehicleOwners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleOwners.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehicleOwners.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnVehicleOwners.Location = new System.Drawing.Point(686, 50);
            this.btnVehicleOwners.Name = "btnVehicleOwners";
            this.btnVehicleOwners.Size = new System.Drawing.Size(169, 51);
            this.btnVehicleOwners.TabIndex = 5;
            this.btnVehicleOwners.TabStop = false;
            this.btnVehicleOwners.Text = "Vehicles Owners";
            this.btnVehicleOwners.UseVisualStyleBackColor = true;
            this.btnVehicleOwners.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCustomers.Location = new System.Drawing.Point(324, 50);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(104, 51);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBooking.Location = new System.Drawing.Point(198, 50);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(90, 51);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.TabStop = false;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnHome.Location = new System.Drawing.Point(89, 50);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(76, 51);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // HomeRceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1003);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeRceptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HomeRceptionist_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOwnerPayment;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnVehicleOwners;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlSelector;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtUserType;
        private ControlPanels.HomeUserControl homeUserControl1;
    }
}