
namespace ShineWay
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.butReset = new System.Windows.Forms.Button();
            this.txtSea = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpED = new System.Windows.Forms.DateTimePicker();
            this.txtSO = new System.Windows.Forms.TextBox();
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtVRN = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingID,
            this.vehicleNumber,
            this.licenseNumber,
            this.customerNIC,
            this.name,
            this.startDate});
            this.dataGridView1.Location = new System.Drawing.Point(594, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 402);
            this.dataGridView1.TabIndex = 56;
            // 
            // bookingID
            // 
            this.bookingID.HeaderText = "Booking ID";
            this.bookingID.MinimumWidth = 6;
            this.bookingID.Name = "bookingID";
            this.bookingID.Width = 125;
            // 
            // vehicleNumber
            // 
            this.vehicleNumber.HeaderText = "Vehicle Number";
            this.vehicleNumber.MinimumWidth = 6;
            this.vehicleNumber.Name = "vehicleNumber";
            this.vehicleNumber.Width = 125;
            // 
            // licenseNumber
            // 
            this.licenseNumber.HeaderText = "License Number";
            this.licenseNumber.MinimumWidth = 6;
            this.licenseNumber.Name = "licenseNumber";
            this.licenseNumber.Width = 125;
            // 
            // customerNIC
            // 
            this.customerNIC.HeaderText = "Customer NIC";
            this.customerNIC.MinimumWidth = 6;
            this.customerNIC.Name = "customerNIC";
            this.customerNIC.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Staring Date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.Width = 125;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(674, 560);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 29);
            this.btnSubmit.TabIndex = 55;
            this.btnSubmit.Text = "Submit and Print";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(931, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 29);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update and Print";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(674, 505);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(144, 29);
            this.butReset.TabIndex = 53;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            // 
            // txtSea
            // 
            this.txtSea.Location = new System.Drawing.Point(870, 29);
            this.txtSea.Name = "txtSea";
            this.txtSea.Size = new System.Drawing.Size(224, 27);
            this.txtSea.TabIndex = 52;
            this.txtSea.Visible = false;
            this.txtSea.MouseHover += new System.EventHandler(this.txtSea_MouseHover);
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(321, 484);
            this.txtDis.Multiline = true;
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(253, 111);
            this.txtDis.TabIndex = 51;
            this.txtDis.TextChanged += new System.EventHandler(this.txtDis_TextChanged);
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(321, 439);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(253, 27);
            this.txtAP.TabIndex = 50;
            this.txtAP.TextChanged += new System.EventHandler(this.txtAP_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(321, 394);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(253, 27);
            this.txtDA.TabIndex = 49;
            this.txtDA.TextChanged += new System.EventHandler(this.txtDA_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hourly basis",
            "Daily Basis",
            "Weekly Basis",
            "Monthly Basis"});
            this.comboBox1.Location = new System.Drawing.Point(321, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 28);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpED
            // 
            this.dtpED.Location = new System.Drawing.Point(321, 303);
            this.dtpED.Name = "dtpED";
            this.dtpED.Size = new System.Drawing.Size(253, 27);
            this.dtpED.TabIndex = 47;
            this.dtpED.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtSO
            // 
            this.txtSO.Location = new System.Drawing.Point(321, 258);
            this.txtSO.Name = "txtSO";
            this.txtSO.Size = new System.Drawing.Size(253, 27);
            this.txtSO.TabIndex = 46;
            this.txtSO.TextChanged += new System.EventHandler(this.txtSO_TextChanged);
            // 
            // dtpSD
            // 
            this.dtpSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSD.Location = new System.Drawing.Point(321, 213);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(253, 27);
            this.dtpSD.TabIndex = 45;
            this.dtpSD.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            this.dtpSD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(321, 168);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(253, 27);
            this.txtLN.TabIndex = 44;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(321, 123);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(253, 27);
            this.txtCNIC.TabIndex = 43;
            this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
            // 
            // txtVRN
            // 
            this.txtVRN.Location = new System.Drawing.Point(321, 78);
            this.txtVRN.Name = "txtVRN";
            this.txtVRN.Size = new System.Drawing.Size(253, 27);
            this.txtVRN.TabIndex = 42;
            this.txtVRN.TextChanged += new System.EventHandler(this.txtVRN_TextChanged);
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(321, 33);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(253, 27);
            this.txtBID.TabIndex = 41;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Advanced Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Deposite Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Package Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ending Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Starting Odometer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Starting Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "License Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Customer NIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Vehicle Registration Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Booking ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(825, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.txtSea);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpED);
            this.Controls.Add(this.txtSO);
            this.Controls.Add(this.dtpSD);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtVRN);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(1411, 641);
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button butReset;
        private System.Windows.Forms.TextBox txtSea;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtSO;
        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtVRN;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpED;
    }
}
