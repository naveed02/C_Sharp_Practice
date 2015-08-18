namespace Cha
{
  partial class frmLookUp
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookUp));
        this.textSearch = new System.Windows.Forms.TextBox();
        this.lblSearch = new System.Windows.Forms.Label();
        this.panelSearch = new System.Windows.Forms.Panel();
        this.lblSearchIn = new System.Windows.Forms.Label();
        this.cBField = new System.Windows.Forms.ComboBox();
        this.btn_Exit = new System.Windows.Forms.Button();
        this.btn_Clear = new System.Windows.Forms.Button();
        this.btn_Select = new System.Windows.Forms.Button();
        this.btn_Search = new System.Windows.Forms.Button();
        this.panelStatus = new System.Windows.Forms.Panel();
        this.LblError = new System.Windows.Forms.Label();
        this.lblTotalRec = new System.Windows.Forms.Label();
        this.lblTotalRecTitle = new System.Windows.Forms.Label();
        this.dGVLookUp = new System.Windows.Forms.DataGridView();
        this.panelFormTitle = new System.Windows.Forms.Panel();
        this.lblTopLine3 = new System.Windows.Forms.Label();
        this.lblTopLine1 = new System.Windows.Forms.Label();
        this.lblTopLine2 = new System.Windows.Forms.Label();
        this.lblFormTitle = new System.Windows.Forms.Label();
        this.mtextReturn = new System.Windows.Forms.MaskedTextBox();
        this.textReturn = new System.Windows.Forms.TextBox();
        this.panelSearch.SuspendLayout();
        this.panelStatus.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dGVLookUp)).BeginInit();
        this.panelFormTitle.SuspendLayout();
        this.SuspendLayout();
        // 
        // textSearch
        // 
        this.textSearch.Location = new System.Drawing.Point(83, 6);
        this.textSearch.Name = "textSearch";
        this.textSearch.Size = new System.Drawing.Size(130, 20);
        this.textSearch.TabIndex = 1;
        this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
        // 
        // lblSearch
        // 
        this.lblSearch.Location = new System.Drawing.Point(3, 5);
        this.lblSearch.Name = "lblSearch";
        this.lblSearch.Size = new System.Drawing.Size(74, 20);
        this.lblSearch.TabIndex = 0;
        this.lblSearch.Text = "Se&arch Text :";
        this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // panelSearch
        // 
        this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.panelSearch.Controls.Add(this.lblSearchIn);
        this.panelSearch.Controls.Add(this.cBField);
        this.panelSearch.Controls.Add(this.btn_Exit);
        this.panelSearch.Controls.Add(this.btn_Clear);
        this.panelSearch.Controls.Add(this.btn_Select);
        this.panelSearch.Controls.Add(this.textSearch);
        this.panelSearch.Controls.Add(this.btn_Search);
        this.panelSearch.Controls.Add(this.lblSearch);
        this.panelSearch.Location = new System.Drawing.Point(28, 68);
        this.panelSearch.Name = "panelSearch";
        this.panelSearch.Size = new System.Drawing.Size(477, 59);
        this.panelSearch.TabIndex = 8;
        // 
        // lblSearchIn
        // 
        this.lblSearchIn.Location = new System.Drawing.Point(221, 6);
        this.lblSearchIn.Name = "lblSearchIn";
        this.lblSearchIn.Size = new System.Drawing.Size(62, 20);
        this.lblSearchIn.TabIndex = 22;
        this.lblSearchIn.Text = "Search In :";
        this.lblSearchIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // cBField
        // 
        this.cBField.FormattingEnabled = true;
        this.cBField.Location = new System.Drawing.Point(289, 6);
        this.cBField.Name = "cBField";
        this.cBField.Size = new System.Drawing.Size(180, 21);
        this.cBField.TabIndex = 5;
        this.cBField.SelectedIndexChanged += new System.EventHandler(this.cBField_SelectedIndexChanged);
        // 
        // btn_Exit
        // 
        this.btn_Exit.Location = new System.Drawing.Point(409, 30);
        this.btn_Exit.Name = "btn_Exit";
        this.btn_Exit.Size = new System.Drawing.Size(60, 26);
        this.btn_Exit.TabIndex = 4;
        this.btn_Exit.Text = "E&xit";
        this.btn_Exit.UseVisualStyleBackColor = true;
        this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
        // 
        // btn_Clear
        // 
        this.btn_Clear.Location = new System.Drawing.Point(337, 31);
        this.btn_Clear.Name = "btn_Clear";
        this.btn_Clear.Size = new System.Drawing.Size(60, 26);
        this.btn_Clear.TabIndex = 3;
        this.btn_Clear.Text = "Cl&ear";
        this.btn_Clear.UseVisualStyleBackColor = true;
        this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
        // 
        // btn_Select
        // 
        this.btn_Select.Location = new System.Drawing.Point(272, 31);
        this.btn_Select.Name = "btn_Select";
        this.btn_Select.Size = new System.Drawing.Size(60, 26);
        this.btn_Select.TabIndex = 3;
        this.btn_Select.Text = "Selec&t";
        this.btn_Select.UseVisualStyleBackColor = true;
        this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
        // 
        // btn_Search
        // 
        this.btn_Search.Location = new System.Drawing.Point(210, 31);
        this.btn_Search.Name = "btn_Search";
        this.btn_Search.Size = new System.Drawing.Size(60, 26);
        this.btn_Search.TabIndex = 2;
        this.btn_Search.Text = "&Search";
        this.btn_Search.UseVisualStyleBackColor = true;
        this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
        // 
        // panelStatus
        // 
        this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.panelStatus.Controls.Add(this.LblError);
        this.panelStatus.Controls.Add(this.lblTotalRec);
        this.panelStatus.Controls.Add(this.lblTotalRecTitle);
        this.panelStatus.Location = new System.Drawing.Point(-2, 385);
        this.panelStatus.Name = "panelStatus";
        this.panelStatus.Size = new System.Drawing.Size(507, 27);
        this.panelStatus.TabIndex = 9;
        // 
        // LblError
        // 
        this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.LblError.Location = new System.Drawing.Point(141, 0);
        this.LblError.Name = "LblError";
        this.LblError.Size = new System.Drawing.Size(363, 27);
        this.LblError.TabIndex = 12;
        this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTotalRec
        // 
        this.lblTotalRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTotalRec.Location = new System.Drawing.Point(79, 0);
        this.lblTotalRec.Name = "lblTotalRec";
        this.lblTotalRec.Size = new System.Drawing.Size(56, 27);
        this.lblTotalRec.TabIndex = 11;
        this.lblTotalRec.Text = "0";
        this.lblTotalRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lblTotalRecTitle
        // 
        this.lblTotalRecTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTotalRecTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTotalRecTitle.Name = "lblTotalRecTitle";
        this.lblTotalRecTitle.Size = new System.Drawing.Size(73, 27);
        this.lblTotalRecTitle.TabIndex = 10;
        this.lblTotalRecTitle.Text = "Total Rec :";
        this.lblTotalRecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // dGVLookUp
        // 
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.dGVLookUp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dGVLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.dGVLookUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(208)))), ((int)(((byte)(222)))));
        this.dGVLookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dGVLookUp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
        this.dGVLookUp.Location = new System.Drawing.Point(4, 131);
        this.dGVLookUp.Margin = new System.Windows.Forms.Padding(1);
        this.dGVLookUp.MultiSelect = false;
        this.dGVLookUp.Name = "dGVLookUp";
        this.dGVLookUp.RowHeadersVisible = false;
        this.dGVLookUp.Size = new System.Drawing.Size(501, 232);
        this.dGVLookUp.TabIndex = 0;
        this.dGVLookUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVLookUp_CellContentClick);
        this.dGVLookUp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVLookUp_CellDoubleClick);
        this.dGVLookUp.Enter += new System.EventHandler(this.dGVLookUp_Enter);
        this.dGVLookUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGVLookUp_KeyDown);
        this.dGVLookUp.Leave += new System.EventHandler(this.dGVLookUp_Leave);
        // 
        // panelFormTitle
        // 
        this.panelFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.panelFormTitle.Controls.Add(this.lblTopLine3);
        this.panelFormTitle.Controls.Add(this.lblTopLine1);
        this.panelFormTitle.Controls.Add(this.lblTopLine2);
        this.panelFormTitle.Controls.Add(this.lblFormTitle);
        this.panelFormTitle.Location = new System.Drawing.Point(1, 1);
        this.panelFormTitle.Name = "panelFormTitle";
        this.panelFormTitle.Size = new System.Drawing.Size(504, 67);
        this.panelFormTitle.TabIndex = 19;
        // 
        // lblTopLine3
        // 
        this.lblTopLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTopLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(208)))), ((int)(((byte)(222)))));
        this.lblTopLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTopLine3.ForeColor = System.Drawing.Color.White;
        this.lblTopLine3.Location = new System.Drawing.Point(3, 56);
        this.lblTopLine3.Name = "lblTopLine3";
        this.lblTopLine3.Size = new System.Drawing.Size(505, 8);
        this.lblTopLine3.TabIndex = 19;
        this.lblTopLine3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblTopLine1
        // 
        this.lblTopLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTopLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
        this.lblTopLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTopLine1.ForeColor = System.Drawing.Color.White;
        this.lblTopLine1.Location = new System.Drawing.Point(0, 0);
        this.lblTopLine1.Name = "lblTopLine1";
        this.lblTopLine1.Size = new System.Drawing.Size(504, 13);
        this.lblTopLine1.TabIndex = 16;
        this.lblTopLine1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblTopLine2
        // 
        this.lblTopLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.lblTopLine2.BackColor = System.Drawing.Color.White;
        this.lblTopLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTopLine2.ForeColor = System.Drawing.Color.White;
        this.lblTopLine2.Location = new System.Drawing.Point(0, 13);
        this.lblTopLine2.Name = "lblTopLine2";
        this.lblTopLine2.Size = new System.Drawing.Size(504, 8);
        this.lblTopLine2.TabIndex = 17;
        this.lblTopLine2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblFormTitle
        // 
        this.lblFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.lblFormTitle.BackColor = System.Drawing.SystemColors.Control;
        this.lblFormTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
        this.lblFormTitle.Location = new System.Drawing.Point(309, 21);
        this.lblFormTitle.Name = "lblFormTitle";
        this.lblFormTitle.Size = new System.Drawing.Size(176, 35);
        this.lblFormTitle.TabIndex = 4;
        this.lblFormTitle.Text = "Form ID";
        this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // mtextReturn
        // 
        this.mtextReturn.Location = new System.Drawing.Point(8, 75);
        this.mtextReturn.Name = "mtextReturn";
        this.mtextReturn.Size = new System.Drawing.Size(26, 20);
        this.mtextReturn.TabIndex = 20;
        this.mtextReturn.Visible = false;
        // 
        // textReturn
        // 
        this.textReturn.Location = new System.Drawing.Point(12, 101);
        this.textReturn.Name = "textReturn";
        this.textReturn.Size = new System.Drawing.Size(10, 20);
        this.textReturn.TabIndex = 21;
        this.textReturn.Visible = false;
        // 
        // frmLookUp
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(506, 410);
        this.Controls.Add(this.panelFormTitle);
        this.Controls.Add(this.dGVLookUp);
        this.Controls.Add(this.panelStatus);
        this.Controls.Add(this.panelSearch);
        this.Controls.Add(this.mtextReturn);
        this.Controls.Add(this.textReturn);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmLookUp";
        this.Text = "frmLookUp01";
        this.Load += new System.EventHandler(this.frmLookUp01_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookUp_KeyDown);
        this.panelSearch.ResumeLayout(false);
        this.panelSearch.PerformLayout();
        this.panelStatus.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dGVLookUp)).EndInit();
        this.panelFormTitle.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textSearch;
    private System.Windows.Forms.Label lblSearch;
    private System.Windows.Forms.Panel panelSearch;
    private System.Windows.Forms.Button btn_Select;
    private System.Windows.Forms.Button btn_Search;
    private System.Windows.Forms.Button btn_Exit;
    private System.Windows.Forms.Button btn_Clear;
    private System.Windows.Forms.Panel panelStatus;
    private System.Windows.Forms.Label lblTotalRecTitle;
    private System.Windows.Forms.Label lblTotalRec;
    private System.Windows.Forms.DataGridView dGVLookUp;
    private System.Windows.Forms.Label LblError;
    private System.Windows.Forms.Panel panelFormTitle;
    private System.Windows.Forms.Label lblTopLine3;
    private System.Windows.Forms.Label lblTopLine1;
    private System.Windows.Forms.Label lblTopLine2;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.MaskedTextBox mtextReturn;
    private System.Windows.Forms.ComboBox cBField;
    private System.Windows.Forms.Label lblSearchIn;
    private System.Windows.Forms.TextBox textReturn;
  }
}