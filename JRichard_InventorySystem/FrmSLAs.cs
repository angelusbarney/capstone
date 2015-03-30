using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRichard_InventoryClasses;
namespace JRichard_InventoryUI {
    public partial class FrmSLAs : Form {
        FrmEditSLA FormEditSLA;
        SLA[] AllSLAs;
        int SLAs;
        public FrmSLAs() {
            InitializeComponent();
            UpdateCMB();
        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            if (FormEditSLA == null) {
                FormEditSLA = new FrmEditSLA();
                FormEditSLA.MdiParent = this.MdiParent;
                FormEditSLA.FormClosed += FormEditSLA_FormClosed;
                FormEditSLA.AcceptID(-1);
                FormEditSLA.Show();
            } else {
                FormEditSLA.Activate();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            if (CmbSLAs.SelectedIndex < 0) {
                if (FormEditSLA == null) {
                    FormEditSLA = new FrmEditSLA();
                    FormEditSLA.MdiParent = this.MdiParent;
                    FormEditSLA.FormClosed += FormEditSLA_FormClosed;
                    FormEditSLA.AcceptID(-1);
                    FormEditSLA.Show();
                } else {
                    FormEditSLA.Activate();
                }
            } else {
                if (FormEditSLA == null) {
                    FormEditSLA = new FrmEditSLA();
                    FormEditSLA.MdiParent = this.MdiParent;
                    FormEditSLA.FormClosed += FormEditSLA_FormClosed;
                    FormEditSLA.AcceptID(CmbSLAs.SelectedIndex + 1);
                    FormEditSLA.Show();
                } else {
                    FormEditSLA.Activate();
                }
            }
        }
        void FormEditSLA_FormClosed(object sender, FormClosedEventArgs e) {
            FormEditSLA = null;
            UpdateCMB();
            CmbSLAs.SelectedIndex = -1;
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            if (CmbSLAs.SelectedIndex > -1) {
                if (AllSLAs[CmbSLAs.SelectedIndex].Delete(CmbSLAs.SelectedIndex + 1)) {
                    UpdateCMB();
                    CmbSLAs.SelectedIndex = -1;
                }
            }
        }
        public void UpdateCMB() {
            CmbSLAs.Items.Clear();
            SLAs = 0;
            AllSLAs = new SLA[1];
            AllSLAs[0] = new SLA();
            while (AllSLAs[SLAs].Initialize(SLAs + 1)) {
                string S = "#" + AllSLAs[SLAs].GetID() + ": " + AllSLAs[SLAs].GetFinding().GetName();
                CmbSLAs.Items.Add(S);
                SLAs++;
                SLA[] Temp = new SLA[SLAs];
                for (int T = 0; T < SLAs; T++) {
                    Temp[T] = AllSLAs[T];
                }
                AllSLAs = new SLA[SLAs + 1];
                for (int T = 0; T < SLAs; T++) {
                    AllSLAs[T] = Temp[T];
                }
                AllSLAs[SLAs] = new SLA();
            }
            AllSLAs[SLAs] = null;
            SLAs--;
        }
    }
}