namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class HashType : ComplexObjectType
    {
        
        private HashValueType[] hashValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HashValue", IsNullable=true, Order=0)]
        public HashValueType[] HashValue
        {
            get
            {
                return this.hashValueField;
            }
            set
            {
                this.hashValueField = value;
            }
        }
    }
}
