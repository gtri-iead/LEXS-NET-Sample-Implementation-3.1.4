namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DataOwnerMetadataType : MetadataType
    {
        
        private DataOwnerIdentifierType dataOwnerIdentifierField;
        
        private DataContactType dataOwnerContactField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataOwnerIdentifierType DataOwnerIdentifier
        {
            get
            {
                return this.dataOwnerIdentifierField;
            }
            set
            {
                this.dataOwnerIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DataContactType DataOwnerContact
        {
            get
            {
                return this.dataOwnerContactField;
            }
            set
            {
                this.dataOwnerContactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=2)]
        public DomainAttributeType[] DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }
    }
}
