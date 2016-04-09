﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="HotelsPortSoap11", Namespace="http://hotels.sources.com")]
public partial class HotelsPortService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback getHotelDetailsOperationCompleted;
    
    private System.Threading.SendOrPostCallback getHotelOperationCompleted;
    
    private System.Threading.SendOrPostCallback getHotelsOperationCompleted;
    
    /// <remarks/>
    public HotelsPortService() {
        this.Url = "http://localhost:8080/ws/hotels";
    }
    
    /// <remarks/>
    public event getHotelDetailsCompletedEventHandler getHotelDetailsCompleted;
    
    /// <remarks/>
    public event getHotelCompletedEventHandler getHotelCompleted;
    
    /// <remarks/>
    public event getHotelsCompletedEventHandler getHotelsCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("getHotelDetailsResponse", Namespace="http://hotels.sources.com")]
    public getHotelDetailsResponse getHotelDetails([System.Xml.Serialization.XmlElementAttribute(Namespace="http://hotels.sources.com")] getHotelDetailsRequest getHotelDetailsRequest) {
        object[] results = this.Invoke("getHotelDetails", new object[] {
                    getHotelDetailsRequest});
        return ((getHotelDetailsResponse)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetHotelDetails(getHotelDetailsRequest getHotelDetailsRequest, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getHotelDetails", new object[] {
                    getHotelDetailsRequest}, callback, asyncState);
    }
    
    /// <remarks/>
    public getHotelDetailsResponse EndgetHotelDetails(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((getHotelDetailsResponse)(results[0]));
    }
    
    /// <remarks/>
    public void getHotelDetailsAsync(getHotelDetailsRequest getHotelDetailsRequest) {
        this.getHotelDetailsAsync(getHotelDetailsRequest, null);
    }
    
    /// <remarks/>
    public void getHotelDetailsAsync(getHotelDetailsRequest getHotelDetailsRequest, object userState) {
        if ((this.getHotelDetailsOperationCompleted == null)) {
            this.getHotelDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHotelDetailsOperationCompleted);
        }
        this.InvokeAsync("getHotelDetails", new object[] {
                    getHotelDetailsRequest}, this.getHotelDetailsOperationCompleted, userState);
    }
    
    private void OngetHotelDetailsOperationCompleted(object arg) {
        if ((this.getHotelDetailsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getHotelDetailsCompleted(this, new getHotelDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("getHotelResponse", Namespace="http://hotels.sources.com")]
    public getHotelResponse getHotel([System.Xml.Serialization.XmlElementAttribute(Namespace="http://hotels.sources.com")] getHotelRequest getHotelRequest) {
        object[] results = this.Invoke("getHotel", new object[] {
                    getHotelRequest});
        return ((getHotelResponse)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetHotel(getHotelRequest getHotelRequest, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getHotel", new object[] {
                    getHotelRequest}, callback, asyncState);
    }
    
    /// <remarks/>
    public getHotelResponse EndgetHotel(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((getHotelResponse)(results[0]));
    }
    
    /// <remarks/>
    public void getHotelAsync(getHotelRequest getHotelRequest) {
        this.getHotelAsync(getHotelRequest, null);
    }
    
    /// <remarks/>
    public void getHotelAsync(getHotelRequest getHotelRequest, object userState) {
        if ((this.getHotelOperationCompleted == null)) {
            this.getHotelOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHotelOperationCompleted);
        }
        this.InvokeAsync("getHotel", new object[] {
                    getHotelRequest}, this.getHotelOperationCompleted, userState);
    }
    
    private void OngetHotelOperationCompleted(object arg) {
        if ((this.getHotelCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getHotelCompleted(this, new getHotelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("getHotelsResponse", Namespace="http://hotels.sources.com")]
    public getHotelsResponse getHotels([System.Xml.Serialization.XmlElementAttribute(Namespace="http://hotels.sources.com")] getHotelsRequest getHotelsRequest) {
        object[] results = this.Invoke("getHotels", new object[] {
                    getHotelsRequest});
        return ((getHotelsResponse)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetHotels(getHotelsRequest getHotelsRequest, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getHotels", new object[] {
                    getHotelsRequest}, callback, asyncState);
    }
    
    /// <remarks/>
    public getHotelsResponse EndgetHotels(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((getHotelsResponse)(results[0]));
    }
    
    /// <remarks/>
    public void getHotelsAsync(getHotelsRequest getHotelsRequest) {
        this.getHotelsAsync(getHotelsRequest, null);
    }
    
    /// <remarks/>
    public void getHotelsAsync(getHotelsRequest getHotelsRequest, object userState) {
        if ((this.getHotelsOperationCompleted == null)) {
            this.getHotelsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHotelsOperationCompleted);
        }
        this.InvokeAsync("getHotels", new object[] {
                    getHotelsRequest}, this.getHotelsOperationCompleted, userState);
    }
    
    private void OngetHotelsOperationCompleted(object arg) {
        if ((this.getHotelsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getHotelsCompleted(this, new getHotelsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelDetailsRequest {
    
    private uint idField;
    
    /// <remarks/>
    public uint id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hotels.sources.com")]
public partial class hotel1 {
    
    private string nameField;
    
    private uint idField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hotels.sources.com")]
public partial class price_list {
    
    private uint single_roomField;
    
    private uint double_roomField;
    
    private uint triple_roomField;
    
    /// <remarks/>
    public uint single_room {
        get {
            return this.single_roomField;
        }
        set {
            this.single_roomField = value;
        }
    }
    
    /// <remarks/>
    public uint double_room {
        get {
            return this.double_roomField;
        }
        set {
            this.double_roomField = value;
        }
    }
    
    /// <remarks/>
    public uint triple_room {
        get {
            return this.triple_roomField;
        }
        set {
            this.triple_roomField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hotels.sources.com")]
public partial class contacts {
    
    private string addressField;
    
    private string phone_numberField;
    
    /// <remarks/>
    public string address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string phone_number {
        get {
            return this.phone_numberField;
        }
        set {
            this.phone_numberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hotels.sources.com")]
public partial class hotel {
    
    private string nameField;
    
    private int starsField;
    
    private string descriptionField;
    
    private uint room_countField;
    
    private contacts contactsField;
    
    private price_list price_listField;
    
    private string[] facilitiesField;
    
    private uint idField;
    
    private uint city_idField;
    
    private string city_nameField;
    
    private category categoryField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public int stars {
        get {
            return this.starsField;
        }
        set {
            this.starsField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public uint room_count {
        get {
            return this.room_countField;
        }
        set {
            this.room_countField = value;
        }
    }
    
    /// <remarks/>
    public contacts contacts {
        get {
            return this.contactsField;
        }
        set {
            this.contactsField = value;
        }
    }
    
    /// <remarks/>
    public price_list price_list {
        get {
            return this.price_listField;
        }
        set {
            this.price_listField = value;
        }
    }
    
    /// <remarks/>
    public string[] facilities {
        get {
            return this.facilitiesField;
        }
        set {
            this.facilitiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint city_id {
        get {
            return this.city_idField;
        }
        set {
            this.city_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string city_name {
        get {
            return this.city_nameField;
        }
        set {
            this.city_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public category category {
        get {
            return this.categoryField;
        }
        set {
            this.categoryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://hotels.sources.com")]
public enum category {
    
    /// <remarks/>
    business,
    
    /// <remarks/>
    family,
    
    /// <remarks/>
    spa,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelDetailsResponse {
    
    private hotel hotelField;
    
    /// <remarks/>
    public hotel hotel {
        get {
            return this.hotelField;
        }
        set {
            this.hotelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelRequest {
    
    private uint idField;
    
    /// <remarks/>
    public uint id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelResponse {
    
    private hotel1 hotelField;
    
    /// <remarks/>
    public hotel1 hotel {
        get {
            return this.hotelField;
        }
        set {
            this.hotelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelsRequest {
    
    private string termField;
    
    private uint city_idField;
    
    private bool city_idFieldSpecified;
    
    /// <remarks/>
    public string term {
        get {
            return this.termField;
        }
        set {
            this.termField = value;
        }
    }
    
    /// <remarks/>
    public uint city_id {
        get {
            return this.city_idField;
        }
        set {
            this.city_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool city_idSpecified {
        get {
            return this.city_idFieldSpecified;
        }
        set {
            this.city_idFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://hotels.sources.com")]
public partial class getHotelsResponse {
    
    private hotel1[] hotelsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("hotel", IsNullable=false)]
    public hotel1[] hotels {
        get {
            return this.hotelsField;
        }
        set {
            this.hotelsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getHotelDetailsCompletedEventHandler(object sender, getHotelDetailsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getHotelDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getHotelDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public getHotelDetailsResponse Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((getHotelDetailsResponse)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getHotelCompletedEventHandler(object sender, getHotelCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getHotelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getHotelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public getHotelResponse Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((getHotelResponse)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getHotelsCompletedEventHandler(object sender, getHotelsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getHotelsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal getHotelsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public getHotelsResponse Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((getHotelsResponse)(this.results[0]));
        }
    }
}