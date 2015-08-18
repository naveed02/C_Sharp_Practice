namespace Cha
{
    partial class frmDemandNote
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
            this.lblDemandNote1 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblGodownForBal = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboEmpCode = new System.Windows.Forms.ComboBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.cboGodownForBal = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSingleItemGroup = new System.Windows.Forms.RadioButton();
            this.optMultiItemGroup = new System.Windows.Forms.RadioButton();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnF1Help = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.optInProgress = new System.Windows.Forms.RadioButton();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDemandNote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDemandNote1
            // 
            this.lblDemandNote1.AutoSize = true;
            this.lblDemandNote1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDemandNote1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandNote1.Location = new System.Drawing.Point(15, 18);
            this.lblDemandNote1.Name = "lblDemandNote1";
            this.lblDemandNote1.Size = new System.Drawing.Size(115, 18);
            this.lblDemandNote1.TabIndex = 0;
            this.lblDemandNote1.Text = "Demand Note #  ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(15, 45);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(124, 18);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department          ";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCode.Location = new System.Drawing.Point(15, 73);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(127, 18);
            this.lblEmpCode.TabIndex = 2;
            this.lblEmpCode.Text = "Emp Code             ";
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(15, 98);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(125, 18);
            this.lblItemGroup.TabIndex = 3;
            this.lblItemGroup.Text = "Item Group           ";
            this.lblItemGroup.Click += new System.EventHandler(this.lblItemGroup_Click);
            // 
            // lblGodownForBal
            // 
            this.lblGodownForBal.AutoSize = true;
            this.lblGodownForBal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGodownForBal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodownForBal.Location = new System.Drawing.Point(15, 128);
            this.lblGodownForBal.Name = "lblGodownForBal";
            this.lblGodownForBal.Size = new System.Drawing.Size(125, 18);
            this.lblGodownForBal.TabIndex = 3;
            this.lblGodownForBal.Text = "Godown For Bal.  ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(21, 159);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(119, 18);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "            Note        ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(155, 39);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(259, 23);
            this.cboDepartment.TabIndex = 5;
            // 
            // cboEmpCode
            // 
            this.cboEmpCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpCode.FormattingEnabled = true;
            this.cboEmpCode.Location = new System.Drawing.Point(155, 70);
            this.cboEmpCode.Name = "cboEmpCode";
            this.cboEmpCode.Size = new System.Drawing.Size(259, 23);
            this.cboEmpCode.TabIndex = 6;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(155, 99);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(259, 23);
            this.cboItemGroup.TabIndex = 7;
            // 
            // cboGodownForBal
            // 
            this.cboGodownForBal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGodownForBal.FormattingEnabled = true;
            this.cboGodownForBal.Location = new System.Drawing.Point(155, 128);
            this.cboGodownForBal.Name = "cboGodownForBal";
            this.cboGodownForBal.Size = new System.Drawing.Size(259, 23);
            this.cboGodownForBal.TabIndex = 8;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(155, 157);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(259, 21);
            this.txtNote.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSingleItemGroup);
            this.groupBox1.Controls.Add(this.optMultiItemGroup);
            this.groupBox1.Location = new System.Drawing.Point(450, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // optSingleItemGroup
            // 
            this.optSingleItemGroup.AutoSize = true;
            this.optSingleItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSingleItemGroup.Location = new System.Drawing.Point(16, 42);
            this.optSingleItemGroup.Name = "optSingleItemGroup";
            this.optSingleItemGroup.Size = new System.Drawing.Size(193, 19);
            this.optSingleItemGroup.TabIndex = 0;
            this.optSingleItemGroup.TabStop = true;
            this.optSingleItemGroup.Text = "Single Item Group [Size/Color]";
            this.optSingleItemGroup.UseVisualStyleBackColor = true;
            // 
            // optMultiItemGroup
            // 
            this.optMultiItemGroup.AutoSize = true;
            this.optMultiItemGroup.Checked = true;
            this.optMultiItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMultiItemGroup.Location = new System.Drawing.Point(16, 19);
            this.optMultiItemGroup.Name = "optMultiItemGroup";
            this.optMultiItemGroup.Size = new System.Drawing.Size(185, 19);
            this.optMultiItemGroup.TabIndex = 0;
            this.optMultiItemGroup.TabStop = true;
            this.optMultiItemGroup.Text = "Multi Item Group [Size/Color]";
            this.optMultiItemGroup.UseVisualStyleBackColor = true;
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
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Location = new System.Drawing.Point(18, 203);
            this.grd.Name = "grd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd.Size = new System.Drawing.Size(682, 229);
            this.grd.TabIndex = 11;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(18, 441);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(90, 24);
            this.btnExitSave.TabIndex = 13;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(114, 441);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(92, 24);
            this.btnEscExit.TabIndex = 13;
            this.btnEscExit.Text = "<Esc = Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(18, 471);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(90, 23);
            this.btnPrinting.TabIndex = 13;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(272, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote1.Location = new System.Drawing.Point(329, 479);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(55, 18);
            this.lblNote1.TabIndex = 17;
            this.lblNote1.Text = "Note    ";
            this.lblNote1.Click += new System.EventHandler(this.lblNote1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(404, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 21);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(550, 444);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(55, 18);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total       ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 443);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 20;
            // 
            // btnF1Help
            // 
            this.btnF1Help.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1Help.Location = new System.Drawing.Point(459, 31);
            this.btnF1Help.Name = "btnF1Help";
            this.btnF1Help.Size = new System.Drawing.Size(75, 23);
            this.btnF1Help.TabIndex = 21;
            this.btnF1Help.Text = "F1=Help";
            this.btnF1Help.UseVisualStyleBackColor = true;
            this.btnF1Help.Click += new System.EventHandler(this.btnF1Help_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(575, 31);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // optInProgress
            // 
            this.optInProgress.AutoSize = true;
            this.optInProgress.Checked = true;
            this.optInProgress.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProgress.Location = new System.Drawing.Point(6, 14);
            this.optInProgress.Name = "optInProgress";
            this.optInProgress.Size = new System.Drawing.Size(80, 20);
            this.optInProgress.TabIndex = 14;
            this.optInProgress.TabStop = true;
            this.optInProgress.Text = "In Progress";
            this.optInProgress.UseVisualStyleBackColor = true;
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optApprovedVerified.Location = new System.Drawing.Point(90, 14);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(117, 20);
            this.optApprovedVerified.TabIndex = 14;
            this.optApprovedVerified.TabStop = true;
            this.optApprovedVerified.Text = "Approved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            this.optApprovedVerified.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(114, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 34);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(76, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "With GRN History";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(6, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Simple";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optInProgress);
            this.groupBox3.Controls.Add(this.optApprovedVerified);
            this.groupBox3.Location = new System.Drawing.Point(324, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 40);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // txtDemandNote
            // 
            this.txtDemandNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemandNote.Location = new System.Drawing.Point(155, 14);
            this.txtDemandNote.Name = "txtDemandNote";
            this.txtDemandNote.Size = new System.Drawing.Size(111, 21);
            this.txtDemandNote.TabIndex = 24;
            this.txtDemandNote.DoubleClick += new System.EventHandler(this.txtDemandNote_DoubleClick);
            this.txtDemandNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDemandNote_KeyDown);
            // 
            // frmDemandNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 513);
            this.Controls.Add(this.txtDemandNote);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnF1Help);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboGodownForBal);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.cboEmpCode);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblGodownForBal);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDemandNote1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDemandNote";
            this.Text = "Demand Note";
            this.Load += new System.EventHandler(this.frmDemandNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDemandNote_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDemandNote1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblGodownForBal;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboEmpCode;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.ComboBox cboGodownForBal;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMultiItemGroup;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.RadioButton optSingleItemGroup;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnF1Help;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.RadioButton optInProgress;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDemandNote;
    }
}