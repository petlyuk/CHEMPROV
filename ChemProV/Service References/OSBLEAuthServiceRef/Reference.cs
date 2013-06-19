﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace ChemProV.OSBLEAuthServiceRef {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProfile", Namespace="http://schemas.datacontract.org/2004/07/OSBLE.Models.Users")]
    public partial class UserProfile : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string AuthenticationHashField;
        
        private bool CanCreateCoursesField;
        
        private int DefaultCourseField;
        
        private bool EmailAllActivityPostsField;
        
        private bool EmailAllNotificationsField;
        
        private string FirstNameField;
        
        private int IDField;
        
        private string IdentificationField;
        
        private bool IsAdminField;
        
        private bool IsApprovedField;
        
        private string LastNameField;
        
        private ChemProV.OSBLEAuthServiceRef.School SchoolField;
        
        private int SchoolIDField;
        
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthenticationHash {
            get {
                return this.AuthenticationHashField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthenticationHashField, value) != true)) {
                    this.AuthenticationHashField = value;
                    this.RaisePropertyChanged("AuthenticationHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool CanCreateCourses {
            get {
                return this.CanCreateCoursesField;
            }
            set {
                if ((this.CanCreateCoursesField.Equals(value) != true)) {
                    this.CanCreateCoursesField = value;
                    this.RaisePropertyChanged("CanCreateCourses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DefaultCourse {
            get {
                return this.DefaultCourseField;
            }
            set {
                if ((this.DefaultCourseField.Equals(value) != true)) {
                    this.DefaultCourseField = value;
                    this.RaisePropertyChanged("DefaultCourse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EmailAllActivityPosts {
            get {
                return this.EmailAllActivityPostsField;
            }
            set {
                if ((this.EmailAllActivityPostsField.Equals(value) != true)) {
                    this.EmailAllActivityPostsField = value;
                    this.RaisePropertyChanged("EmailAllActivityPosts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EmailAllNotifications {
            get {
                return this.EmailAllNotificationsField;
            }
            set {
                if ((this.EmailAllNotificationsField.Equals(value) != true)) {
                    this.EmailAllNotificationsField = value;
                    this.RaisePropertyChanged("EmailAllNotifications");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
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
        public string Identification {
            get {
                return this.IdentificationField;
            }
            set {
                if ((object.ReferenceEquals(this.IdentificationField, value) != true)) {
                    this.IdentificationField = value;
                    this.RaisePropertyChanged("Identification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsApproved {
            get {
                return this.IsApprovedField;
            }
            set {
                if ((this.IsApprovedField.Equals(value) != true)) {
                    this.IsApprovedField = value;
                    this.RaisePropertyChanged("IsApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ChemProV.OSBLEAuthServiceRef.School School {
            get {
                return this.SchoolField;
            }
            set {
                if ((object.ReferenceEquals(this.SchoolField, value) != true)) {
                    this.SchoolField = value;
                    this.RaisePropertyChanged("School");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SchoolID {
            get {
                return this.SchoolIDField;
            }
            set {
                if ((this.SchoolIDField.Equals(value) != true)) {
                    this.SchoolIDField = value;
                    this.RaisePropertyChanged("SchoolID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="School", Namespace="http://schemas.datacontract.org/2004/07/OSBLE.Models")]
    public partial class School : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IDk__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ID>k__BackingField", IsRequired=true)]
        public int IDk__BackingField {
            get {
                return this.IDk__BackingFieldField;
            }
            set {
                if ((this.IDk__BackingFieldField.Equals(value) != true)) {
                    this.IDk__BackingFieldField = value;
                    this.RaisePropertyChanged("IDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField {
            get {
                return this.Namek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Namek__BackingFieldField, value) != true)) {
                    this.Namek__BackingFieldField = value;
                    this.RaisePropertyChanged("Namek__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="OSBLEAuthServiceRef.AuthenticationService")]
    public interface AuthenticationService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:AuthenticationService/GetActiveUser", ReplyAction="urn:AuthenticationService/GetActiveUserResponse")]
        System.IAsyncResult BeginGetActiveUser(string authToken, System.AsyncCallback callback, object asyncState);
        
        ChemProV.OSBLEAuthServiceRef.UserProfile EndGetActiveUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:AuthenticationService/ValidateUser", ReplyAction="urn:AuthenticationService/ValidateUserResponse")]
        System.IAsyncResult BeginValidateUser(string userName, string password, System.AsyncCallback callback, object asyncState);
        
        string EndValidateUser(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticationServiceChannel : ChemProV.OSBLEAuthServiceRef.AuthenticationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetActiveUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetActiveUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public ChemProV.OSBLEAuthServiceRef.UserProfile Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((ChemProV.OSBLEAuthServiceRef.UserProfile)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ValidateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<ChemProV.OSBLEAuthServiceRef.AuthenticationService>, ChemProV.OSBLEAuthServiceRef.AuthenticationService {
        
        private BeginOperationDelegate onBeginGetActiveUserDelegate;
        
        private EndOperationDelegate onEndGetActiveUserDelegate;
        
        private System.Threading.SendOrPostCallback onGetActiveUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginValidateUserDelegate;
        
        private EndOperationDelegate onEndValidateUserDelegate;
        
        private System.Threading.SendOrPostCallback onValidateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public AuthenticationServiceClient() {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetActiveUserCompletedEventArgs> GetActiveUserCompleted;
        
        public event System.EventHandler<ValidateUserCompletedEventArgs> ValidateUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ChemProV.OSBLEAuthServiceRef.AuthenticationService.BeginGetActiveUser(string authToken, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetActiveUser(authToken, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ChemProV.OSBLEAuthServiceRef.UserProfile ChemProV.OSBLEAuthServiceRef.AuthenticationService.EndGetActiveUser(System.IAsyncResult result) {
            return base.Channel.EndGetActiveUser(result);
        }
        
        private System.IAsyncResult OnBeginGetActiveUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string authToken = ((string)(inValues[0]));
            return ((ChemProV.OSBLEAuthServiceRef.AuthenticationService)(this)).BeginGetActiveUser(authToken, callback, asyncState);
        }
        
        private object[] OnEndGetActiveUser(System.IAsyncResult result) {
            ChemProV.OSBLEAuthServiceRef.UserProfile retVal = ((ChemProV.OSBLEAuthServiceRef.AuthenticationService)(this)).EndGetActiveUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetActiveUserCompleted(object state) {
            if ((this.GetActiveUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetActiveUserCompleted(this, new GetActiveUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetActiveUserAsync(string authToken) {
            this.GetActiveUserAsync(authToken, null);
        }
        
        public void GetActiveUserAsync(string authToken, object userState) {
            if ((this.onBeginGetActiveUserDelegate == null)) {
                this.onBeginGetActiveUserDelegate = new BeginOperationDelegate(this.OnBeginGetActiveUser);
            }
            if ((this.onEndGetActiveUserDelegate == null)) {
                this.onEndGetActiveUserDelegate = new EndOperationDelegate(this.OnEndGetActiveUser);
            }
            if ((this.onGetActiveUserCompletedDelegate == null)) {
                this.onGetActiveUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetActiveUserCompleted);
            }
            base.InvokeAsync(this.onBeginGetActiveUserDelegate, new object[] {
                        authToken}, this.onEndGetActiveUserDelegate, this.onGetActiveUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ChemProV.OSBLEAuthServiceRef.AuthenticationService.BeginValidateUser(string userName, string password, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginValidateUser(userName, password, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string ChemProV.OSBLEAuthServiceRef.AuthenticationService.EndValidateUser(System.IAsyncResult result) {
            return base.Channel.EndValidateUser(result);
        }
        
        private System.IAsyncResult OnBeginValidateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string userName = ((string)(inValues[0]));
            string password = ((string)(inValues[1]));
            return ((ChemProV.OSBLEAuthServiceRef.AuthenticationService)(this)).BeginValidateUser(userName, password, callback, asyncState);
        }
        
        private object[] OnEndValidateUser(System.IAsyncResult result) {
            string retVal = ((ChemProV.OSBLEAuthServiceRef.AuthenticationService)(this)).EndValidateUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnValidateUserCompleted(object state) {
            if ((this.ValidateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ValidateUserCompleted(this, new ValidateUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ValidateUserAsync(string userName, string password) {
            this.ValidateUserAsync(userName, password, null);
        }
        
        public void ValidateUserAsync(string userName, string password, object userState) {
            if ((this.onBeginValidateUserDelegate == null)) {
                this.onBeginValidateUserDelegate = new BeginOperationDelegate(this.OnBeginValidateUser);
            }
            if ((this.onEndValidateUserDelegate == null)) {
                this.onEndValidateUserDelegate = new EndOperationDelegate(this.OnEndValidateUser);
            }
            if ((this.onValidateUserCompletedDelegate == null)) {
                this.onValidateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnValidateUserCompleted);
            }
            base.InvokeAsync(this.onBeginValidateUserDelegate, new object[] {
                        userName,
                        password}, this.onEndValidateUserDelegate, this.onValidateUserCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override ChemProV.OSBLEAuthServiceRef.AuthenticationService CreateChannel() {
            return new AuthenticationServiceClientChannel(this);
        }
        
        private class AuthenticationServiceClientChannel : ChannelBase<ChemProV.OSBLEAuthServiceRef.AuthenticationService>, ChemProV.OSBLEAuthServiceRef.AuthenticationService {
            
            public AuthenticationServiceClientChannel(System.ServiceModel.ClientBase<ChemProV.OSBLEAuthServiceRef.AuthenticationService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetActiveUser(string authToken, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = authToken;
                System.IAsyncResult _result = base.BeginInvoke("GetActiveUser", _args, callback, asyncState);
                return _result;
            }
            
            public ChemProV.OSBLEAuthServiceRef.UserProfile EndGetActiveUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                ChemProV.OSBLEAuthServiceRef.UserProfile _result = ((ChemProV.OSBLEAuthServiceRef.UserProfile)(base.EndInvoke("GetActiveUser", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginValidateUser(string userName, string password, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = userName;
                _args[1] = password;
                System.IAsyncResult _result = base.BeginInvoke("ValidateUser", _args, callback, asyncState);
                return _result;
            }
            
            public string EndValidateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("ValidateUser", _args, result)));
                return _result;
            }
        }
    }
}
