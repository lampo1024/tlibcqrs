﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAccountDataObject", Namespace="http://schemas.datacontract.org/2004/07/TinyLibraryCQRS.Services.QueryServices.Qu" +
        "eryDataObjects")]
    [System.SerializableAttribute()]
    public partial class UserAccountDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressCountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressZipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long AggregateRootIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookTransferHistoryDataObject[] BorrowedBooksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressCity {
            get {
                return this.AddressCityField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressCityField, value) != true)) {
                    this.AddressCityField = value;
                    this.RaisePropertyChanged("AddressCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressCountry {
            get {
                return this.AddressCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressCountryField, value) != true)) {
                    this.AddressCountryField = value;
                    this.RaisePropertyChanged("AddressCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressState {
            get {
                return this.AddressStateField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressStateField, value) != true)) {
                    this.AddressStateField = value;
                    this.RaisePropertyChanged("AddressState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressStreet {
            get {
                return this.AddressStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressStreetField, value) != true)) {
                    this.AddressStreetField = value;
                    this.RaisePropertyChanged("AddressStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressZip {
            get {
                return this.AddressZipField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressZipField, value) != true)) {
                    this.AddressZipField = value;
                    this.RaisePropertyChanged("AddressZip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long AggregateRootId {
            get {
                return this.AggregateRootIdField;
            }
            set {
                if ((this.AggregateRootIdField.Equals(value) != true)) {
                    this.AggregateRootIdField = value;
                    this.RaisePropertyChanged("AggregateRootId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookTransferHistoryDataObject[] BorrowedBooks {
            get {
                return this.BorrowedBooksField;
            }
            set {
                if ((object.ReferenceEquals(this.BorrowedBooksField, value) != true)) {
                    this.BorrowedBooksField = value;
                    this.RaisePropertyChanged("BorrowedBooks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPhone {
            get {
                return this.ContactPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactPhoneField, value) != true)) {
                    this.ContactPhoneField = value;
                    this.RaisePropertyChanged("ContactPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName {
            get {
                return this.DisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayNameField, value) != true)) {
                    this.DisplayNameField = value;
                    this.RaisePropertyChanged("DisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookTransferHistoryDataObject", Namespace="http://schemas.datacontract.org/2004/07/TinyLibraryCQRS.Services.QueryServices.Qu" +
        "eryDataObjects")]
    [System.SerializableAttribute()]
    public partial class BookTransferHistoryDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long BookAggregateRootIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid BookIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BorrowedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReturnedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long BookAggregateRootId {
            get {
                return this.BookAggregateRootIdField;
            }
            set {
                if ((this.BookAggregateRootIdField.Equals(value) != true)) {
                    this.BookAggregateRootIdField = value;
                    this.RaisePropertyChanged("BookAggregateRootId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid BookID {
            get {
                return this.BookIDField;
            }
            set {
                if ((this.BookIDField.Equals(value) != true)) {
                    this.BookIDField = value;
                    this.RaisePropertyChanged("BookID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BorrowedDate {
            get {
                return this.BorrowedDateField;
            }
            set {
                if ((this.BorrowedDateField.Equals(value) != true)) {
                    this.BorrowedDateField = value;
                    this.RaisePropertyChanged("BorrowedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Returned {
            get {
                return this.ReturnedField;
            }
            set {
                if ((this.ReturnedField.Equals(value) != true)) {
                    this.ReturnedField = value;
                    this.RaisePropertyChanged("Returned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReturnedDate {
            get {
                return this.ReturnedDateField;
            }
            set {
                if ((this.ReturnedDateField.Equals(value) != true)) {
                    this.ReturnedDateField = value;
                    this.RaisePropertyChanged("ReturnedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountType", Namespace="http://schemas.datacontract.org/2004/07/TinyLibraryCQRS.Services.QueryServices.Qu" +
        "eryDataObjects")]
    public enum AccountType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Admin = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        User = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookDataObject", Namespace="http://schemas.datacontract.org/2004/07/TinyLibraryCQRS.Services.QueryServices.Qu" +
        "eryDataObjects")]
    [System.SerializableAttribute()]
    public partial class BookDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long AggregateRootIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InventoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long AggregateRootId {
            get {
                return this.AggregateRootIdField;
            }
            set {
                if ((this.AggregateRootIdField.Equals(value) != true)) {
                    this.AggregateRootIdField = value;
                    this.RaisePropertyChanged("AggregateRootId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Inventory {
            get {
                return this.InventoryField;
            }
            set {
                if ((this.InventoryField.Equals(value) != true)) {
                    this.InventoryField = value;
                    this.RaisePropertyChanged("Inventory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pages {
            get {
                return this.PagesField;
            }
            set {
                if ((this.PagesField.Equals(value) != true)) {
                    this.PagesField = value;
                    this.RaisePropertyChanged("Pages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QueryServices.IQueryService")]
    public interface IQueryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetUserByUserName", ReplyAction="http://tempuri.org/IQueryService/GetUserByUserNameResponse")]
        TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByUserName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetUserByEmail", ReplyAction="http://tempuri.org/IQueryService/GetUserByEmailResponse")]
        TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/ValidateUser", ReplyAction="http://tempuri.org/IQueryService/ValidateUserResponse")]
        bool ValidateUser(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetAccountType", ReplyAction="http://tempuri.org/IQueryService/GetAccountTypeResponse")]
        System.Nullable<TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.AccountType> GetAccountType(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetBooks", ReplyAction="http://tempuri.org/IQueryService/GetBooksResponse")]
        TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookDataObject[] GetBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetBookByGuid", ReplyAction="http://tempuri.org/IQueryService/GetBookByGuidResponse")]
        TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookDataObject GetBookByGuid(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQueryService/GetUserByGuid", ReplyAction="http://tempuri.org/IQueryService/GetUserByGuidResponse")]
        TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByGuid(System.Guid guid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQueryServiceChannel : TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.IQueryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QueryServiceClient : System.ServiceModel.ClientBase<TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.IQueryService>, TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.IQueryService {
        
        public QueryServiceClient() {
        }
        
        public QueryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QueryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QueryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByUserName(string userName) {
            return base.Channel.GetUserByUserName(userName);
        }
        
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByEmail(string email) {
            return base.Channel.GetUserByEmail(email);
        }
        
        public bool ValidateUser(string userName, string password) {
            return base.Channel.ValidateUser(userName, password);
        }
        
        public System.Nullable<TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.AccountType> GetAccountType(string userName) {
            return base.Channel.GetAccountType(userName);
        }
        
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookDataObject[] GetBooks() {
            return base.Channel.GetBooks();
        }
        
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.BookDataObject GetBookByGuid(System.Guid guid) {
            return base.Channel.GetBookByGuid(guid);
        }
        
        public TinyLibraryCQRS.Presentations.Mvc3.Common.QueryServices.UserAccountDataObject GetUserByGuid(System.Guid guid) {
            return base.Channel.GetUserByGuid(guid);
        }
    }
}
