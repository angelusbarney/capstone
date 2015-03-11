using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functionality;
namespace JRichard_DB {
    public partial class FrmOrder : Form {
        FrmOrderLine FormOrderLine;
        FrmCatalogue FormCatalogue;
        public FrmOrder() {
            InitializeComponent();
        }
        private void CmbOrder_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            if (FormCatalogue == null) {
                FormCatalogue = new FrmCatalogue();
                FormCatalogue.MdiParent = this.MdiParent;
                FormCatalogue.FormClosed += FormCatalogue_FormClosed;
                FormCatalogue.Show();
            } else {
                FormCatalogue.Activate();
            }
        }
        void FormCatalogue_FormClosed(object sender, FormClosedEventArgs e) {
            FormCatalogue = null;
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormOrderLine == null) {
                FormOrderLine = new FrmOrderLine();
                FormOrderLine.MdiParent = this.MdiParent;
                FormOrderLine.FormClosed += FormOrderLine_FormClosed;
                FormOrderLine.Show();
            } else {
                FormOrderLine.Activate();
            }
        }
        private void FormOrderLine_FormClosed(object sender, FormClosedEventArgs e) {
            FormOrderLine = null;
            CmbOrder.SelectedIndex = -1;
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            //Delete
        }
        private void BtnFullDelete_Click(object sender, EventArgs e) {
            //Delete
            CmbOrder.SelectedIndex = -1;
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            CmbOrder.SelectedIndex = -1;
        }
    }
}