namespace Cha
{
    partial class frmGodownToGodownShifting
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
            this.cboFromGodown = new System.Windows.Forms.ComboBox();
            this.cboToGodown = new System.Windows.Forms.ComboBox();
            this.lblGToG = new System.Windows.Forms.Label();
            this.lblToGodown = new System.Windows.Forms.Label();
            this.lblFromGodown = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblGToG1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblTotalValue1 = new System.Windows.Forms.Label();
            this.btnF1HelpGToG = new System.Windows.Forms.Button();
            this.btnAddNewGRN = new System.Windows.Forms.Button();
            this.lblDateGToG = new System.Windows.Forms.Label();
            this.optApprovedVerified = new System.Windows.Forms.RadioButton();
            this.optInProgress = new System.Windows.Forms.RadioButton();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.dtpDateGToG = new System.Windows.Forms.DateTimePicker();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFromGodown
            // 
            this.cboFromGodown.FormattingEnabled = true;
            this.cboFromGodown.Location = new System.Drawing.Point(142, 34);
            this.cboFromGodown.Name = "cboFromGodown";
            this.cboFromGodown.Size = new System.Drawing.Size(279, 21);
            this.cboFromGodown.TabIndex = 153;
            // 
            // cboToGodown
            // 
            this.cboToGodown.FormattingEnabled = true;
            this.cboToGodown.Location = new System.Drawing.Point(142, 61);
            this.cboToGodown.Name = "cboToGodown";
            this.cboToGodown.Size = new System.Drawing.Size(279, 21);
            this.cboToGodown.TabIndex = 155;
            // 
            // lblGToG
            // 
            this.lblGToG.AutoSize = true;
            this.lblGToG.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblGToG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGToG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGToG.Location = new System.Drawing.Point(142, 9);
            this.lblGToG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGToG.Name = "lblGToG";
            this.lblGToG.Size = new System.Drawing.Size(190, 20);
            this.lblGToG.TabIndex = 152;
            this.lblGToG.Text = "                                    ";
            // 
            // lblToGodown
            // 
            this.lblToGodown.AutoSize = true;
            this.lblToGodown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToGodown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToGodown.Location = new System.Drawing.Point(5, 64);
            this.lblToGodown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToGodown.Name = "lblToGodown";
            this.lblToGodown.Size = new System.Drawing.Size(133, 18);
            this.lblToGodown.TabIndex = 135;
            this.lblToGodown.Text = "  To Godown         ";
            // 
            // lblFromGodown
            // 
            this.lblFromGodown.AutoSize = true;
            this.lblFromGodown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFromGodown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromGodown.Location = new System.Drawing.Point(5, 37);
            this.lblFromGodown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromGodown.Name = "lblFromGodown";
            this.lblFromGodown.Size = new System.Drawing.Size(133, 18);
            this.lblFromGodown.TabIndex = 136;
            this.lblFromGodown.Text = "  From Godown     ";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(142, 89);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(348, 22);
            this.txtNote.TabIndex = 119;
            this.txtNote.Text = "   ";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(142, 119);
            this.cboItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(248, 24);
            this.cboItemGroup.TabIndex = 118;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(772, 441);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(155, 20);
            this.lblTotalValue.TabIndex = 114;
            this.lblTotalValue.Text = "                             ";
            // 
            // lblGToG1
            // 
            this.lblGToG1.AutoSize = true;
            this.lblGToG1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGToG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGToG1.Location = new System.Drawing.Point(5, 11);
            this.lblGToG1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGToG1.Name = "lblGToG1";
            this.lblGToG1.Size = new System.Drawing.Size(133, 18);
            this.lblGToG1.TabIndex = 107;
            this.lblGToG1.Text = "        G to G #         ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(5, 90);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(131, 18);
            this.lblNote.TabIndex = 109;
            this.lblNote.Text = "          Note            ";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(5, 121);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(133, 18);
            this.lblItemGroup.TabIndex = 111;
            this.lblItemGroup.Text = "         Item Group   ";
            // 
            // lblTotalValue1
            // 
            this.lblTotalValue1.AutoSize = true;
            this.lblTotalValue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue1.Location = new System.Drawing.Point(676, 441);
            this.lblTotalValue1.Name = "lblTotalValue1";
            this.lblTotalValue1.Size = new System.Drawing.Size(89, 18);
            this.lblTotalValue1.TabIndex = 151;
            this.lblTotalValue1.Text = "Total Value ";
            // 
            // btnF1HelpGToG
            // 
            this.btnF1HelpGToG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpGToG.Location = new System.Drawing.Point(511, 7);
            this.btnF1HelpGToG.Name = "btnF1HelpGToG";
            this.btnF1HelpGToG.Size = new System.Drawing.Size(63, 22);
            this.btnF1HelpGToG.TabIndex = 147;
            this.btnF1HelpGToG.Text = "F1=Help";
            this.btnF1HelpGToG.UseVisualStyleBackColor = true;
            // 
            // btnAddNewGRN
            // 
            this.btnAddNewGRN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewGRN.Location = new System.Drawing.Point(839, 121);
            this.btnAddNewGRN.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewGRN.Name = "btnAddNewGRN";
            this.btnAddNewGRN.Size = new System.Drawing.Size(75, 24);
            this.btnAddNewGRN.TabIndex = 133;
            this.btnAddNewGRN.Text = "Add New";
            this.btnAddNewGRN.UseVisualStyleBackColor = true;
            // 
            // lblDateGToG
            // 
            this.lblDateGToG.AutoSize = true;
            this.lblDateGToG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateGToG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateGToG.Location = new System.Drawing.Point(339, 9);
            this.lblDateGToG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateGToG.Name = "lblDateGToG";
            this.lblDateGToG.Size = new System.Drawing.Size(51, 18);
            this.lblDateGToG.TabIndex = 131;
            this.lblDateGToG.Text = "Date  ";
            // 
            // optApprovedVerified
            // 
            this.optApprovedVerified.AutoSize = true;
            this.optApprovedVerified.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optApprovedVerified.Location = new System.Drawing.Point(359, 441);
            this.optApprovedVerified.Margin = new System.Windows.Forms.Padding(4);
            this.optApprovedVerified.Name = "optApprovedVerified";
            this.optApprovedVerified.Size = new System.Drawing.Size(131, 19);
            this.optApprovedVerified.TabIndex = 126;
            this.optApprovedVerified.TabStop = true;
            this.optApprovedVerified.Text = "Approved / Verified";
            this.optApprovedVerified.UseVisualStyleBackColor = true;
            // 
            // optInProgress
            // 
            this.optInProgress.AutoSize = true;
            this.optInProgress.Checked = true;
            this.optInProgress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInProgress.Location = new System.Drawing.Point(260, 441);
            this.optInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.optInProgress.Name = "optInProgress";
            this.optInProgress.Size = new System.Drawing.Size(91, 19);
            this.optInProgress.TabIndex = 127;
            this.optInProgress.TabStop = true;
            this.optInProgress.Text = "In Progress";
            this.optInProgress.UseVisualStyleBackColor = true;
            // 
            // btnPrinting
            // 
            this.btnPrinting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinting.Location = new System.Drawing.Point(190, 438);
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
            this.btnEscExit.Location = new System.Drawing.Point(93, 439);
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
            this.btnExitSave.Location = new System.Drawing.Point(5, 438);
            this.btnExitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(83, 25);
            this.btnExitSave.TabIndex = 125;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // dtpDateGToG
            // 
            this.dtpDateGToG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateGToG.Location = new System.Drawing.Point(392, 9);
            this.dtpDateGToG.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateGToG.Name = "dtpDateGToG";
            this.dtpDateGToG.Size = new System.Drawing.Size(113, 22);
            this.dtpDateGToG.TabIndex = 122;
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
            this.Column4,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle23;
            this.grd.Location = new System.Drawing.Point(5, 151);
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
            this.grd.Size = new System.Drawing.Size(922, 282);
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
            // Column4
            // 
            this.Column4.HeaderText = "From Godown Stock";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "To Godown Stock";
            this.Column9.Name = "Column9";
            // 
            // frmGodownToGodownShifting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.cboFromGodown);
            this.Controls.Add(this.cboToGodown);
            this.Controls.Add(this.lblGToG);
            this.Controls.Add(this.lblToGodown);
            this.Controls.Add(this.lblFromGodown);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblGToG1);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblTotalValue1);
            this.Controls.Add(this.btnF1HelpGToG);
            this.Controls.Add(this.btnAddNewGRN);
            this.Controls.Add(this.lblDateGToG);
            this.Controls.Add(this.optApprovedVerified);
            this.Controls.Add(this.optInProgress);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dtpDateGToG);
            this.Controls.Add(this.grd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmGodownToGodownShifting";
            this.Text = "Godown To Godown Shifting";
            this.Load += new System.EventHandler(this.frmGodownToGodownShifting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGodownToGodownShifting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFromGodown;
        private System.Windows.Forms.ComboBox cboToGodown;
        private System.Windows.Forms.Label lblGToG;
        private System.Windows.Forms.Label lblToGodown;
        private System.Windows.Forms.Label lblFromGodown;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblGToG1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblTotalValue1;
        private System.Windows.Forms.Button btnF1HelpGToG;
        private System.Windows.Forms.Button btnAddNewGRN;
        private System.Windows.Forms.Label lblDateGToG;
        private System.Windows.Forms.RadioButton optApprovedVerified;
        private System.Windows.Forms.RadioButton optInProgress;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.DateTimePicker dtpDateGToG;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}