namespace Cha
{
    partial class frmGateInword
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGateInword1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblDateGateInword = new System.Windows.Forms.Label();
            this.dtpDateGateInword = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnF1HelpGateInword = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.lblGate = new System.Windows.Forms.Label();
            this.cboGate = new System.Windows.Forms.ComboBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReceivingPersonName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.lblTotalQty1 = new System.Windows.Forms.Label();
            this.optInProcess = new System.Windows.Forms.RadioButton();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.txtGateInwordNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGateInword1
            // 
            this.lblGateInword1.AutoSize = true;
            this.lblGateInword1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGateInword1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateInword1.Location = new System.Drawing.Point(8, 11);
            this.lblGateInword1.Name = "lblGateInword1";
            this.lblGateInword1.Size = new System.Drawing.Size(93, 17);
            this.lblGateInword1.TabIndex = 0;
            this.lblGateInword1.Text = "Gate Inword #  ";
            this.lblGateInword1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(8, 37);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(80, 17);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Note               ";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(8, 63);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(83, 17);
            this.lblItemGroup.TabIndex = 0;
            this.lblItemGroup.Text = "Item Group    ";
            this.lblItemGroup.Click += new System.EventHandler(this.lblItemGroup_Click);
            // 
            // lblDateGateInword
            // 
            this.lblDateGateInword.AutoSize = true;
            this.lblDateGateInword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateGateInword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateGateInword.Location = new System.Drawing.Point(249, 11);
            this.lblDateGateInword.Name = "lblDateGateInword";
            this.lblDateGateInword.Size = new System.Drawing.Size(77, 17);
            this.lblDateGateInword.TabIndex = 0;
            this.lblDateGateInword.Text = "    Date          ";
            this.lblDateGateInword.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpDateGateInword
            // 
            this.dtpDateGateInword.Location = new System.Drawing.Point(329, 11);
            this.dtpDateGateInword.Name = "dtpDateGateInword";
            this.dtpDateGateInword.Size = new System.Drawing.Size(98, 20);
            this.dtpDateGateInword.TabIndex = 1;
            this.dtpDateGateInword.ValueChanged += new System.EventHandler(this.dtpDateGateInword_ValueChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(94, 37);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(319, 20);
            this.txtNote.TabIndex = 2;
            this.txtNote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnF1HelpGateInword
            // 
            this.btnF1HelpGateInword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpGateInword.Location = new System.Drawing.Point(433, 6);
            this.btnF1HelpGateInword.Name = "btnF1HelpGateInword";
            this.btnF1HelpGateInword.Size = new System.Drawing.Size(67, 25);
            this.btnF1HelpGateInword.TabIndex = 3;
            this.btnF1HelpGateInword.Text = "F1=Help";
            this.btnF1HelpGateInword.UseVisualStyleBackColor = true;
            this.btnF1HelpGateInword.Click += new System.EventHandler(this.btnF1Help_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(422, 35);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(67, 24);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(8, 483);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(71, 23);
            this.btnExitSave.TabIndex = 3;
            this.btnExitSave.Text = "Exit+Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            this.btnExitSave.Click += new System.EventHandler(this.btnExitSave_Click);
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(166, 484);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(79, 22);
            this.btnEscExit.TabIndex = 3;
            this.btnEscExit.Text = "<Esc+Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(85, 483);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(75, 23);
            this.btnPrinting.TabIndex = 3;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            this.btnPrinting.Click += new System.EventHandler(this.btnPrinting_Click);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(495, 37);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(52, 17);
            this.lblTime1.TabIndex = 4;
            this.lblTime1.Text = "  Time   ";
            this.lblTime1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(557, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(123, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "                                      ";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(94, 63);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(266, 21);
            this.cboItemGroup.TabIndex = 5;
            this.cboItemGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblGate
            // 
            this.lblGate.AutoSize = true;
            this.lblGate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblGate.Location = new System.Drawing.Point(366, 65);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(44, 17);
            this.lblGate.TabIndex = 6;
            this.lblGate.Text = "Gate   ";
            this.lblGate.Click += new System.EventHandler(this.lblGate_Click);
            // 
            // cboGate
            // 
            this.cboGate.FormattingEnabled = true;
            this.cboGate.Location = new System.Drawing.Point(422, 65);
            this.cboGate.Name = "cboGate";
            this.cboGate.Size = new System.Drawing.Size(258, 21);
            this.cboGate.TabIndex = 7;
            this.cboGate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // grd
            // 
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd.Location = new System.Drawing.Point(8, 95);
            this.grd.Name = "grd";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grd.Size = new System.Drawing.Size(672, 360);
            this.grd.TabIndex = 8;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // Column9
            // 
            this.Column9.HeaderText = "Qty";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UOM";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Godown";
            this.Column8.Name = "Column8";
            // 
            // lblReceivingPersonName
            // 
            this.lblReceivingPersonName.AutoSize = true;
            this.lblReceivingPersonName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceivingPersonName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivingPersonName.Location = new System.Drawing.Point(8, 458);
            this.lblReceivingPersonName.Name = "lblReceivingPersonName";
            this.lblReceivingPersonName.Size = new System.Drawing.Size(162, 18);
            this.lblReceivingPersonName.TabIndex = 9;
            this.lblReceivingPersonName.Text = "Receiving Person Name";
            this.lblReceivingPersonName.Click += new System.EventHandler(this.lblReceivingPersonName_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 460);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(504, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(251, 483);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(56, 17);
            this.chkPrinter.TabIndex = 11;
            this.chkPrinter.Text = "Printer";
            this.chkPrinter.UseVisualStyleBackColor = true;
            this.chkPrinter.CheckedChanged += new System.EventHandler(this.chkPrinter_CheckedChanged);
            // 
            // lblTotalQty1
            // 
            this.lblTotalQty1.AutoSize = true;
            this.lblTotalQty1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty1.Location = new System.Drawing.Point(514, 483);
            this.lblTotalQty1.Name = "lblTotalQty1";
            this.lblTotalQty1.Size = new System.Drawing.Size(67, 17);
            this.lblTotalQty1.TabIndex = 13;
            this.lblTotalQty1.Text = "Total Qty:  ";
            this.lblTotalQty1.Click += new System.EventHandler(this.lblTotalQty1_Click);
            // 
            // optInProcess
            // 
            this.optInProcess.AutoSize = true;
            this.optInProcess.Checked = true;
            this.optInProcess.Location = new System.Drawing.Point(313, 483);
            this.optInProcess.Name = "optInProcess";
            this.optInProcess.Size = new System.Drawing.Size(75, 17);
            this.optInProcess.TabIndex = 14;
            this.optInProcess.TabStop = true;
            this.optInProcess.Text = "In Process";
            this.optInProcess.UseVisualStyleBackColor = true;
            this.optInProcess.CheckedChanged += new System.EventHandler(this.optInProcess_CheckedChanged);
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Location = new System.Drawing.Point(391, 483);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(117, 17);
            this.optApprovedVerified.TabIndex = 14;
            this.optApprovedVerified.Text = "Approved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            this.optApprovedVerified.CheckedChanged += new System.EventHandler(this.optApprovedVerified_CheckedChanged);
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(587, 484);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(90, 17);
            this.lblTotalQty.TabIndex = 15;
            this.lblTotalQty.Text = "                           ";
            // 
            // txtGateInwordNumber
            // 
            this.txtGateInwordNumber.Location = new System.Drawing.Point(107, 9);
            this.txtGateInwordNumber.Name = "txtGateInwordNumber";
            this.txtGateInwordNumber.Size = new System.Drawing.Size(125, 20);
            this.txtGateInwordNumber.TabIndex = 16;
            this.txtGateInwordNumber.TextChanged += new System.EventHandler(this.txtGateInwordNumber_TextChanged);
            this.txtGateInwordNumber.DoubleClick += new System.EventHandler(this.txtGateInwordNumber_DoubleClick);
            this.txtGateInwordNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGateInwordNumber_KeyDown);
            // 
            // frmGateInword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 517);
            this.Controls.Add(this.txtGateInwordNumber);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProcess);
            this.Controls.Add(this.lblTotalQty1);
            this.Controls.Add(this.chkPrinter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblReceivingPersonName);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.cboGate);
            this.Controls.Add(this.lblGate);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnF1HelpGateInword);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpDateGateInword);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDateGateInword);
            this.Controls.Add(this.lblGateInword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmGateInword";
            this.Text = "Gate Inword";
            this.Load += new System.EventHandler(this.frmGateInword_Load);
            this.DoubleClick += new System.EventHandler(this.frmGateInword_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGateInword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGateInword1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblDateGateInword;
        private System.Windows.Forms.DateTimePicker dtpDateGateInword;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnF1HelpGateInword;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.ComboBox cboGate;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label lblReceivingPersonName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.Label lblTotalQty1;
        private System.Windows.Forms.RadioButton optInProcess;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.TextBox txtGateInwordNumber;
    }
}