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
    public partial class FrmOrders : Form {
        FrmOrderLine FormOrderLine;
        FrmAddOrder FormAddOrder;
        FindingOrder[] AllOrders;
        FindingOrderLine[] AllLines;
        int Orders;
        public FrmOrders() {
            InitializeComponent();
            LstOrderItems.Items.Clear();
            UpdateCMB();
            int Lines = 0;
            AllLines = new FindingOrderLine[1];
            AllLines[0] = new FindingOrderLine();
            while (AllLines[Lines].Initialize(Lines + 1)) {
                Lines++;
                FindingOrderLine[] Temp = new FindingOrderLine[Lines];
                for (int T = 0; T < Lines; T++) {
                    Temp[T] = AllLines[T];
                }
                AllLines = new FindingOrderLine[Lines + 1];
                for (int T = 0; T < Lines; T++) {
                    AllLines[T] = Temp[T];
                }
                AllLines[Lines] = new FindingOrderLine();
            }
            AllLines[Lines] = null;
            Lines--;
        }
        private void CmbOrders_SelectedIndexChanged(object sender, EventArgs e) {
            LstOrderItems.Items.Clear();
            foreach (FindingOrderLine L in AllLines) {
                if (L.GetOrder().GetID() == AllOrders[CmbOrders.SelectedIndex].GetID()) {
                    string Line = L.GetFinding().GetName() + L.GetQuantity().ToString();
                    LstOrderItems.Items.Add(Line);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e) {
            if (FormOrderLine == null) {
                FormOrderLine = new FrmOrderLine();
                FormOrderLine.MdiParent = this.MdiParent;
                FormOrderLine.FormClosed += FormOrderLine_FormClosed;
                FormOrderLine.AcceptID(-1, AllOrders[CmbOrders.SelectedIndex]);
                FormOrderLine.Show();
            } else {
                FormOrderLine.Activate();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e) {
            if (FormOrderLine == null) {
                FormOrderLine = new FrmOrderLine();
                FormOrderLine.MdiParent = this.MdiParent;
                FormOrderLine.FormClosed += FormOrderLine_FormClosed;
                if (LstOrderItems.SelectedIndex > -1) {
                    FormOrderLine.AcceptID(AllLines[LstOrderItems.SelectedIndex].GetID(),
                        AllOrders[CmbOrders.SelectedIndex]);
                } else {
                    FormOrderLine.AcceptID(-1, AllOrders[CmbOrders.SelectedIndex]);
                }
                FormOrderLine.Show();
            } else {
                FormOrderLine.Activate();
            }
        }
        private void FormOrderLine_FormClosed(object sender, FormClosedEventArgs e) {
            FormOrderLine = null;
            LstOrderItems.SelectedIndex = -1;
            CmbOrders.SelectedIndex = -1;
        }
        private void BtnDelete_Click(object sender, EventArgs e) {
            if (LstOrderItems.SelectedIndex > -1) {
                if (AllLines[LstOrderItems.SelectedIndex].Delete(LstOrderItems.SelectedIndex + 1)) {
                    LstOrderItems.Items.RemoveAt(LstOrderItems.SelectedIndex);
                    LstOrderItems.SelectedIndex = -1;
                }
            }
        }
        private void BtnNewOrder_Click(object sender, EventArgs e) {
            if (FormAddOrder == null) {
                FormAddOrder = new FrmAddOrder();
                FormAddOrder.MdiParent = this.MdiParent;
                FormAddOrder.FormClosed += FormAddOrder_FormClosed;
                FormAddOrder.AcceptID(CmbOrders.SelectedIndex);
                FormAddOrder.Show();
            } else {
                FormAddOrder.Activate();
            }
        }
        void FormAddOrder_FormClosed(object sender, FormClosedEventArgs e) {
            FormAddOrder = null;
            UpdateCMB();
            CmbOrders.SelectedIndex = -1;
        }
        public void UpdateCMB() {
            CmbOrders.Items.Clear();
            Orders = 0;
            AllOrders = new FindingOrder[1];
            AllOrders[0] = new FindingOrder();
            while (AllOrders[Orders].Initialize(Orders + 1)) {
                string O = "#" + AllOrders[Orders].GetID().ToString() + " @"
                    + AllOrders[Orders].GetOrderDate().ToShortDateString();
                CmbOrders.Items.Add(O);
                Orders++;
                FindingOrder[] Temp = new FindingOrder[Orders];
                for (int T = 0; T < Orders; T++) {
                    Temp[T] = AllOrders[T];
                }
                AllOrders = new FindingOrder[Orders + 1];
                for (int T = 0; T < Orders; T++) {
                    AllOrders[T] = Temp[T];
                }
                AllOrders[Orders] = new FindingOrder();
            }
            AllOrders[Orders] = null;
            Orders--;
        }
    }
}