namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class DeclarationPersonAssociationType : AssociationType
    {
        
        private ReferenceType declarationPersonReferenceField;
        
        private ReferenceType missingPersonReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType DeclarationPersonReference
        {
            get
            {
                return this.declarationPersonReferenceField;
            }
            set
            {
                this.declarationPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType MissingPersonReference
        {
            get
            {
                return this.missingPersonReferenceField;
            }
            set
            {
                this.missingPersonReferenceField = value;
            }
        }
    }
}
