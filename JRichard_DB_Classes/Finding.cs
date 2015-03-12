using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Finding {
        #region Values
            public DBConnection Database;
            private int ID;
            private string Name;
            private string Description;
            private double Cost;
            private Supplier supplier;
            private string ImageFile;
            private string Colour;
        #endregion
        #region Getters and Setters
            public int GetID() {
                return this.ID;
            }
            public string GetName() {
                return this.Name;
            }
            public void SetName(string Name) {
                this.Name = Name;
            }
            public string GetDescription() {
                return this.Description;
            }
            public void SetDescription(string Description) {
                this.Description = Description;
            }
            public double GetCost() {
                return this.Cost;
            }
            public void SetCost(double Cost) {
                this.Cost = Cost;
            }
            public Supplier GetSupplier() {
                return this.supplier;
            }
            public void SetSupplier(Supplier supplier) {
                this.supplier = supplier;
            }
            public string GetImageFile() {
                return this.ImageFile;
            }
            public void SetImageFile(string ImageFile) {
                this.ImageFile = ImageFile;
            }
            public string GetColour() {
                return this.Colour;
            }
            public void SetColour(string Colour) {
                this.Colour = Colour;
            }
        #endregion
        #region methods
        #endregion
    }
}