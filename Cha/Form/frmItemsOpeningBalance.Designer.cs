namespace Cha
{
    partial class frmItemsOpeningBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.optSingleItemGroup = new System.Windows.Forms.RadioButton();
            this.optMultiItemGroup = new System.Windows.Forms.RadioButton();
            this.lblIOB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboItemGroup1 = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblIOB1 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblItemGroup = new System.Windows.Forms.Label();
            this.lblAmount1 = new System.Windows.Forms.Label();
            this.lblTotalQty1 = new System.Windows.Forms.Label();
            this.btnF1HelpIOB = new System.Windows.Forms.Button();
            this.btnGetItemsIOB = new System.Windows.Forms.Button();
            this.lblDateIOB = new System.Windows.Forms.Label();
            this.optQtyOut = new System.Windows.Forms.RadioButton();
            this.optQtyIn = new System.Windows.Forms.RadioButton();
            this.btnPrinting = new System.Windows.Forms.Button();
            this.btnEscExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.dtpDateIOB = new System.Windows.Forms.DateTimePicker();
            this.grd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cboItemGroup = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // optSingleItemGroup
            // 
            this.optSingleItemGroup.AutoSize = true;
            this.optSingleItemGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSingleItemGroup.Location = new System.Drawing.Point(8, 33);
            this.optSingleItemGroup.Margin = new System.Windows.Forms.Padding(4);
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
            this.optMultiItemGroup.Location = new System.Drawing.Point(8, 7);
            this.optMultiItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.optMultiItemGroup.Name = "optMultiItemGroup";
            this.optMultiItemGroup.Size = new System.Drawing.Size(185, 19);
            this.optMultiItemGroup.TabIndex = 0;
            this.optMultiItemGroup.TabStop = true;
            this.optMultiItemGroup.Text = "Multi Item Group [Size/Color]";
            this.optMultiItemGroup.UseVisualStyleBackColor = true;
            // 
            // lblIOB
            // 
            this.lblIOB.AutoSize = true;
            this.lblIOB.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblIOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIOB.Location = new System.Drawing.Point(119, 6);
            this.lblIOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIOB.Name = "lblIOB";
            this.lblIOB.Size = new System.Drawing.Size(155, 20);
            this.lblIOB.TabIndex = 152;
            this.lblIOB.Text = "                             ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSingleItemGroup);
            this.groupBox1.Controls.Add(this.optMultiItemGroup);
            this.groupBox1.Location = new System.Drawing.Point(482, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(213, 55);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(119, 62);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(344, 22);
            this.txtNote.TabIndex = 119;
            // 
            // cboItemGroup1
            // 
            this.cboItemGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup1.FormattingEnabled = true;
            this.cboItemGroup1.Location = new System.Drawing.Point(119, 33);
            this.cboItemGroup1.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup1.Name = "cboItemGroup1";
            this.cboItemGroup1.Size = new System.Drawing.Size(200, 24);
            this.cboItemGroup1.TabIndex = 118;
            this.cboItemGroup1.SelectedIndexChanged += new System.EventHandler(this.cboItemGroup_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(649, 406);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(120, 20);
            this.lblAmount.TabIndex = 114;
            this.lblAmount.Text = "                      ";
            // 
            // lblIOB1
            // 
            this.lblIOB1.AutoSize = true;
            this.lblIOB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIOB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIOB1.Location = new System.Drawing.Point(6, 8);
            this.lblIOB1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIOB1.Name = "lblIOB1";
            this.lblIOB1.Size = new System.Drawing.Size(103, 18);
            this.lblIOB1.TabIndex = 107;
            this.lblIOB1.Text = "     IOB  #        ";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty.Location = new System.Drawing.Point(420, 406);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(130, 18);
            this.lblTotalQty.TabIndex = 115;
            this.lblTotalQty.Text = "                              ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(6, 62);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(107, 18);
            this.lblNote.TabIndex = 109;
            this.lblNote.Text = "        Note        ";
            // 
            // lblItemGroup
            // 
            this.lblItemGroup.AutoSize = true;
            this.lblItemGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemGroup.Location = new System.Drawing.Point(6, 33);
            this.lblItemGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemGroup.Name = "lblItemGroup";
            this.lblItemGroup.Size = new System.Drawing.Size(105, 18);
            this.lblItemGroup.TabIndex = 111;
            this.lblItemGroup.Text = "     Item Group";
            // 
            // lblAmount1
            // 
            this.lblAmount1.AutoSize = true;
            this.lblAmount1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmount1.Location = new System.Drawing.Point(557, 405);
            this.lblAmount1.Name = "lblAmount1";
            this.lblAmount1.Size = new System.Drawing.Size(90, 18);
            this.lblAmount1.TabIndex = 151;
            this.lblAmount1.Text = "   Amount :  ";
            // 
            // lblTotalQty1
            // 
            this.lblTotalQty1.AutoSize = true;
            this.lblTotalQty1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalQty1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalQty1.Location = new System.Drawing.Point(327, 406);
            this.lblTotalQty1.Name = "lblTotalQty1";
            this.lblTotalQty1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalQty1.Size = new System.Drawing.Size(86, 18);
            this.lblTotalQty1.TabIndex = 149;
            this.lblTotalQty1.Text = "Total Qty :  ";
            // 
            // btnF1HelpIOB
            // 
            this.btnF1HelpIOB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF1HelpIOB.Location = new System.Drawing.Point(455, 6);
            this.btnF1HelpIOB.Name = "btnF1HelpIOB";
            this.btnF1HelpIOB.Size = new System.Drawing.Size(63, 22);
            this.btnF1HelpIOB.TabIndex = 147;
            this.btnF1HelpIOB.Text = "F1=Help";
            this.btnF1HelpIOB.UseVisualStyleBackColor = true;
            // 
            // btnGetItemsIOB
            // 
            this.btnGetItemsIOB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetItemsIOB.Location = new System.Drawing.Point(521, 6);
            this.btnGetItemsIOB.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetItemsIOB.Name = "btnGetItemsIOB";
            this.btnGetItemsIOB.Size = new System.Drawing.Size(74, 22);
            this.btnGetItemsIOB.TabIndex = 133;
            this.btnGetItemsIOB.Text = "Get Items";
            this.btnGetItemsIOB.UseVisualStyleBackColor = true;
            // 
            // lblDateIOB
            // 
            this.lblDateIOB.AutoSize = true;
            this.lblDateIOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDateIOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIOB.Location = new System.Drawing.Point(282, 6);
            this.lblDateIOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateIOB.Name = "lblDateIOB";
            this.lblDateIOB.Size = new System.Drawing.Size(51, 18);
            this.lblDateIOB.TabIndex = 131;
            this.lblDateIOB.Text = "Date  ";
            // 
            // optQtyOut
            // 
            this.optQtyOut.AutoSize = true;
            this.optQtyOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQtyOut.Location = new System.Drawing.Point(315, 92);
            this.optQtyOut.Margin = new System.Windows.Forms.Padding(4);
            this.optQtyOut.Name = "optQtyOut";
            this.optQtyOut.Size = new System.Drawing.Size(67, 19);
            this.optQtyOut.TabIndex = 126;
            this.optQtyOut.TabStop = true;
            this.optQtyOut.Text = "Qty Out";
            this.optQtyOut.UseVisualStyleBackColor = true;
            // 
            // optQtyIn
            // 
            this.optQtyIn.AutoSize = true;
            this.optQtyIn.Checked = true;
            this.optQtyIn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optQtyIn.Location = new System.Drawing.Point(228, 92);
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
            this.btnPrinting.Location = new System.Drawing.Point(96, 405);
            this.btnPrinting.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrinting.Name = "btnPrinting";
            this.btnPrinting.Size = new System.Drawing.Size(79, 27);
            this.btnPrinting.TabIndex = 123;
            this.btnPrinting.Text = "Printing";
            this.btnPrinting.UseVisualStyleBackColor = true;
            // 
            // btnEscExit
            // 
            this.btnEscExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscExit.Location = new System.Drawing.Point(228, 406);
            this.btnEscExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscExit.Name = "btnEscExit";
            this.btnEscExit.Size = new System.Drawing.Size(89, 27);
            this.btnEscExit.TabIndex = 124;
            this.btnEscExit.Text = "<Esc = Exit>";
            this.btnEscExit.UseVisualStyleBackColor = true;
            this.btnEscExit.Click += new System.EventHandler(this.btnEscExit_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(5, 405);
            this.btnExitSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(83, 27);
            this.btnExitSave.TabIndex = 125;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // dtpDateIOB
            // 
            this.dtpDateIOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIOB.Location = new System.Drawing.Point(335, 6);
            this.dtpDateIOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateIOB.Name = "dtpDateIOB";
            this.dtpDateIOB.Size = new System.Drawing.Size(113, 22);
            this.dtpDateIOB.TabIndex = 122;
            // 
            // grd
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9,
            this.Column12});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle11;
            this.grd.Location = new System.Drawing.Point(6, 119);
            this.grd.Margin = new System.Windows.Forms.Padding(4);
            this.grd.Name = "grd";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grd.Size = new System.Drawing.Size(763, 282);
            this.grd.TabIndex = 121;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 133;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemGroup.FormattingEnabled = true;
            this.cboItemGroup.Location = new System.Drawing.Point(327, 33);
            this.cboItemGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Size = new System.Drawing.Size(136, 24);
            this.cboItemGroup.TabIndex = 118;
            this.cboItemGroup.SelectedIndexChanged += new System.EventHandler(this.cboItemGroup_SelectedIndexChanged);
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
            // Column8
            // 
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Rate";
            this.Column9.Name = "Column9";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Amount";
            this.Column12.Name = "Column12";
            // 
            // frmItemsOpeningBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 439);
            this.Controls.Add(this.lblIOB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboItemGroup);
            this.Controls.Add(this.cboItemGroup1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblIOB1);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblItemGroup);
            this.Controls.Add(this.lblAmount1);
            this.Controls.Add(this.lblTotalQty1);
            this.Controls.Add(this.btnF1HelpIOB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetItemsIOB);
            this.Controls.Add(this.lblDateIOB);
            this.Controls.Add(this.optQtyOut);
            this.Controls.Add(this.optQtyIn);
            this.Controls.Add(this.btnPrinting);
            this.Controls.Add(this.btnEscExit);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.dtpDateIOB);
            this.Controls.Add(this.grd);
            this.KeyPreview = true;
            this.Name = "frmItemsOpeningBalance";
            this.Text = "Items Opening Balance";
            this.Load += new System.EventHandler(this.frmItemsOpeningBalance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmItemsOpeningBalance_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optSingleItemGroup;
        private System.Windows.Forms.RadioButton optMultiItemGroup;
        private System.Windows.Forms.Label lblIOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboItemGroup1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblIOB1;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblItemGroup;
        private System.Windows.Forms.Label lblAmount1;
        private System.Windows.Forms.Label lblTotalQty1;
        private System.Windows.Forms.Button btnF1HelpIOB;
        private System.Windows.Forms.Button btnGetItemsIOB;
        private System.Windows.Forms.Label lblDateIOB;
        private System.Windows.Forms.RadioButton optQtyOut;
        private System.Windows.Forms.RadioButton optQtyIn;
        private System.Windows.Forms.Button btnPrinting;
        private System.Windows.Forms.Button btnEscExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.DateTimePicker dtpDateIOB;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboItemGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}