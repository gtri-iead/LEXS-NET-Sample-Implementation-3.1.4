namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class GuardianAssociationType : AssociationType
    {
        
        private ReferenceType[] personGuardianReferenceField;
        
        private ReferenceType[] personDependentReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonGuardianReference", Order=0)]
        public ReferenceType[] PersonGuardianReference
        {
            get
            {
                return this.personGuardianReferenceField;
            }
            set
            {
                this.personGuardianReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonDependentReference", Order=1)]
        public ReferenceType[] PersonDependentReference
        {
            get
            {
                return this.personDependentReferenceField;
            }
            set
            {
                this.personDependentReferenceField = value;
            }
        }
    }
}
