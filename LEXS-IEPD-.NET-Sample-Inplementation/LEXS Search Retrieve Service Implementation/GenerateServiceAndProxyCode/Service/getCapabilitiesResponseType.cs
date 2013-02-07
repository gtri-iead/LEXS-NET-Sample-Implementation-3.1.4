namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/searchretrieve/3.1")]
    public partial class getCapabilitiesResponseType
    {
        
        private CapabilitiesResponseMessageType capabilitiesResponseMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        public CapabilitiesResponseMessageType CapabilitiesResponseMessage
        {
            get
            {
                return this.capabilitiesResponseMessageField;
            }
            set
            {
                this.capabilitiesResponseMessageField = value;
            }
        }
    }
}
