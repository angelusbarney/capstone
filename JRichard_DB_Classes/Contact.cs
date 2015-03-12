using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public abstract class Contact {
        #region Values
            public DBConnection Database;
            private int ID;
            private string Address1;
            private string Address2;
            private string City;
            private string Region;
            private string Country;
            private string PostalCode;
            private DateTime CreationDate;
            private string Phone1;
            private string Phone2;
            private string Fax;
            private string Status;
            private string Notes;
        #endregion
        #region Getters and Setters
            public int GetId() {
                return this.ID;
            }
            public string GetAddress1() {
                return this.Address1;
            }
            public void SetAddress1(string Address1) {
                this.Address1 = Address1;
            }
            public string GetAddress2() {
                return this.Address2;
            }
            public void SetAddress2(string Address2) {
                this.Address2 = Address2;
            }
            public string GetCity() {
                return this.City;
            }
            public void SetCity(string City) {
                this.City = City;
            }
            public string GetRegion() {
                return this.Region;
            }
            public void SetRegion(string Region) {
                this.Region = Region;
            }
            public string GetCountry() {
                return this.Country;
            }
            public void SetCountry(string Country) {
                this.Country = Country;
            }
            public string GetPostalCode() {
                return this.PostalCode;
            }
            public void SetPostalCode(string PostalCode) {
                this.PostalCode = PostalCode;
            }
            public DateTime GetCreationDate() {
                return this.CreationDate;
            }
            public string GetPhone1() {
                return this.Phone1;
            }
            public void SetPhone1(string Phone1) {
                this.Phone1 = Phone1;
            }
            public string GetPhone2() {
                return this.Phone2;
            }
            public void SetPhone2(string Phone2) {
                this.Phone2 = Phone2;
            }
            public string GetFax() {
                return this.Fax;
            }
            public void SetFax(string Fax) {
                this.Fax = Fax;
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
            public Contact(int ID) {

                //Database.GetById(Database.GetSqlConnection(), System.Data.CommandType.StoredProcedure, "SP_GetById_Contact", null);
            }
        #endregion
    }
}