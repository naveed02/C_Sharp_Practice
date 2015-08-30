using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cha
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm = new frmPurchaseOrder();
            frm.MdiParent = this;
            frm.Show();
        
        }

        private void demandNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemandNote frm = new frmDemandNote();
            frm.MdiParent = this;
            frm.Show();
        
            
        }

        private void invoiceEntry90ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void accountReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void executivREportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void ledgerStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginIms frm = new frmLoginIms();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gateInwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGateInword frm = new frmGateInword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void goodsReceiveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNote frm = new frmGoodsReceiveNote();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gateOutwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGateOutword frm = new frmGateOutword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salesGateOutwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gateOutWardDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGateOutwardDelivery frm = new frmGateOutwardDelivery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemConversion frm = new frmItemConversion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void finishItemReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinishItemReceive frm = new frmFinishItemReceive();
            frm.MdiParent = this;
            frm.Show();
        }

        private void finishItemReceivedeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinishItemReceiveFormulaEffected frm = new frmFinishItemReceiveFormulaEffected();
            frm.MdiParent = this;
            frm.Show();
        
        }

        private void claimContractorProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClaimFromContractors frm = new frmClaimFromContractors();
            frm.MdiParent = this;
            frm.Show();
        }

        private void issueForRePackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueForRepacking frm = new frmIssueForRepacking();
            frm.MdiParent = this;
            frm.Show();
        }

        private void godownToGodownShiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGodownToGodownShifting frm = new frmGodownToGodownShifting();
            frm.MdiParent = this;
            frm.Show();
        }
        private void itemsOpeningBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsOpeningBalance frm = new frmItemsOpeningBalance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemsOpeningBalanceWipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsOpeningBalanceWorkInProcess frm = new frmItemsOpeningBalanceWorkInProcess();
            frm.MdiParent = this;
            frm.Show();
        }

        private void stockLevelMaximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsStockLevelDetail frm = new frmItemsStockLevelDetail();
            frm.MdiParent = this;
            frm.Show();

        }

        private void issueItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueItems frm = new frmIssueItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void issueItemsFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueItemsGeneralProductionFormula frm = new frmIssueItemsGeneralProductionFormula();
            frm.MdiParent = this;
            frm.Show();
        }

        private void issueItemsBatchWiseDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueItemsBatchWiseDepartment frm = new frmIssueItemsBatchWiseDepartment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void goodsReceiveNoteReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsReceiveNoteReturn frm = new frmGoodsReceiveNoteReturn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void issueReturnItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueReturnItems frm = new frmIssueReturnItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void saleOrderEntryQuotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleOrderEntryFactory frm = new frmSaleOrderEntryFactory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deliveryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeliveryOrderFactory frm = new FrmDeliveryOrderFactory();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
