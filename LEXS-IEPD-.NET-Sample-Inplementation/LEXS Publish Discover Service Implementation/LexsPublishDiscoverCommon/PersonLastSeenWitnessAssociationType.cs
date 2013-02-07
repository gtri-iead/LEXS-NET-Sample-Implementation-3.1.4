namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PersonLastSeenWitnessAssociationType : AssociationType
    {
        
        private ReferenceType missingPersonReferenceField;
        
        private ReferenceType witnessPersonReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType WitnessPersonReference
        {
            get
            {
                return this.witnessPersonReferenceField;
            }
            set
            {
                this.witnessPersonReferenceField = value;
            }
        }
    }
}
