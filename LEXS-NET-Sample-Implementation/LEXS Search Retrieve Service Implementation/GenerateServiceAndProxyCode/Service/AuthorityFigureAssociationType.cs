namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class AuthorityFigureAssociationType : AssociationType
    {
        
        private ReferenceType[] personAuthorityFigureReferenceField;
        
        private ReferenceType[] personReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAuthorityFigureReference", Order=0)]
        public ReferenceType[] PersonAuthorityFigureReference
        {
            get
            {
                return this.personAuthorityFigureReferenceField;
            }
            set
            {
                this.personAuthorityFigureReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Order=1)]
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
    }
}
