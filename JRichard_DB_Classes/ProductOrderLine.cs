using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class ProductOrderLine {
        #region Values
            public DBConnection Database;
            private int ID;
            private Product product;
            private Order order;
            private int Quantity;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public Product GetProduct() {
                return this.product;
            }
            public void SetProduct(Product product) {
                this.product = product;
            }
            public Order GetOrder() {
                return this.order;
            }
            public void SetOrder(Order order) {
                this.order = order;
            }
            public int GetQuantity() {
                return this.Quantity;
            }
            public void SetQuantity(int Quantity) {
                this.Quantity = Quantity;
            }
        #endregion
        #region methods
        #endregion
    }
}
