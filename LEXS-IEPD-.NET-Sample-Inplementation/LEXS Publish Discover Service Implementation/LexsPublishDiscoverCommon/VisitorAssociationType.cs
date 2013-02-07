namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class VisitorAssociationType : AssociationType
    {
        
        private ReferenceType[] visitorPersonReferenceField;
        
        private ReferenceType[] visitorOrganizationReferenceField;
        
        private TextType visitDescriptionTextField;
        
        private ReferenceType[] visitedPersonReferenceField;
        
        private ReferenceType[] visitedOrganizationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitorPersonReference", Order=0)]
        public ReferenceType[] VisitorPersonReference
        {
            get
            {
                return this.visitorPersonReferenceField;
            }
            set
            {
                this.visitorPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitorOrganizationReference", Order=1)]
        public ReferenceType[] VisitorOrganizationReference
        {
            get
            {
                return this.visitorOrganizationReferenceField;
            }
            set
            {
                this.visitorOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType VisitDescriptionText
        {
            get
            {
                return this.visitDescriptionTextField;
            }
            set
            {
                this.visitDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitedPersonReference", Order=3)]
        public ReferenceType[] VisitedPersonReference
        {
            get
            {
                return this.visitedPersonReferenceField;
            }
            set
            {
                this.visitedPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitedOrganizationReference", Order=4)]
        public ReferenceType[] VisitedOrganizationReference
        {
            get
            {
                return this.visitedOrganizationReferenceField;
            }
            set
            {
                this.visitedOrganizationReferenceField = value;
            }
        }
    }
}
