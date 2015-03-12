using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Product {
        #region Values
            public DBConnection Database;
            private int ID;
            private string Name;
            private string Description;
            private double Price;
            private string ImageFile;
            private string Size;
            private string Colour;
            private string Status;
            private string Notes;
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
            public double GetPrice() {
                return this.Price;
            }
            public void SetPrice(double Price) {
                this.Price = Price;
            }
            public string GetImageFile() {
                return this.ImageFile;
            }
            public void SetImageFile(string ImageFile) {
                this.ImageFile = ImageFile;
            }
            public string GetSize() {
                return this.Size;
            }
            public void SetSize(string Size) {
                this.Size = Size;
            }
            public string GetColour() {
                return this.Colour;
            }
            public void SetColour(string Colour) {
                this.Colour = Colour;
            }
            public string GetStatus() {
                return this.Status;
            }
            public void SetStatus(string Status) {
                this.Status = Status;
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