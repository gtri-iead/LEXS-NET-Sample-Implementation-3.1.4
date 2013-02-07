namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class InstantMessengerType : ComplexObjectType
    {
        
        private TextType instantMessengerClientNameField;
        
        private @string instantMessengerScreenIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType InstantMessengerClientName
        {
            get
            {
                return this.instantMessengerClientNameField;
            }
            set
            {
                this.instantMessengerClientNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public @string InstantMessengerScreenID
        {
            get
            {
                return this.instantMessengerScreenIDField;
            }
            set
            {
                this.instantMessengerScreenIDField = value;
            }
        }
    }
}
