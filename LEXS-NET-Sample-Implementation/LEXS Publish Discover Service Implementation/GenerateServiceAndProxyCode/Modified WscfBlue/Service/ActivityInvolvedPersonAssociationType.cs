namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ActivityInvolvedPersonAssociationType : ActivityPersonAssociationType
    {
        
        private TextType[] personActivityInvolvementTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonActivityInvolvementText", IsNullable=true, Order=0)]
        public TextType[] PersonActivityInvolvementText
        {
            get
            {
                return this.personActivityInvolvementTextField;
            }
            set
            {
                this.personActivityInvolvementTextField = value;
            }
        }
    }
}
