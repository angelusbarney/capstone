using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JRichard_DB {
    public partial class FrmParent : Form {
        FrmCustomer FormCustomer;
        FrmCatalogue FormCatalogue;
        public FrmParent() {
            InitializeComponent();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e) {
            if (FormCustomer == null) {
                FormCustomer = new FrmCustomer();
                FormCustomer.MdiParent = this;
                FormCustomer.FormClosed += FormCustomer_FormClosed;
                FormCustomer.Show();
            } else {
                FormCustomer.Activate();
            }
        }
        private void FormCustomer_FormClosed(object sender, FormClosedEventArgs e) {
            FormCustomer = null;
        }
        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e) {
            if (FormCatalogue == null) {
                FormCatalogue = new FrmCatalogue();
                FormCatalogue.MdiParent = this.MdiParent;
                FormCatalogue.FormClosed += FormCatalogue_FormClosed;
                FormCatalogue.Show();
            } else {
                FormCatalogue.Activate();
            }
        }
        private void FormCatalogue_FormClosed(object sender, FormClosedEventArgs e) {
            FormCatalogue = null;
        }
    }
}