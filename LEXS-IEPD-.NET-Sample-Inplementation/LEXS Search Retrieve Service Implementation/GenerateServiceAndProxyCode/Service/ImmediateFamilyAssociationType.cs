namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdoptedChildAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ImmediateFamilyAssociationType : AssociationType
    {
        
        private ReferenceType[] personParentReferenceField;
        
        private ReferenceType[] personChildReferenceField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonParentReference", Order=0)]
        public ReferenceType[] PersonParentReference
        {
            get
            {
                return this.personParentReferenceField;
            }
            set
            {
                this.personParentReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonChildReference", Order=1)]
        public ReferenceType[] PersonChildReference
        {
            get
            {
                return this.personChildReferenceField;
            }
            set
            {
                this.personChildReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipCode", typeof(FamilyKinshipCodeType), IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipText", typeof(TextType), IsNullable=true, Order=2)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
