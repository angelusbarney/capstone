using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Order {
        #region Values
            public DBConnection Database;
            private int ID;
            private DateTime OrderDate;
            private string Status;
            private Contact contact;
            private bool IsProductOrder;
            private string Notes;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public DateTime GetOrderDate() {
                return this.OrderDate;
            }
            public string GetStatus() {
                return this.Status;
            }
            public void SetStatus(string Status) {
                this.Status = Status;
            }
            public Contact GetContact() {
                return this.contact;
            }
            public void SetContact(Contact contact) {
                this.contact = contact;
            }
            public bool GetIsProductOrder() {
                return this.IsProductOrder;
            }
            public void SetIsProductOrder(bool IsProductOrder) {
                this.IsProductOrder = IsProductOrder;
            }
            public string GetNotes() {
                return this.Notes;
            }
            public void SetNotes(string Notes) {
                this.Notes = Notes;
            }
        #endregion
        #region methods
        #endregion
    }
}