namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PersonRegisterNumberType : IdentificationType
    {
        
        private boolean[] bOPRegisterNumberOriginatorIndicatorField;
        
        private boolean[] uSMSRegisterNumberOriginatorIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BOPRegisterNumberOriginatorIndicator", IsNullable=true, Order=0)]
        public boolean[] BOPRegisterNumberOriginatorIndicator
        {
            get
            {
                return this.bOPRegisterNumberOriginatorIndicatorField;
            }
            set
            {
                this.bOPRegisterNumberOriginatorIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("USMSRegisterNumberOriginatorIndicator", IsNullable=true, Order=1)]
        public boolean[] USMSRegisterNumberOriginatorIndicator
        {
            get
            {
                return this.uSMSRegisterNumberOriginatorIndicatorField;
            }
            set
            {
                this.uSMSRegisterNumberOriginatorIndicatorField = value;
            }
        }
    }
}
