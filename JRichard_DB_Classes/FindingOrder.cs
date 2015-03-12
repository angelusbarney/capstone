using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class FindingOrder {
        #region Values
            public DBConnection Database;
            private int ID;
            private Finding finding;
            private Order order;
            private int Quantity;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public Finding GetFinding() {
                return this.finding;
            }
            public void SetFinding(Finding finding) {
                this.finding = finding;
            }
            public int GetQuantity() {
                return this.Quantity;
            }
            public void SetQuantity(int Quantity) {
                this.Quantity = Quantity;
            }
            public Order GetOrder()
            {
                return order;
            }
            public void SetOrder(Order order)
            {
                this.order = order;
            }
        #endregion
        #region methods
        #endregion
    }
}