using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_InventoryDB;
namespace JRichard_InventoryClasses {
    public class FindingOrderLine {
        #region values
        InventoryDataSet.SP_GetByID_FindingOrderLineDataTable TableAdapter;
            private int ID;
            private Finding FK_Finding;
            private FindingOrder FK_Order;
            private int Quantity;
        #endregion
        #region getters and setters
            public int GetID() {
                return ID;
            }
            public Finding GetFinding() {
                return this.FK_Finding;
            }
            public void SetFinding(Finding finding) {
                this.FK_Finding = finding;
            }
            public FindingOrder GetOrder() {
                return FK_Order;
            }
            public void SetOrder(FindingOrder Order) {
                this.FK_Order = Order;
            }
            public int GetQuantity() {
                return Quantity;
            }
            public void SetQuantity(int Quantity) {
                this.Quantity = Quantity;
            }
        #endregion
        #region methods
            public FindingOrderLine() {
                //ヽ༼ຈل͜ຈ༽ﾉ
            }
            public bool Initialize(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderLineDataTable();
                    this.ID = ID;
                    this.FK_Finding = new Finding();
                    this.FK_Finding.Initialize(TableAdapter.FindByID(ID).FindingID);
                    this.FK_Order = new FindingOrder();
                    this.FK_Order.Initialize(TableAdapter.FindByID(ID).FindingOrderID);
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Add(int ID, Finding finding, FindingOrder Order, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderLineDataTable();
                    this.FK_Finding = finding;
                    this.FK_Order = Order;
                    this.ID = ID;
                    TableAdapter.AddSP_GetByID_FindingOrderLineRow(ID, finding.GetID(), Order.GetID(), Quantity);
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, Finding finding, FindingOrder Order, int Quantity) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderLineDataTable();
                    this.FK_Finding = finding;
                    this.FK_Order = Order;
                    TableAdapter.FindByID(ID).FindingID = finding.GetID();
                    TableAdapter.FindByID(ID).FindingOrderID = Order.GetID();
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Delete(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderLineDataTable();
                    TableAdapter.FindByID(ID).Delete();
                    return true;
                } catch {
                    return false;
                }
            }
        #endregion
    }
}