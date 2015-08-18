namespace Cha
{
    partial class frmPurchaseOrder
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtSuggestionOfCash = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.lblDateDemand = new System.Windows.Forms.Label();
            this.optOfficePrint = new System.Windows.Forms.RadioButton();
            this.optForPurchsePrint = new System.Windows.Forms.RadioButton();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.optInProgress = new System.Windows.Forms.RadioButton();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSingleItemGroup = new System.Windows.Forms.RadioButton();
            this.optMultiItemGroup = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.cboEmpCode = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblDemandNote = new System.Windows.Forms.Label();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.lblVendorCode = new System.Windows.Forms.Label();
            this.lblPurchaserOrder = new System.Windows.Forms.Label();
            this.mskVendorCode = new System.Windows.Forms.MaskedTextBox();
            this.mskPurchaserCode = new System.Windows.Forms.MaskedTextBox();
            this.lblNameVendor1 = new System.Windows.Forms.Label();
            this.lblNamePurchaser1 = new System.Windows.Forms.Label();
            this.txtDemandNote = new System.Windows.Forms.TextBox();
            this.lblDateDepartment = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnDateDemand = new System.Windows.Forms.Button();
            this.btnDateDepartment = new System.Windows.Forms.Button();
            this.btnF1HelpAddNew = new System.Windows.Forms.Button();
            this.btnF1HelpItemGroup = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQty1 = new System.Windows.Forms.Label();
            this.lblNameVendor = new System.Windows.Forms.Label();
            this.lblNamePurchaser = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(483, 70);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(70, 28);
            this.btnAddNew.TabIndex = 49;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtSuggestionOfCash
            // 
            this.txtSuggestionOfCash.Location = new System.Drawing.Point(504, 577);
            this.txtSuggestionOfCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuggestionOfCash.Name = "txtSuggestionOfCash";
            this.txtSuggestionOfCash.Size = new System.Drawing.Size(173, 22);
            this.txtSuggestionOfCash.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 576);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 21);
            this.textBox1.TabIndex = 46;
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote1.Location = new System.Drawing.Point(10, 576);
            this.lblNote1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNote1.Size = new System.Drawing.Size(60, 20);
            this.lblNote1.TabIndex = 45;
            this.lblNote1.Text = "Note    ";
            this.lblNote1.Click += new System.EventHandler(this.lblNote1_Click);
            // 
            // lblDateDemand
            // 
            this.lblDateDemand.AutoSize = true;
            this.lblDateDemand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDemand.Location = new System.Drawing.Point(357, 11);
            this.lblDateDemand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDemand.Name = "lblDateDemand";
            this.lblDateDemand.Size = new System.Drawing.Size(43, 18);
            this.lblDateDemand.TabIndex = 44;
            this.lblDateDemand.Text = "Date";
            this.lblDateDemand.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // optOfficePrint
            // 
            this.optOfficePrint.AutoSize = true;
            this.optOfficePrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.optOfficePrint.Location = new System.Drawing.Point(317, 543);
            this.optOfficePrint.Margin = new System.Windows.Forms.Padding(4);
            this.optOfficePrint.Name = "optOfficePrint";
            this.optOfficePrint.Size = new System.Drawing.Size(89, 19);
            this.optOfficePrint.TabIndex = 42;
            this.optOfficePrint.Text = "Office Print";
            this.optOfficePrint.UseVisualStyleBackColor = true;
            this.optOfficePrint.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // optForPurchsePrint
            // 
            this.optForPurchsePrint.AutoSize = true;
            this.optForPurchsePrint.Checked = true;
            this.optForPurchsePrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.optForPurchsePrint.Location = new System.Drawing.Point(178, 543);
            this.optForPurchsePrint.Margin = new System.Windows.Forms.Padding(4);
            this.optForPurchsePrint.Name = "optForPurchsePrint";
            this.optForPurchsePrint.Size = new System.Drawing.Size(131, 19);
            this.optForPurchsePrint.TabIndex = 43;
            this.optForPurchsePrint.TabStop = true;
            this.optForPurchsePrint.Text = "For Purchase Print";
            this.optForPurchsePrint.UseVisualStyleBackColor = true;
            this.optForPurchsePrint.CheckedChanged += new System.EventHandler(this.optForPurchsePrint_CheckedChanged);
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optApprovedVerified.Location = new System.Drawing.Point(106, 14);
            this.optApprovedVerified.Margin = new System.Windows.Forms.Padding(4);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(131, 19);
            this.optApprovedVerified.TabIndex = 40;
            this.optApprovedVerified.Text = "Approved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // optInProgress
            // 
            this.optInProgress.AutoSize = true;
            this.optInProgress.Checked = true;
            this.optInProgress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProgress.Location = new System.Drawing.Point(7, 12);
            this.optInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.optInProgress.Name = "optInProgress";
            this.optInProgress.Size = new System.Drawing.Size(91, 19);
            this.optInProgress.TabIndex = 41;
            this.optInProgress.TabStop = true;
            this.optInProgress.Text = "In Progress";
            this.optInProgress.UseVisualStyleBackColor = true;
            this.optInProgress.CheckedChanged += new System.EventHandler(this.optInProgress_CheckedChanged);
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(99, 543);
            this.btnPrinting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(62, 25);
            this.btnPrinting.TabIndex = 37;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(8, 543);
            this.btnExitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(83, 25);
            this.btnExitSave.TabIndex = 39;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            this.btnExitSave.Click += new System.EventHandler(this.btnExitSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 22);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grd.Location = new System.Drawing.Point(3, 253);
            this.grd.Margin = new System.Windows.Forms.Padding(4);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(922, 282);
            this.grd.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Color";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UOM";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Stock Available";
            this.Column9.Name = "Column9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSingleItemGroup);
            this.groupBox1.Controls.Add(this.optMultiItemGroup);
            this.groupBox1.Location = new System.Drawing.Point(642, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(213, 81);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // optSingleItemGroup
            // 
            this.optSingleItemGroup.AutoSize = true;
            this.optSingleItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSingleItemGroup.Location = new System.Drawing.Point(8, 50);
            this.optSingleItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.optSingleItemGroup.Name = "optSingleItemGroup";
            this.optSingleItemGroup.Size = new System.Drawing.Size(193, 19);
            this.optSingleItemGroup.TabIndex = 0;
            this.optSingleItemGroup.Text = "Single Item Group [Size/Color]";
            this.optSingleItemGroup.UseVisualStyleBackColor = true;
            // 
            // optMultiItemGroup
            // 
            this.optMultiItemGroup.AutoSize = true;
            this.optMultiItemGroup.Checked = true;
            this.optMultiItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMultiItemGroup.Location = new System.Drawing.Point(8, 23);
            this.optMultiItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.optMultiItemGroup.Name = "optMultiItemGroup";
            this.optMultiItemGroup.Size = new System.Drawing.Size(185, 19);
            this.optMultiItemGroup.TabIndex = 0;
            this.optMultiItemGroup.TabStop = true;
            this.optMultiItemGroup.Text = "Multi Item Group [Size/Color]";
            this.optMultiItemGroup.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(154, 223);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(380, 22);
            this.txtNote.TabIndex = 33;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(154, 185);
            this.cboItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(380, 24);
            this.cboItemGroup.TabIndex = 31;
            this.cboItemGroup.SelectedIndexChanged += new System.EventHandler(this.cboItemGroup_SelectedIndexChanged);
            // 
            // cboEmpCode
            // 
            this.cboEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpCode.FormattingEnabled = true;
            this.cboEmpCode.Location = new System.Drawing.Point(154, 75);
            this.cboEmpCode.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpCode.Name = "cboEmpCode";
            this.cboEmpCode.Size = new System.Drawing.Size(282, 24);
            this.cboEmpCode.TabIndex = 30;
            this.cboEmpCode.SelectedIndexChanged += new System.EventHandler(this.cboEmpCode_SelectedIndexChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(3, 223);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(91, 18);
            this.lblNote.TabIndex = 25;
            this.lblNote.Text = "Note            ";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(3, 185);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(129, 18);
            this.lblItemGroup.TabIndex = 27;
            this.lblItemGroup.Text = "Item Group           ";
            this.lblItemGroup.Click += new System.EventHandler(this.lblItemGroup_Click);
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCode.Location = new System.Drawing.Point(3, 77);
            this.lblEmpCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(138, 18);
            this.lblEmpCode.TabIndex = 24;
            this.lblEmpCode.Text = "Emp Code              ";
            this.lblEmpCode.Click += new System.EventHandler(this.lblEmpCode_Click);
            // 
            // lblDemandNote
            // 
            this.lblDemandNote.AutoSize = true;
            this.lblDemandNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDemandNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandNote.Location = new System.Drawing.Point(3, 43);
            this.lblDemandNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemandNote.Name = "lblDemandNote";
            this.lblDemandNote.Size = new System.Drawing.Size(141, 18);
            this.lblDemandNote.TabIndex = 23;
            this.lblDemandNote.Text = "   Demand Note #   ";
            this.lblDemandNote.Click += new System.EventHandler(this.lblDepartment_Click);
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrder.Location = new System.Drawing.Point(3, 9);
            this.lblPurchaseOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(142, 18);
            this.lblPurchaseOrder.TabIndex = 22;
            this.lblPurchaseOrder.Text = " Purchase Order #  ";
            this.lblPurchaseOrder.Click += new System.EventHandler(this.lblDemandNote1_Click);
            // 
            // lblVendorCode
            // 
            this.lblVendorCode.AutoSize = true;
            this.lblVendorCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVendorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorCode.Location = new System.Drawing.Point(3, 114);
            this.lblVendorCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendorCode.Name = "lblVendorCode";
            this.lblVendorCode.Size = new System.Drawing.Size(141, 18);
            this.lblVendorCode.TabIndex = 51;
            this.lblVendorCode.Text = "Vendor Code          ";
            this.lblVendorCode.Click += new System.EventHandler(this.lblVendorCode_Click);
            // 
            // lblPurchaserOrder
            // 
            this.lblPurchaserOrder.AutoSize = true;
            this.lblPurchaserOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaserOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaserOrder.Location = new System.Drawing.Point(3, 150);
            this.lblPurchaserOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaserOrder.Name = "lblPurchaserOrder";
            this.lblPurchaserOrder.Size = new System.Drawing.Size(143, 18);
            this.lblPurchaserOrder.TabIndex = 51;
            this.lblPurchaserOrder.Text = "Purchaser Order     ";
            this.lblPurchaserOrder.Click += new System.EventHandler(this.lblPurchaserOrder_Click);
            // 
            // mskVendorCode
            // 
            this.mskVendorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskVendorCode.Location = new System.Drawing.Point(154, 110);
            this.mskVendorCode.Margin = new System.Windows.Forms.Padding(4);
            this.mskVendorCode.Mask = "0-0-00-00-0000";
            this.mskVendorCode.Name = "mskVendorCode";
            this.mskVendorCode.Size = new System.Drawing.Size(236, 22);
            this.mskVendorCode.TabIndex = 52;
            this.mskVendorCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mskPurchaserCode
            // 
            this.mskPurchaserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPurchaserCode.Location = new System.Drawing.Point(154, 150);
            this.mskPurchaserCode.Margin = new System.Windows.Forms.Padding(4);
            this.mskPurchaserCode.Mask = "0-0-00-00-0000";
            this.mskPurchaserCode.Name = "mskPurchaserCode";
            this.mskPurchaserCode.Size = new System.Drawing.Size(236, 22);
            this.mskPurchaserCode.TabIndex = 52;
            this.mskPurchaserCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // lblNameVendor1
            // 
            this.lblNameVendor1.AutoSize = true;
            this.lblNameVendor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameVendor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameVendor1.Location = new System.Drawing.Point(408, 110);
            this.lblNameVendor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameVendor1.Name = "lblNameVendor1";
            this.lblNameVendor1.Size = new System.Drawing.Size(51, 18);
            this.lblNameVendor1.TabIndex = 53;
            this.lblNameVendor1.Text = "Name";
            this.lblNameVendor1.Click += new System.EventHandler(this.lblNameVendor_Click);
            // 
            // lblNamePurchaser1
            // 
            this.lblNamePurchaser1.AutoSize = true;
            this.lblNamePurchaser1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNamePurchaser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePurchaser1.Location = new System.Drawing.Point(408, 140);
            this.lblNamePurchaser1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePurchaser1.Name = "lblNamePurchaser1";
            this.lblNamePurchaser1.Size = new System.Drawing.Size(51, 18);
            this.lblNamePurchaser1.TabIndex = 53;
            this.lblNamePurchaser1.Text = "Name";
            this.lblNamePurchaser1.Click += new System.EventHandler(this.lblNamePurchaser_Click);
            // 
            // txtDemandNote
            // 
            this.txtDemandNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemandNote.Location = new System.Drawing.Point(154, 45);
            this.txtDemandNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtDemandNote.Name = "txtDemandNote";
            this.txtDemandNote.Size = new System.Drawing.Size(194, 22);
            this.txtDemandNote.TabIndex = 55;
            this.txtDemandNote.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblDateDepartment
            // 
            this.lblDateDepartment.AutoSize = true;
            this.lblDateDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDepartment.Location = new System.Drawing.Point(357, 45);
            this.lblDateDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDepartment.Name = "lblDateDepartment";
            this.lblDateDepartment.Size = new System.Drawing.Size(43, 18);
            this.lblDateDepartment.TabIndex = 44;
            this.lblDateDepartment.Text = "Date";
            this.lblDateDepartment.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(408, 45);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 22);
            this.dateTimePicker2.TabIndex = 56;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnDateDemand
            // 
            this.btnDateDemand.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateDemand.Location = new System.Drawing.Point(572, 11);
            this.btnDateDemand.Name = "btnDateDemand";
            this.btnDateDemand.Size = new System.Drawing.Size(63, 22);
            this.btnDateDemand.TabIndex = 57;
            this.btnDateDemand.Text = "F1=Help";
            this.btnDateDemand.UseVisualStyleBackColor = true;
            // 
            // btnDateDepartment
            // 
            this.btnDateDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateDepartment.Location = new System.Drawing.Point(572, 43);
            this.btnDateDepartment.Name = "btnDateDepartment";
            this.btnDateDepartment.Size = new System.Drawing.Size(63, 24);
            this.btnDateDepartment.TabIndex = 57;
            this.btnDateDepartment.Text = "F1=Help";
            this.btnDateDepartment.UseVisualStyleBackColor = true;
            // 
            // btnF1HelpAddNew
            // 
            this.btnF1HelpAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnF1HelpAddNew.Location = new System.Drawing.Point(572, 73);
            this.btnF1HelpAddNew.Name = "btnF1HelpAddNew";
            this.btnF1HelpAddNew.Size = new System.Drawing.Size(63, 27);
            this.btnF1HelpAddNew.TabIndex = 57;
            this.btnF1HelpAddNew.Text = "F1=Help";
            this.btnF1HelpAddNew.UseVisualStyleBackColor = true;
            this.btnF1HelpAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnF1HelpItemGroup
            // 
            this.btnF1HelpItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpItemGroup.Location = new System.Drawing.Point(572, 182);
            this.btnF1HelpItemGroup.Name = "btnF1HelpItemGroup";
            this.btnF1HelpItemGroup.Size = new System.Drawing.Size(63, 22);
            this.btnF1HelpItemGroup.TabIndex = 57;
            this.btnF1HelpItemGroup.Text = "F1=Help";
            this.btnF1HelpItemGroup.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(685, 576);
            this.btnEscExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(89, 23);
            this.btnEscExit.TabIndex = 38;
            this.btnEscExit.Text = "<Esc = Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 577);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = " Suggestion of Cash  ";
            this.label1.Click += new System.EventHandler(this.lblNote1_Click);
            // 
            // lblQty1
            // 
            this.lblQty1.AutoSize = true;
            this.lblQty1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty1.Location = new System.Drawing.Point(421, 543);
            this.lblQty1.Name = "lblQty1";
            this.lblQty1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQty1.Size = new System.Drawing.Size(43, 18);
            this.lblQty1.TabIndex = 58;
            this.lblQty1.Text = "  Qty ";
            // 
            // lblNameVendor
            // 
            this.lblNameVendor.AutoSize = true;
            this.lblNameVendor.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNameVendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameVendor.Location = new System.Drawing.Point(467, 110);
            this.lblNameVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameVendor.Name = "lblNameVendor";
            this.lblNameVendor.Size = new System.Drawing.Size(335, 20);
            this.lblNameVendor.TabIndex = 28;
            this.lblNameVendor.Text = "                                                                 ";
            this.lblNameVendor.Click += new System.EventHandler(this.lblDemandNote_Click);
            // 
            // lblNamePurchaser
            // 
            this.lblNamePurchaser.AutoSize = true;
            this.lblNamePurchaser.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNamePurchaser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNamePurchaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePurchaser.Location = new System.Drawing.Point(467, 140);
            this.lblNamePurchaser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePurchaser.Name = "lblNamePurchaser";
            this.lblNamePurchaser.Size = new System.Drawing.Size(335, 20);
            this.lblNamePurchaser.TabIndex = 28;
            this.lblNamePurchaser.Text = "                                                                 ";
            this.lblNamePurchaser.Click += new System.EventHandler(this.lblDemandNote_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(587, 543);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 18);
            this.lblValue.TabIndex = 59;
            this.lblValue.Text = " Value ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 541);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "                   ";
            this.label4.Click += new System.EventHandler(this.lblDemandNote_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(471, 543);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(105, 20);
            this.lblQty.TabIndex = 28;
            this.lblQty.Text = "                   ";
            this.lblQty.Click += new System.EventHandler(this.lblDemandNote_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optInProgress);
            this.groupBox2.Controls.Add(this.optApprovedVerified);
            this.groupBox2.Location = new System.Drawing.Point(555, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 40);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseOrder.Location = new System.Drawing.Point(154, 11);
            this.txtPurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(194, 22);
            this.txtPurchaseOrder.TabIndex = 62;
            this.txtPurchaseOrder.TextChanged += new System.EventHandler(this.txtDemandNote_TextChanged);
            this.txtPurchaseOrder.DoubleClick += new System.EventHandler(this.txtDemandNote_DoubleClick);
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 608);
            this.Controls.Add(this.txtPurchaseOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblQty1);
            this.Controls.Add(this.btnF1HelpAddNew);
            this.Controls.Add(this.btnDateDepartment);
            this.Controls.Add(this.btnF1HelpItemGroup);
            this.Controls.Add(this.btnDateDemand);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtDemandNote);
            this.Controls.Add(this.lblNamePurchaser1);
            this.Controls.Add(this.lblNameVendor1);
            this.Controls.Add(this.mskPurchaserCode);
            this.Controls.Add(this.mskVendorCode);
            this.Controls.Add(this.lblPurchaserOrder);
            this.Controls.Add(this.lblVendorCode);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtSuggestionOfCash);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.lblDateDepartment);
            this.Controls.Add(this.lblDateDemand);
            this.Controls.Add(this.optOfficePrint);
            this.Controls.Add(this.optForPurchsePrint);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.cboEmpCode);
            this.Controls.Add(this.lblNameVendor);
            this.Controls.Add(this.lblNamePurchaser);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblDemandNote);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPurchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchaseOrder_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtSuggestionOfCash;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.Label lblDateDemand;
        private System.Windows.Forms.RadioButton optOfficePrint;
        private System.Windows.Forms.RadioButton optForPurchsePrint;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.RadioButton optInProgress;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSingleItemGroup;
        private System.Windows.Forms.RadioButton optMultiItemGroup;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.ComboBox cboEmpCode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblDemandNote;
        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.Label lblVendorCode;
        private System.Windows.Forms.Label lblPurchaserOrder;
        private System.Windows.Forms.MaskedTextBox mskVendorCode;
        private System.Windows.Forms.MaskedTextBox mskPurchaserCode;
        private System.Windows.Forms.Label lblNameVendor1;
        private System.Windows.Forms.Label lblNamePurchaser1;
        private System.Windows.Forms.TextBox txtDemandNote;
        private System.Windows.Forms.Label lblDateDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnDateDemand;
        private System.Windows.Forms.Button btnDateDepartment;
        private System.Windows.Forms.Button btnF1HelpAddNew;
        private System.Windows.Forms.Button btnF1HelpItemGroup;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQty1;
        private System.Windows.Forms.Label lblNameVendor;
        private System.Windows.Forms.Label lblNamePurchaser;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPurchaseOrder;
    }
}