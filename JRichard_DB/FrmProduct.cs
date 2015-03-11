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
    public partial class FrmProduct : Form {
        FrmOrderLine FormOrderLine;
        FrmFinding FormFinding;
        public FrmProduct() {
            InitializeComponent();
        }
        private void BtnOrder_Click(object sender, EventArgs e) {
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
        void FormOrderLine_FormClosed(object sender, FormClosedEventArgs e) {
            FormOrderLine = null;
        }
        private void BtnSave_Click(object sender, EventArgs e) {
            //Save
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void BtnDeleteItem_Click(object sender, EventArgs e) {
            //Delete
            this.Close();
        }
        private void BtnAddFinding_Click(object sender, EventArgs e) {
            //Also send ID# = 0;
            if (FormFinding == null) {
                FormFinding = new FrmFinding();
                FormFinding.MdiParent = this.MdiParent;
                FormFinding.FormClosed += FormFinding_FormClosed;
                FormFinding.Show();
            } else {
                FormFinding.Activate();
            }
        }
        void FormFinding_FormClosed(object sender, FormClosedEventArgs e) {
            FormFinding = null;
        }
        private void BtnEditFinding_Click(object sender, EventArgs e) {
            //Also send ID#
            if (FormFinding == null) {
                FormFinding = new FrmFinding();
                FormFinding.MdiParent = this.MdiParent;
                FormFinding.FormClosed += FormFinding_FormClosed;
                FormFinding.Show();
            } else {
                FormFinding.Activate();
            }
        }
        private void BtnDeleteFinding_Click(object sender, EventArgs e) {
            //Delete
        }
    }
}