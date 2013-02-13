namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class SubjectVictimAssociationType : AssociationType
    {
        
        private ReferenceType[] subjectPersonReferenceField;
        
        private ReferenceType[] subjectOrganizationReferenceField;
        
        private ReferenceType[] victimPersonReferenceField;
        
        private ReferenceType[] victimOrganizationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectPersonReference", Order=0)]
        public ReferenceType[] SubjectPersonReference
        {
            get
            {
                return this.subjectPersonReferenceField;
            }
            set
            {
                this.subjectPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectOrganizationReference", Order=1)]
        public ReferenceType[] SubjectOrganizationReference
        {
            get
            {
                return this.subjectOrganizationReferenceField;
            }
            set
            {
                this.subjectOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimPersonReference", Order=2)]
        public ReferenceType[] VictimPersonReference
        {
            get
            {
                return this.victimPersonReferenceField;
            }
            set
            {
                this.victimPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimOrganizationReference", Order=3)]
        public ReferenceType[] VictimOrganizationReference
        {
            get
            {
                return this.victimOrganizationReferenceField;
            }
            set
            {
                this.victimOrganizationReferenceField = value;
            }
        }
    }
}
