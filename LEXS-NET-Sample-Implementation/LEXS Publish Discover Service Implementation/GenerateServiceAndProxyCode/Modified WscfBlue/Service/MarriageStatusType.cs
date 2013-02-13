namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class MarriageStatusType : StatusType
    {
        
        private MarriageStatusCodeType personUnionStatusCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public MarriageStatusCodeType PersonUnionStatusCode
        {
            get
            {
                return this.personUnionStatusCodeField;
            }
            set
            {
                this.personUnionStatusCodeField = value;
            }
        }
    }
}
