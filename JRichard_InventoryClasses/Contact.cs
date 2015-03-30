using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace JRichard_InventoryClasses {
    public abstract class Contact {
        #region values
            protected int ID;
            private string Address1;
            private string Address2;
            private string City;
            private string Region;
            private string Country;
            private string PostalCode;
            protected DateTime CreationDate;
            private string Phone1;
            private string Phone2;
            private string Fax;
            private string Status;
            private string Notes;
        #endregion
        #region getters and setters
            public int GetID() {
                return ID;
            }
            public string GetAddress1() {
                return Address1;
            }
            public void SetAddress1(string Address1) {
                this.Address1 = Address1;
            }
            public string GetAddress2() {
                return Address2;
            }
            public void SetAddress2(string Address2) {
                this.Address2 = Address2;
            }
            public string GetCity() {
                return City;
            }
            public void SetCity(string City) {
                this.City = City;
            }
            public string GetRegion() {
                return Region;
            }
            public void SetRegion(string Region) {
                this.Region = Region;
            }
            public string GetCountry() {
                return Country;
            }
            public void SetCountry(string Country) {
                this.Country = Country;
            }
            public string GetPostalCode() {
                return PostalCode;
            }
            public void SetPostalCode(string PostalCode) {
                this.PostalCode = PostalCode;
            }
            public DateTime GetCreationDate() {
                return CreationDate;
            }
            public string GetPhone1() {
                return Phone1;
            }
            public void SetPhone1(string Phone1) {
                this.Phone1 = Phone1;
            }
            public string GetPhone2() {
                return Phone2;
            }
            public void SetPhone2(string Phone2) {
                this.Phone2 = Phone2;
            }
            public string GetFax() {
                return Fax;
            }
            public void SetFax(string Fax) {
                this.Fax = Fax;
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
        #endregion
    }
}