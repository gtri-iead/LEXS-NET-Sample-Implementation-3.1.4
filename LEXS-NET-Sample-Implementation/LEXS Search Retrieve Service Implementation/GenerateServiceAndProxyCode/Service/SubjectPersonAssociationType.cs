namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class SubjectPersonAssociationType : AssociationType
    {
        
        private ReferenceType[] personReferenceField;
        
        private ReferenceType[] subjectReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType[] PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectReference", Order=1)]
        public ReferenceType[] SubjectReference
        {
            get
            {
                return this.subjectReferenceField;
            }
            set
            {
                this.subjectReferenceField = value;
            }
        }
    }
}
