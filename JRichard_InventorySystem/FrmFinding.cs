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
    public partial class FrmFinding : Form {
        FrmEditFinding FormEditFinding;
        Finding[] AllFindings;
        int Findings;
        public FrmFinding() {
            InitializeComponent();
            CreateList();
        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            if (FormEditFinding == null) {
                FormEditFinding = new FrmEditFinding();
                FormEditFinding.MdiParent = this.MdiParent;
                FormEditFinding.FormClosed += FormEditFinding_FormClosed;
                FormEditFinding.AcceptID(LstFinding.Items.Count);
                FormEditFinding.Show();
            } else {
                FormEditFinding.Activate();
            }
        }
        void FormEditFinding_FormClosed(object sender, FormClosedEventArgs e) {
            FormEditFinding = null;
            CreateList();
            LstFinding.SelectedIndex = -1;
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            if (FormEditFinding == null) {
                FormEditFinding = new FrmEditFinding();
                FormEditFinding.MdiParent = this.MdiParent;
                FormEditFinding.FormClosed += FormEditFinding_FormClosed;
                FormEditFinding.AcceptID(LstFinding.SelectedIndex);
                FormEditFinding.Show();
            } else {
                FormEditFinding.Activate();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            if (LstFinding.SelectedIndex > -1) {
                if (AllFindings[LstFinding.SelectedIndex].Delete(LstFinding.SelectedIndex + 1)) {
                    LstFinding.Items.RemoveAt(LstFinding.SelectedIndex);
                    LstFinding.SelectedIndex = -1;
                }
            }
        }
        private void CreateList() {
            LstFinding.Items.Clear();
            Findings = 0;
            AllFindings = new Finding[1];
            AllFindings[0] = new Finding();
            while (AllFindings[Findings].Initialize(Findings + 1)) {
                string F = AllFindings[Findings].GetName() + " x" + AllFindings[Findings].GetQuantity().ToString();
                LstFinding.Items.Add(F);
                Findings++;
                Finding[] Temp = new Finding[Findings];
                for (int T = 0; T < Findings; T++) {
                    Temp[T] = AllFindings[T];
                }
                AllFindings = new Finding[Findings + 1];
                for (int T = 0; T < Findings; T++) {
                    AllFindings[T] = Temp[T];
                }
                AllFindings[Findings] = new Finding();
            }
            AllFindings[Findings] = null;
            Findings--;
        }
    }
}