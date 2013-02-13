namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class MissingPersonType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private object itemField;
        
        private DateType missingPersonDeclarationDateField;
        
        private DateType missingPersonFoundDateField;
        
        private boolean missingPersonFoundIndicatorField;
        
        private DateType missingPersonLastSeenDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MissingPersonCircumstanceCode", typeof(MPCCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("MissingPersonCircumstanceText", typeof(TextType), IsNullable=true, Order=1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public DateType MissingPersonDeclarationDate
        {
            get
            {
                return this.missingPersonDeclarationDateField;
            }
            set
            {
                this.missingPersonDeclarationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType MissingPersonFoundDate
        {
            get
            {
                return this.missingPersonFoundDateField;
            }
            set
            {
                this.missingPersonFoundDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public boolean MissingPersonFoundIndicator
        {
            get
            {
                return this.missingPersonFoundIndicatorField;
            }
            set
            {
                this.missingPersonFoundIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public DateType MissingPersonLastSeenDate
        {
            get
            {
                return this.missingPersonLastSeenDateField;
            }
            set
            {
                this.missingPersonLastSeenDateField = value;
            }
        }
    }
}
