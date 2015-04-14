using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_InventoryDB;
using JRichard_InventoryDB.InventoryDataSetTableAdapters;
namespace JRichard_InventoryClasses {
    public class FindingOrder {
        #region values
            InventoryDataSet.SP_GetByID_FindingOrderDataTable TableAdapter;
            SP_GetByID_FindingOrderTableAdapter FindingOrderAdapter;
            private int ID;
            private DateTime OrderDate;
            private string Status;
            private string Notes;
        #endregion
        #region getters and setters
            public int GetID() {
                return ID;
            }
            public DateTime GetOrderDate() {
                return OrderDate;
            }
            public void SetOrderDate(DateTime OrderDate) {
                this.OrderDate = OrderDate;
            }
            public string GetStatus() {
                return Status;
            }
            public void SetStatus(string Status) {
                this.Status = Status;
            }
            public string GetNotes() {
                return Notes;
            }
            public void SetNotes(string Notes) {
                this.Notes = Notes;
            }
        #endregion
        #region methods
            public FindingOrder() {
                FindingOrderAdapter = new SP_GetByID_FindingOrderTableAdapter();
            }
            public bool Initialize(int ID) {
                try {
                    TableAdapter = FindingOrderAdapter.GetData(ID);
                    this.ID = ID;
                    this.OrderDate = TableAdapter.FindByID(ID).OrderDate;
                    this.Status = TableAdapter.FindByID(ID).Status;
                    this.Notes = TableAdapter.FindByID(ID).Notes;
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Add(int ID, DateTime OrderDate, string Status, string Notes) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderDataTable();
                    this.OrderDate = OrderDate;
                    this.Status = Status;
                    this.Notes = Notes;
                    this.ID = ID;
                    TableAdapter.AddSP_GetByID_FindingOrderRow(ID, OrderDate, Status, 1, Notes);
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Edit(int ID, string Status, string Notes) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderDataTable();
                    this.ID = ID;
                    this.Status = Status;
                    this.Notes = Notes;
                    TableAdapter.FindByID(ID).Status = Status;
                    TableAdapter.FindByID(ID).Notes = Notes;
                    TableAdapter.AcceptChanges();
                    return true;
                } catch {
                    return false;
                }
            }
            public bool Delete(int ID) {
                try {
                    TableAdapter = new InventoryDataSet.SP_GetByID_FindingOrderDataTable();
                    TableAdapter.FindByID(ID).Delete();
                    return true;
                } catch {
                    return false;
                }
            }
        #endregion
    }
}