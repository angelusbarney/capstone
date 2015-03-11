using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPSTN_ProductManagement;
namespace JRichard_DB {
    public partial class FrmCustomer : Form {
        FrmContact FormContact;
        FrmOrder FormOrder;
        public FrmCustomer() {
            InitializeComponent();
        }
        public void LoadCustomers() {
            //Load
        }
        private void CmbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e) {
            //Select
        }
        private void BtnContact_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormContact == null) {
                FormContact = new FrmContact();
                FormContact.MdiParent = this.MdiParent;
                FormContact.FormClosed += FormContact_FormClosed;
                FormContact.Show();
            } else {
                FormContact.Activate();
            }
        }
        private void FormContact_FormClosed(object sender, FormClosedEventArgs e) {
            FormContact = null;
            CmbCustomer.SelectedIndex = -1;
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            CmbCustomer.SelectedIndex = -1;
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            //Delete
            CmbCustomer.SelectedIndex = -1;
        }
        private void BtnOrders_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormOrder == null) {
                FormOrder = new FrmOrder();
                FormOrder.MdiParent = this.MdiParent;
                FormOrder.FormClosed += FormOrder_FormClosed;
                FormOrder.Show();
            } else {
                FormOrder.Activate();
            }
        }
        private void FormOrder_FormClosed(object sender, FormClosedEventArgs e) {
            FormOrder = null;
            CmbCustomer.SelectedIndex = -1;
        }
    }
}