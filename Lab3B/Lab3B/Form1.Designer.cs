namespace Lab3B
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cmbHairdresser = new System.Windows.Forms.ComboBox();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.lstChargedItems = new System.Windows.Forms.ListBox();
            this.lstPrices = new System.Windows.Forms.ListBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHairdresser);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstServices);
            this.groupBox2.Location = new System.Drawing.Point(256, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstChargedItems);
            this.groupBox3.Location = new System.Drawing.Point(529, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPrices);
            this.groupBox4.Location = new System.Drawing.Point(836, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 193);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // btnAddService
            // 
            this.btnAddService.Enabled = false;
            this.btnAddService.Location = new System.Drawing.Point(256, 351);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(176, 50);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Enabled = false;
            this.btnCalculateTotal.Location = new System.Drawing.Point(459, 351);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(159, 50);
            this.btnCalculateTotal.TabIndex = 5;
            this.btnCalculateTotal.Text = "Calculate Total Price";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(649, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(159, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(836, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(751, 278);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(87, 20);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Total Price:";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // cmbHairdresser
            // 
            this.cmbHairdresser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHairdresser.FormattingEnabled = true;
            this.cmbHairdresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.cmbHairdresser.Location = new System.Drawing.Point(7, 36);
            this.cmbHairdresser.Name = "cmbHairdresser";
            this.cmbHairdresser.Size = new System.Drawing.Size(203, 28);
            this.cmbHairdresser.TabIndex = 0;
            this.cmbHairdresser.SelectedIndexChanged += new System.EventHandler(this.cmbHairdresser_SelectedIndexChanged);
            // 
            // lstServices
            // 
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 20;
            this.lstServices.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.lstServices.Location = new System.Drawing.Point(7, 36);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(224, 144);
            this.lstServices.TabIndex = 0;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // lstChargedItems
            // 
            this.lstChargedItems.FormattingEnabled = true;
            this.lstChargedItems.ItemHeight = 20;
            this.lstChargedItems.Location = new System.Drawing.Point(7, 36);
            this.lstChargedItems.Name = "lstChargedItems";
            this.lstChargedItems.Size = new System.Drawing.Size(266, 144);
            this.lstChargedItems.TabIndex = 0;
            // 
            // lstPrices
            // 
            this.lstPrices.FormattingEnabled = true;
            this.lstPrices.ItemHeight = 20;
            this.lstPrices.Location = new System.Drawing.Point(7, 26);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.Size = new System.Drawing.Size(177, 164);
            this.lstPrices.TabIndex = 0;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(859, 275);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(177, 26);
            this.txtTotalPrice.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 425);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbHairdresser;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.ListBox lstChargedItems;
        private System.Windows.Forms.ListBox lstPrices;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}

