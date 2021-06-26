
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
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSea = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.cbPT = new System.Windows.Forms.ComboBox();
            this.dtpED = new System.Windows.Forms.DateTimePicker();
            this.dtpSD = new System.Windows.Forms.DateTimePicker();
            this.txtLN = new System.Windows.Forms.TextBox();
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
            this.txtVRN = new System.Windows.Forms.MaskedTextBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtSO = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(897, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(803, 516);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(743, 816);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 53);
            this.btnSubmit.TabIndex = 55;
            this.btnSubmit.Text = "&Submit and Print";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            this.btnSubmit.MouseHover += new System.EventHandler(this.btnSubmit_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1612, 661);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 65);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "&Update and Print";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(743, 732);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 50);
            this.btnReset.TabIndex = 53;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.butReset_Click);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            this.btnReset.MouseHover += new System.EventHandler(this.butReset_MouseHover);
            // 
            // txtSea
            // 
            this.txtSea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSea.Location = new System.Drawing.Point(870, 29);
            this.txtSea.Name = "txtSea";
            this.txtSea.Size = new System.Drawing.Size(224, 28);
            this.txtSea.TabIndex = 52;
            this.txtSea.Visible = false;
            this.txtSea.TextChanged += new System.EventHandler(this.txtSea_TextChanged);
            this.txtSea.MouseHover += new System.EventHandler(this.txtSea_MouseHover);
            // 
            // txtDis
            // 
            this.txtDis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDis.Location = new System.Drawing.Point(327, 624);
            this.txtDis.Multiline = true;
            this.txtDis.Name = "txtDis";
            this.txtDis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDis.Size = new System.Drawing.Size(253, 257);
            this.txtDis.TabIndex = 51;
            this.txtDis.TextChanged += new System.EventHandler(this.txtDis_TextChanged);
            // 
            // txtAP
            // 
            this.txtAP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAP.Location = new System.Drawing.Point(321, 565);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(253, 28);
            this.txtAP.TabIndex = 50;
            this.txtAP.TextChanged += new System.EventHandler(this.txtAP_TextChanged);
            // 
            // txtDA
            // 
            this.txtDA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDA.Location = new System.Drawing.Point(321, 506);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(253, 28);
            this.txtDA.TabIndex = 49;
            this.txtDA.TextChanged += new System.EventHandler(this.txtDA_TextChanged);
            // 
            // cbPT
            // 
            this.cbPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPT.FormattingEnabled = true;
            this.cbPT.Items.AddRange(new object[] {
            "Hourly basis",
            "Daily Basis",
            "Weekly Basis",
            "Monthly Basis"});
            this.cbPT.Location = new System.Drawing.Point(321, 446);
            this.cbPT.Name = "cbPT";
            this.cbPT.Size = new System.Drawing.Size(253, 29);
            this.cbPT.TabIndex = 48;
            this.cbPT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpED
            // 
            this.dtpED.CustomFormat = "yyyy-MM-dd";
            this.dtpED.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpED.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpED.Location = new System.Drawing.Point(321, 387);
            this.dtpED.Name = "dtpED";
            this.dtpED.Size = new System.Drawing.Size(253, 28);
            this.dtpED.TabIndex = 47;
            this.dtpED.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpSD
            // 
            this.dtpSD.CustomFormat = "yyyy-MM-dd";
            this.dtpSD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSD.Location = new System.Drawing.Point(321, 269);
            this.dtpSD.Name = "dtpSD";
            this.dtpSD.Size = new System.Drawing.Size(253, 28);
            this.dtpSD.TabIndex = 45;
            this.dtpSD.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            this.dtpSD.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLN.Location = new System.Drawing.Point(321, 210);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(253, 28);
            this.txtLN.TabIndex = 44;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBID.Location = new System.Drawing.Point(321, 33);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(253, 28);
            this.txtBID.TabIndex = 41;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(48, 673);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Description";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(48, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 21);
            this.label10.TabIndex = 39;
            this.label10.Text = "Advanced Payment";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(42, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "Deposite Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Package Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ending Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Starting Odometer";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Starting Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "License Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Customer NIC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Vehicle Registration Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Booking ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(825, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // txtVRN
            // 
            this.txtVRN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVRN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVRN.Location = new System.Drawing.Point(321, 92);
            this.txtVRN.Mask = ">AAa-0000";
            this.txtVRN.Name = "txtVRN";
            this.txtVRN.Size = new System.Drawing.Size(253, 28);
            this.txtVRN.TabIndex = 58;
            this.txtVRN.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtVRN_MaskInputRejected);
            // 
            // txtCNIC
            // 
            this.txtCNIC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNIC.Location = new System.Drawing.Point(321, 151);
            this.txtCNIC.Mask = ">000000000A99";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(253, 28);
            this.txtCNIC.TabIndex = 59;
            this.txtCNIC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNIC_MaskInputRejected);
            // 
            // txtSO
            // 
            this.txtSO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSO.Location = new System.Drawing.Point(321, 328);
            this.txtSO.Mask = "000000";
            this.txtSO.Name = "txtSO";
            this.txtSO.Size = new System.Drawing.Size(253, 28);
            this.txtSO.TabIndex = 60;
            this.txtSO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSO_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtDis);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 950);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSO);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtVRN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSea);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.cbPT);
            this.Controls.Add(this.dtpED);
            this.Controls.Add(this.dtpSD);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(1911, 950);
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSea;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.ComboBox cbPT;
        private System.Windows.Forms.DateTimePicker dtpSD;
        private System.Windows.Forms.TextBox txtLN;
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

        private System.Windows.Forms.MaskedTextBox txtVRN;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.MaskedTextBox txtSO;
        private System.Windows.Forms.Panel panel1;
    }
}
