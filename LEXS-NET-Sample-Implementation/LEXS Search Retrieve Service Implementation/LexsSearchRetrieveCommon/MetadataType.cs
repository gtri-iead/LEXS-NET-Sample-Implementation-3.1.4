namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MessageMetadataAbstractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SRMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PDMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResponseMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PackageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchRequestMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredPayloadMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetadataType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetadataType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataOwnerMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/structures/2.0")]
    public abstract partial class MetadataType
    {
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}
