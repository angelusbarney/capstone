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
namespace JRichard_InventoryUI {
    public partial class FrmParent : Form {
        FrmInventoryMenu FormInventoryMenu;
        Form1 ProductForm;
        public FrmParent() {
            InitializeComponent();
        }
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (FormInventoryMenu == null) {
                FormInventoryMenu = new FrmInventoryMenu();
                FormInventoryMenu.MdiParent = this;
                FormInventoryMenu.FormClosed += FormInventoryMenu_FormClosed;
                FormInventoryMenu.Show();
            } else {
                FormInventoryMenu.Activate();
            }
        }
        private void FormInventoryMenu_FormClosed(object sender, FormClosedEventArgs e) {
            FormInventoryMenu = null;
        }
        private void productMgmtToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ProductForm == null) {
                ProductForm = new Form1();
                ProductForm.MdiParent = this;
                ProductForm.FormClosed += ProductForm_FormClosed;
                ProductForm.Show();
            } else {
                ProductForm.Activate();
            }
        }
        void ProductForm_FormClosed(object sender, FormClosedEventArgs e) {
            ProductForm = null;
        }
    }
}