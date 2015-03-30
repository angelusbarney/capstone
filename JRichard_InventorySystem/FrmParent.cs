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
    public partial class FrmParent : Form {
        FrmInventoryMenu FormInventoryMenu;
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
    }
}