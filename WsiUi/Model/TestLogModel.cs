﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4206
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/", IsNullable=true)]
public partial class testLog {
    
    private logMetadata logMetadataField;
    
    private message[] messageLogField;
    
    private descriptionFiles descriptionFilesField;
    
    /// <remarks/>
    public logMetadata logMetadata {
        get {
            return this.logMetadataField;
        }
        set {
            this.logMetadataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public message[] messageLog {
        get {
            return this.messageLogField;
        }
        set {
            this.messageLogField = value;
        }
    }
    
    /// <remarks/>
    public descriptionFiles descriptionFiles {
        get {
            return this.descriptionFilesField;
        }
        set {
            this.descriptionFilesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class logMetadata {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class Feature {
    
    private FeatureAlternative[] alternativeField;
    
    private System.Xml.XmlElement[] anyField;
    
    private FeatureModeType modeField;
    
    private string nameField;
    
    private string portTypeQNameField;
    
    private string bindingQNameField;
    
    private string serviceQNameField;
    
    private string portNameField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alternative")]
    public FeatureAlternative[] alternative {
        get {
            return this.alternativeField;
        }
        set {
            this.alternativeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public FeatureModeType mode {
        get {
            return this.modeField;
        }
        set {
            this.modeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
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
    public string portTypeQName {
        get {
            return this.portTypeQNameField;
        }
        set {
            this.portTypeQNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string bindingQName {
        get {
            return this.bindingQNameField;
        }
        set {
            this.bindingQNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string serviceQName {
        get {
            return this.serviceQNameField;
        }
        set {
            this.serviceQNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string portName {
        get {
            return this.portNameField;
        }
        set {
            this.portNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class FeatureAlternative {
    
    private Feature featureField;
    
    private System.Xml.XmlElement[] anyField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    public Feature feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public enum FeatureModeType {
    
    /// <remarks/>
    noassertion,
    
    /// <remarks/>
    undetermined,
    
    /// <remarks/>
    supported,
    
    /// <remarks/>
    required,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class descriptionFile {
    
    private System.Xml.XmlElement anyField;
    
    private bool validXmlField;
    
    private bool validXmlFieldSpecified;
    
    private string xmlVersionField;
    
    private string encodingField;
    
    private string filenameField;
    
    private bool schemaValidField;
    
    private bool schemaValidFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool validXml {
        get {
            return this.validXmlField;
        }
        set {
            this.validXmlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool validXmlSpecified {
        get {
            return this.validXmlFieldSpecified;
        }
        set {
            this.validXmlFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string xmlVersion {
        get {
            return this.xmlVersionField;
        }
        set {
            this.xmlVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string encoding {
        get {
            return this.encodingField;
        }
        set {
            this.encodingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string filename {
        get {
            return this.filenameField;
        }
        set {
            this.filenameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool schemaValid {
        get {
            return this.schemaValidField;
        }
        set {
            this.schemaValidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool schemaValidSpecified {
        get {
            return this.schemaValidFieldSpecified;
        }
        set {
            this.schemaValidFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class descriptionFiles {
    
    private descriptionFile[] descriptionFileField;
    
    private Feature[] featureField;
    
    private System.Xml.XmlElement[] anyField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("descriptionFile")]
    public descriptionFile[] descriptionFile {
        get {
            return this.descriptionFileField;
        }
        set {
            this.descriptionFileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("feature")]
    public Feature[] feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class mimePart {
    
    private string[] boundaryStringField;
    
    private object[] mimeHeadersField;
    
    private byte[] mimeContentField;
    
    private messageContents mimeSoapContentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundaryString")]
    public string[] boundaryString {
        get {
            return this.boundaryStringField;
        }
        set {
            this.boundaryStringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(contentTypeHeader), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("mimeHeader", typeof(httpHeader), IsNullable=false)]
    public object[] mimeHeaders {
        get {
            return this.mimeHeadersField;
        }
        set {
            this.mimeHeadersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] mimeContent {
        get {
            return this.mimeContentField;
        }
        set {
            this.mimeContentField = value;
        }
    }
    
    /// <remarks/>
    public messageContents mimeSoapContent {
        get {
            return this.mimeSoapContentField;
        }
        set {
            this.mimeSoapContentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class contentTypeHeader {
    
    private parameter[] parameterField;
    
    private string typeField;
    
    private string subtypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public parameter[] parameter {
        get {
            return this.parameterField;
        }
        set {
            this.parameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string subtype {
        get {
            return this.subtypeField;
        }
        set {
            this.subtypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class parameter {
    
    private string keyField;
    
    private string valueField;
    
    private bool quotedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool quoted {
        get {
            return this.quotedField;
        }
        set {
            this.quotedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class httpHeader {
    
    private parameter[] parameterField;
    
    private string keyField;
    
    private string valueField;
    
    private bool quotedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parameter")]
    public parameter[] parameter {
        get {
            return this.parameterField;
        }
        set {
            this.parameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool quoted {
        get {
            return this.quotedField;
        }
        set {
            this.quotedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class messageContents {
    
    private System.Xml.XmlElement anyField;
    
    private bool validXmlField;
    
    private bool validXmlFieldSpecified;
    
    private string xmlVersionField;
    
    private string encodingField;
    
    private bool containsProcessingInstructionsField;
    
    private bool containsProcessingInstructionsFieldSpecified;
    
    private bool containsDTDField;
    
    private bool containsDTDFieldSpecified;
    
    private bool containsXmlDeclField;
    
    private bool containsXmlDeclFieldSpecified;
    
    private bool schemaValidField;
    
    private bool schemaValidFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool validXml {
        get {
            return this.validXmlField;
        }
        set {
            this.validXmlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool validXmlSpecified {
        get {
            return this.validXmlFieldSpecified;
        }
        set {
            this.validXmlFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string xmlVersion {
        get {
            return this.xmlVersionField;
        }
        set {
            this.xmlVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string encoding {
        get {
            return this.encodingField;
        }
        set {
            this.encodingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool containsProcessingInstructions {
        get {
            return this.containsProcessingInstructionsField;
        }
        set {
            this.containsProcessingInstructionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool containsProcessingInstructionsSpecified {
        get {
            return this.containsProcessingInstructionsFieldSpecified;
        }
        set {
            this.containsProcessingInstructionsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool containsDTD {
        get {
            return this.containsDTDField;
        }
        set {
            this.containsDTDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool containsDTDSpecified {
        get {
            return this.containsDTDFieldSpecified;
        }
        set {
            this.containsDTDFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool containsXmlDecl {
        get {
            return this.containsXmlDeclField;
        }
        set {
            this.containsXmlDeclField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool containsXmlDeclSpecified {
        get {
            return this.containsXmlDeclFieldSpecified;
        }
        set {
            this.containsXmlDeclFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool schemaValid {
        get {
            return this.schemaValidField;
        }
        set {
            this.schemaValidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool schemaValidSpecified {
        get {
            return this.schemaValidFieldSpecified;
        }
        set {
            this.schemaValidFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public partial class message {
    
    private object[] httpHeadersField;
    
    private messageContents messageContentsField;
    
    private mimePart[] messageAttachmentsField;
    
    private messageType typeField;
    
    private string idField;
    
    private string conversationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(contentTypeHeader), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute(typeof(httpHeader), IsNullable=false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("requestLine", typeof(string), IsNullable=false)]
    public object[] httpHeaders {
        get {
            return this.httpHeadersField;
        }
        set {
            this.httpHeadersField = value;
        }
    }
    
    /// <remarks/>
    public messageContents messageContents {
        get {
            return this.messageContentsField;
        }
        set {
            this.messageContentsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messageAttachments")]
    public mimePart[] messageAttachments {
        get {
            return this.messageAttachmentsField;
        }
        set {
            this.messageAttachmentsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public messageType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string conversation {
        get {
            return this.conversationField;
        }
        set {
            this.conversationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ws-i.org/testing/2008/02/log/")]
public enum messageType {
    
    /// <remarks/>
    request,
    
    /// <remarks/>
    response,
}
