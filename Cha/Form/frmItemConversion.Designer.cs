namespace Cha
{
    partial class frmItemConversion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.optInProgress = new System.Windows.Forms.RadioButton();
            this.cboEmpCode = new System.Windows.Forms.ComboBox();
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.lblConversion1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.btnF1HelpConversion = new System.Windows.Forms.Button();
            this.btnAddNewConversion = new System.Windows.Forms.Button();
            this.lblDateConversion = new System.Windows.Forms.Label();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.dtpDateConversion = new System.Windows.Forms.DateTimePicker();
            this.grd = new System.Windows.Forms.DataGridView();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optApprovedVerified.Location = new System.Drawing.Point(357, 406);
            this.optApprovedVerified.Margin = new System.Windows.Forms.Padding(4);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(131, 19);
            this.optApprovedVerified.TabIndex = 205;
            this.optApprovedVerified.TabStop = true;
            this.optApprovedVerified.Text = "Approved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // optInProgress
            // 
            this.optInProgress.AutoSize = true;
            this.optInProgress.Checked = true;
            this.optInProgress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProgress.Location = new System.Drawing.Point(258, 406);
            this.optInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.optInProgress.Name = "optInProgress";
            this.optInProgress.Size = new System.Drawing.Size(91, 19);
            this.optInProgress.TabIndex = 206;
            this.optInProgress.TabStop = true;
            this.optInProgress.Text = "In Progress";
            this.optInProgress.UseVisualStyleBackColor = true;
            // 
            // cboEmpCode
            // 
            this.cboEmpCode.FormattingEnabled = true;
            this.cboEmpCode.Location = new System.Drawing.Point(133, 56);
            this.cboEmpCode.Name = "cboEmpCode";
            this.cboEmpCode.Size = new System.Drawing.Size(279, 21);
            this.cboEmpCode.TabIndex = 201;
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion.Location = new System.Drawing.Point(133, 7);
            this.lblConversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(190, 20);
            this.lblConversion.TabIndex = 200;
            this.lblConversion.Text = "                                    ";
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.AutoSize = true;
            this.lblEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpCode.Location = new System.Drawing.Point(4, 56);
            this.lblEmpCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Size = new System.Drawing.Size(122, 18);
            this.lblEmpCode.TabIndex = 184;
            this.lblEmpCode.Text = "   Emp Code       ";
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(133, 83);
            this.cboItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(279, 24);
            this.cboItemGroup.TabIndex = 170;
            // 
            // lblConversion1
            // 
            this.lblConversion1.AutoSize = true;
            this.lblConversion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion1.Location = new System.Drawing.Point(4, 9);
            this.lblConversion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConversion1.Name = "lblConversion1";
            this.lblConversion1.Size = new System.Drawing.Size(124, 18);
            this.lblConversion1.TabIndex = 160;
            this.lblConversion1.Text = "    Conversion #  ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(732, 408);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 18);
            this.lblTotal.TabIndex = 168;
            this.lblTotal.Text = "                                       ";
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(4, 83);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(121, 18);
            this.lblItemGroup.TabIndex = 164;
            this.lblItemGroup.Text = "      Item Group   ";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(4, 31);
            this.lblShift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(124, 18);
            this.lblShift.TabIndex = 161;
            this.lblShift.Text = "          Shift           ";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal1.Location = new System.Drawing.Point(650, 408);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal1.Size = new System.Drawing.Size(75, 18);
            this.lblTotal1.TabIndex = 197;
            this.lblTotal1.Text = "    Total    ";
            // 
            // btnF1HelpConversion
            // 
            this.btnF1HelpConversion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpConversion.Location = new System.Drawing.Point(510, 5);
            this.btnF1HelpConversion.Name = "btnF1HelpConversion";
            this.btnF1HelpConversion.Size = new System.Drawing.Size(63, 22);
            this.btnF1HelpConversion.TabIndex = 195;
            this.btnF1HelpConversion.Text = "F1=Help";
            this.btnF1HelpConversion.UseVisualStyleBackColor = true;
            // 
            // btnAddNewConversion
            // 
            this.btnAddNewConversion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewConversion.Location = new System.Drawing.Point(577, 3);
            this.btnAddNewConversion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewConversion.Name = "btnAddNewConversion";
            this.btnAddNewConversion.Size = new System.Drawing.Size(126, 22);
            this.btnAddNewConversion.TabIndex = 181;
            this.btnAddNewConversion.Text = "Add New";
            this.btnAddNewConversion.UseVisualStyleBackColor = true;
            // 
            // lblDateConversion
            // 
            this.lblDateConversion.AutoSize = true;
            this.lblDateConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateConversion.Location = new System.Drawing.Point(338, 7);
            this.lblDateConversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateConversion.Name = "lblDateConversion";
            this.lblDateConversion.Size = new System.Drawing.Size(51, 18);
            this.lblDateConversion.TabIndex = 179;
            this.lblDateConversion.Text = "Date  ";
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(188, 402);
            this.btnPrinting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(62, 25);
            this.btnPrinting.TabIndex = 175;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(91, 403);
            this.btnEscExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(89, 23);
            this.btnEscExit.TabIndex = 176;
            this.btnEscExit.Text = "<Esc = Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(3, 402);
            this.btnExitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(83, 25);
            this.btnExitSave.TabIndex = 177;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // dtpDateConversion
            // 
            this.dtpDateConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateConversion.Location = new System.Drawing.Point(391, 7);
            this.dtpDateConversion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateConversion.Name = "dtpDateConversion";
            this.dtpDateConversion.Size = new System.Drawing.Size(113, 22);
            this.dtpDateConversion.TabIndex = 174;
            // 
            // grd
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle23;
            this.grd.Location = new System.Drawing.Point(4, 116);
            this.grd.Margin = new System.Windows.Forms.Padding(4);
            this.grd.Name = "grd";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grd.Size = new System.Drawing.Size(894, 282);
            this.grd.TabIndex = 173;
            // 
            // cboShift
            // 
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(133, 31);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(279, 21);
            this.cboShift.TabIndex = 208;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(565, 87);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(279, 22);
            this.txtNote.TabIndex = 210;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(426, 87);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(131, 18);
            this.lblNote.TabIndex = 209;
            this.lblNote.Text = "          Note            ";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // Column8
            // 
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "To Godown";
            this.Column4.Name = "Column4";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "To UOM ID";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "To Qty";
            this.Column10.Name = "Column10";
            // 
            // frmItemConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 436);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cboShift);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProgress);
            this.Controls.Add(this.cboEmpCode);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.lblEmpCode);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.lblConversion1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblTotal1);
            this.Controls.Add(this.btnF1HelpConversion);
            this.Controls.Add(this.btnAddNewConversion);
            this.Controls.Add(this.lblDateConversion);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dtpDateConversion);
            this.Controls.Add(this.grd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmItemConversion";
            this.Text = "Item Conversion";
            this.Load += new System.EventHandler(this.frmItemConversion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItemConversion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.RadioButton optInProgress;
        private System.Windows.Forms.ComboBox cboEmpCode;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.Label lblConversion1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Button btnF1HelpConversion;
        private System.Windows.Forms.Button btnAddNewConversion;
        private System.Windows.Forms.Label lblDateConversion;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.DateTimePicker dtpDateConversion;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}