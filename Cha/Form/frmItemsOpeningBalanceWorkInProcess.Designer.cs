namespace Cha
{
    partial class frmItemsOpeningBalanceWorkInProcess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboContractor = new System.Windows.Forms.ComboBox();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblIOWIP = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.lblIOWIP1 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblContractor = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblTotalQty1 = new System.Windows.Forms.Label();
            this.btnF1HelpIOWIP = new System.Windows.Forms.Button();
            this.btnAddNewIOWIP = new System.Windows.Forms.Button();
            this.lblDateIOWIP = new System.Windows.Forms.Label();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.optInProcess = new System.Windows.Forms.RadioButton();
            this.optQtyOut = new System.Windows.Forms.RadioButton();
            this.optQtyIn = new System.Windows.Forms.RadioButton();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.dtpDateIOWIP = new System.Windows.Forms.DateTimePicker();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.cboPurpose = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.cboMachine = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboContractor
            // 
            this.cboContractor.FormattingEnabled = true;
            this.cboContractor.Location = new System.Drawing.Point(126, 142);
            this.cboContractor.Name = "cboContractor";
            this.cboContractor.Size = new System.Drawing.Size(264, 21);
            this.cboContractor.TabIndex = 154;
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(126, 34);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(264, 21);
            this.cboEmployee.TabIndex = 153;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(126, 59);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(264, 21);
            this.cboDepartment.TabIndex = 155;
            // 
            // lblIOWIP
            // 
            this.lblIOWIP.AutoSize = true;
            this.lblIOWIP.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblIOWIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIOWIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIOWIP.Location = new System.Drawing.Point(126, 9);
            this.lblIOWIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIOWIP.Name = "lblIOWIP";
            this.lblIOWIP.Size = new System.Drawing.Size(190, 20);
            this.lblIOWIP.TabIndex = 152;
            this.lblIOWIP.Text = "                                    ";
            this.lblIOWIP.Click += new System.EventHandler(this.lblIOWIP_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(13, 59);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(106, 18);
            this.lblDepartment.TabIndex = 135;
            this.lblDepartment.Text = "  Department  ";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(13, 35);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(108, 18);
            this.lblEmployee.TabIndex = 136;
            this.lblEmployee.Text = "  Employee     ";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(476, 171);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(223, 22);
            this.txtNote.TabIndex = 119;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(126, 169);
            this.cboItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(264, 24);
            this.cboItemGroup.TabIndex = 118;
            // 
            // lblIOWIP1
            // 
            this.lblIOWIP1.AutoSize = true;
            this.lblIOWIP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIOWIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIOWIP1.Location = new System.Drawing.Point(13, 8);
            this.lblIOWIP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIOWIP1.Name = "lblIOWIP1";
            this.lblIOWIP1.Size = new System.Drawing.Size(109, 18);
            this.lblIOWIP1.TabIndex = 107;
            this.lblIOWIP1.Text = "    IO WIP  #     ";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.Location = new System.Drawing.Point(696, 491);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(138, 18);
            this.lblTotalQty.TabIndex = 115;
            this.lblTotalQty.Text = "                                ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(397, 171);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(71, 18);
            this.lblNote.TabIndex = 109;
            this.lblNote.Text = "    Note   ";
            // 
            // lblContractor
            // 
            this.lblContractor.AutoSize = true;
            this.lblContractor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractor.Location = new System.Drawing.Point(13, 142);
            this.lblContractor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(105, 18);
            this.lblContractor.TabIndex = 110;
            this.lblContractor.Text = "   Contractor   ";
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(13, 169);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(105, 18);
            this.lblItemGroup.TabIndex = 111;
            this.lblItemGroup.Text = "   Item Group  ";
            // 
            // lblTotalQty1
            // 
            this.lblTotalQty1.AutoSize = true;
            this.lblTotalQty1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty1.Location = new System.Drawing.Point(603, 491);
            this.lblTotalQty1.Name = "lblTotalQty1";
            this.lblTotalQty1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalQty1.Size = new System.Drawing.Size(86, 18);
            this.lblTotalQty1.TabIndex = 149;
            this.lblTotalQty1.Text = "Total Qty    ";
            // 
            // btnF1HelpIOWIP
            // 
            this.btnF1HelpIOWIP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpIOWIP.Location = new System.Drawing.Point(514, 8);
            this.btnF1HelpIOWIP.Name = "btnF1HelpIOWIP";
            this.btnF1HelpIOWIP.Size = new System.Drawing.Size(63, 25);
            this.btnF1HelpIOWIP.TabIndex = 147;
            this.btnF1HelpIOWIP.Text = "F1=Help";
            this.btnF1HelpIOWIP.UseVisualStyleBackColor = true;
            // 
            // btnAddNewIOWIP
            // 
            this.btnAddNewIOWIP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewIOWIP.Location = new System.Drawing.Point(584, 8);
            this.btnAddNewIOWIP.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewIOWIP.Name = "btnAddNewIOWIP";
            this.btnAddNewIOWIP.Size = new System.Drawing.Size(76, 23);
            this.btnAddNewIOWIP.TabIndex = 133;
            this.btnAddNewIOWIP.Text = "Add New";
            this.btnAddNewIOWIP.UseVisualStyleBackColor = true;
            // 
            // lblDateIOWIP
            // 
            this.lblDateIOWIP.AutoSize = true;
            this.lblDateIOWIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateIOWIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIOWIP.Location = new System.Drawing.Point(335, 11);
            this.lblDateIOWIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateIOWIP.Name = "lblDateIOWIP";
            this.lblDateIOWIP.Size = new System.Drawing.Size(51, 18);
            this.lblDateIOWIP.TabIndex = 131;
            this.lblDateIOWIP.Text = "Date  ";
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.optApprovedVerified.Location = new System.Drawing.Point(417, 495);
            this.optApprovedVerified.Margin = new System.Windows.Forms.Padding(4);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(124, 19);
            this.optApprovedVerified.TabIndex = 128;
            this.optApprovedVerified.TabStop = true;
            this.optApprovedVerified.Text = "Aproved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // optInProcess
            // 
            this.optInProcess.AutoSize = true;
            this.optInProcess.Checked = true;
            this.optInProcess.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.optInProcess.Location = new System.Drawing.Point(323, 495);
            this.optInProcess.Margin = new System.Windows.Forms.Padding(4);
            this.optInProcess.Name = "optInProcess";
            this.optInProcess.Size = new System.Drawing.Size(86, 19);
            this.optInProcess.TabIndex = 129;
            this.optInProcess.TabStop = true;
            this.optInProcess.Text = "In Process";
            this.optInProcess.UseVisualStyleBackColor = true;
            // 
            // optQtyOut
            // 
            this.optQtyOut.AutoSize = true;
            this.optQtyOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQtyOut.Location = new System.Drawing.Point(91, 12);
            this.optQtyOut.Margin = new System.Windows.Forms.Padding(4);
            this.optQtyOut.Name = "optQtyOut";
            this.optQtyOut.Size = new System.Drawing.Size(67, 19);
            this.optQtyOut.TabIndex = 126;
            this.optQtyOut.Text = "Qty Out";
            this.optQtyOut.UseVisualStyleBackColor = true;
            // 
            // optQtyIn
            // 
            this.optQtyIn.AutoSize = true;
            this.optQtyIn.Checked = true;
            this.optQtyIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQtyIn.Location = new System.Drawing.Point(10, 12);
            this.optQtyIn.Margin = new System.Windows.Forms.Padding(4);
            this.optQtyIn.Name = "optQtyIn";
            this.optQtyIn.Size = new System.Drawing.Size(57, 19);
            this.optQtyIn.TabIndex = 127;
            this.optQtyIn.TabStop = true;
            this.optQtyIn.Text = "Qty In";
            this.optQtyIn.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(101, 491);
            this.btnPrinting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(62, 25);
            this.btnPrinting.TabIndex = 123;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(226, 493);
            this.btnEscExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(89, 23);
            this.btnEscExit.TabIndex = 124;
            this.btnEscExit.Text = "<Esc = Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(13, 491);
            this.btnExitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(83, 25);
            this.btnExitSave.TabIndex = 125;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // dtpDateIOWIP
            // 
            this.dtpDateIOWIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIOWIP.Location = new System.Drawing.Point(394, 9);
            this.dtpDateIOWIP.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateIOWIP.Name = "dtpDateIOWIP";
            this.dtpDateIOWIP.Size = new System.Drawing.Size(113, 22);
            this.dtpDateIOWIP.TabIndex = 122;
            // 
            // grd
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column11,
            this.Column8,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Location = new System.Drawing.Point(13, 201);
            this.grd.Margin = new System.Windows.Forms.Padding(4);
            this.grd.Name = "grd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.Size = new System.Drawing.Size(821, 282);
            this.grd.TabIndex = 121;
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
            // Column10
            // 
            this.Column10.HeaderText = "Godown";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Stock";
            this.Column11.Name = "Column11";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "New Stock";
            this.Column4.Name = "Column4";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(13, 88);
            this.lblPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(104, 18);
            this.lblPurpose.TabIndex = 135;
            this.lblPurpose.Text = "  Purpose       ";
            // 
            // cboPurpose
            // 
            this.cboPurpose.FormattingEnabled = true;
            this.cboPurpose.Location = new System.Drawing.Point(126, 87);
            this.cboPurpose.Name = "cboPurpose";
            this.cboPurpose.Size = new System.Drawing.Size(264, 21);
            this.cboPurpose.TabIndex = 155;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(13, 114);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(104, 18);
            this.lblMachine.TabIndex = 110;
            this.lblMachine.Text = "  Machine #    ";
            // 
            // cboMachine
            // 
            this.cboMachine.FormattingEnabled = true;
            this.cboMachine.Location = new System.Drawing.Point(126, 113);
            this.cboMachine.Name = "cboMachine";
            this.cboMachine.Size = new System.Drawing.Size(264, 21);
            this.cboMachine.TabIndex = 154;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optQtyOut);
            this.groupBox1.Controls.Add(this.optQtyIn);
            this.groupBox1.Location = new System.Drawing.Point(417, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 38);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // frmItemsOpeningBalanceWorkInProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMachine);
            this.Controls.Add(this.cboContractor);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.cboPurpose);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.lblIOWIP);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.lblIOWIP1);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.lblContractor);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblTotalQty1);
            this.Controls.Add(this.btnF1HelpIOWIP);
            this.Controls.Add(this.btnAddNewIOWIP);
            this.Controls.Add(this.lblDateIOWIP);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProcess);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dtpDateIOWIP);
            this.Controls.Add(this.grd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmItemsOpeningBalanceWorkInProcess";
            this.Text = "Items Opening Balance (Work In Process)";
            this.Load += new System.EventHandler(this.frmItemsOpeningBalanceWorkInProcess_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItemsOpeningBalanceWorkInProcess_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboContractor;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblIOWIP;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.Label lblIOWIP1;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblContractor;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblTotalQty1;
        private System.Windows.Forms.Button btnF1HelpIOWIP;
        private System.Windows.Forms.Button btnAddNewIOWIP;
        private System.Windows.Forms.Label lblDateIOWIP;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.RadioButton optInProcess;
        private System.Windows.Forms.RadioButton optQtyOut;
        private System.Windows.Forms.RadioButton optQtyIn;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.DateTimePicker dtpDateIOWIP;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.ComboBox cboPurpose;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ComboBox cboMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}