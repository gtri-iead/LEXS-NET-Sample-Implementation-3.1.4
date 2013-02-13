namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/library/3.1")]
    public partial class SameAsPayloadAssociationType : ComplexObjectType
    {
        
        private ReferenceType objectReferenceField;
        
        private ReferenceType1 payloadObjectReferenceField;
        
        private ReferenceType payloadReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType ObjectReference
        {
            get
            {
                return this.objectReferenceField;
            }
            set
            {
                this.objectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType1 PayloadObjectReference
        {
            get
            {
                return this.payloadObjectReferenceField;
            }
            set
            {
                this.payloadObjectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType PayloadReference
        {
            get
            {
                return this.payloadReferenceField;
            }
            set
            {
                this.payloadReferenceField = value;
            }
        }
    }
}
