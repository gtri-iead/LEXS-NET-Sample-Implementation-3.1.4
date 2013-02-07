namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class RelatedActivityAssociationType : AssociationType
    {
        
        private ReferenceType[] activityReferenceField;
        
        private TextType[] activityRelationTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReference", Order=0)]
        public ReferenceType[] ActivityReference
        {
            get
            {
                return this.activityReferenceField;
            }
            set
            {
                this.activityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityRelationText", IsNullable=true, Order=1)]
        public TextType[] ActivityRelationText
        {
            get
            {
                return this.activityRelationTextField;
            }
            set
            {
                this.activityRelationTextField = value;
            }
        }
    }
}
