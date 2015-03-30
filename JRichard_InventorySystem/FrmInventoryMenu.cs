using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JRichard_InventoryUI {
    public partial class FrmInventoryMenu : Form {
        FrmFinding FormFinding;
        FrmOrders FormOrders;
        FrmContacts FormContacts;
        FrmSLAs FormSLAs;
        public FrmInventoryMenu() {
            InitializeComponent();
        }
        private void BtnInventory_Click(object sender, EventArgs e) {
            if (FormFinding == null) {
                FormFinding = new FrmFinding();
                FormFinding.MdiParent = this.MdiParent;
                FormFinding.FormClosed += FormFinding_FormClosed;
                FormFinding.Show();
            } else {
                FormFinding.Activate();
            }
        }
        private void FormFinding_FormClosed(object sender, FormClosedEventArgs e) {
            FormFinding = null;
        }
        private void BtnOrders_Click(object sender, EventArgs e) {
            if (FormOrders == null) {
                FormOrders = new FrmOrders();
                FormOrders.MdiParent = this.MdiParent;
                FormOrders.FormClosed += FormOrders_FormClosed;
                FormOrders.Show();
            } else {
                FormOrders.Activate();
            }
        }
        void FormOrders_FormClosed(object sender, FormClosedEventArgs e) {
            FormOrders = null;
        }
        private void BtnContacts_Click(object sender, EventArgs e) {
            if (FormContacts == null) {
                FormContacts = new FrmContacts();
                FormContacts.MdiParent = this.MdiParent;
                FormContacts.FormClosed += FormContacts_FormClosed;
                FormContacts.Show();
            } else {
                FormContacts.Activate();
            }
        }
        void FormContacts_FormClosed(object sender, FormClosedEventArgs e) {
            FormContacts = null;
        }
        private void BtnSLAs_Click(object sender, EventArgs e) {
            if (FormSLAs == null) {
                FormSLAs = new FrmSLAs();
                FormSLAs.MdiParent = this.MdiParent;
                FormSLAs.FormClosed += FormSLAs_FormClosed;
                FormSLAs.Show();
            } else {
                FormSLAs.Activate();
            }
        }
        void FormSLAs_FormClosed(object sender, FormClosedEventArgs e) {
            FormSLAs = null;
        }
    }
}