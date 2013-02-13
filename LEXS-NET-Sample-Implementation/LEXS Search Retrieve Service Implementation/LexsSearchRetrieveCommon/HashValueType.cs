namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class HashValueType : ComplexObjectType
    {
        
        private object itemField;
        
        private TextType hashValueMethodAlgorithmTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HashValueBinaryBase64Object", typeof(base64Binary), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("HashValueText", typeof(TextType), IsNullable=true, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType HashValueMethodAlgorithmText
        {
            get
            {
                return this.hashValueMethodAlgorithmTextField;
            }
            set
            {
                this.hashValueMethodAlgorithmTextField = value;
            }
        }
    }
}
