namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class NumberOfStructuredPayloadTermsType : ComplexObjectType
    {
        
        private AnyURIType communityURIField;
        
        private nonNegativeInteger numberOfTermsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnyURIType CommunityURI
        {
            get
            {
                return this.communityURIField;
            }
            set
            {
                this.communityURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public nonNegativeInteger NumberOfTerms
        {
            get
            {
                return this.numberOfTermsField;
            }
            set
            {
                this.numberOfTermsField = value;
            }
        }
    }
}
