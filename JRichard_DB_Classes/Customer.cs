using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRichard_DB_Tables;
namespace Functionality {
    public class Customer : Contact {
        #region Values
            public DBConnection Database;
            private string Title;
            private string FirstName;
            private string LastName;
            private string Salutation;
            private string Extension;
            private string Branch;
            private string Signature;
        #endregion
        #region Getters and Setters
            public string GetTitle() {
                return this.Title;
            }
            public void SetTitle(string Title) {
                this.Title = Title;
            }
            public string GetFirstName() {
                return this.FirstName;
            }
            public void SetFirstName(string FirstName) {
                this.FirstName = FirstName;
            }
            public string GetLastName() {
                return this.LastName;
            }
            public void SetLastName(string LastName) {
                this.LastName = LastName;
            }
            public string GetSalutation() {
                return this.Salutation;
            }
            public void SetSalutation(string Salutation) {
                this.Salutation = Salutation;
            }
            public string GetExtension() {
                return this.Extension;
            }
            public void SetExtension(string Extension) {
                this.Extension = Extension;
            }
            public string GetBranch() {
                return this.Branch;
            }
            public void SetBranch(string Branch) {
                this.Branch = Branch;
            }
            public string GetSignature() {
                return this.Signature;
            }
            public void SetSignature(string Signature) {
                this.Signature = Signature;
            }
        #endregion
        #region methods
        #endregion
    }
}