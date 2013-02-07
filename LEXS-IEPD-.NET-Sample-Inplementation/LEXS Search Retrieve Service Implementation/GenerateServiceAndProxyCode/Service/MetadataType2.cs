namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MetadataType", Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class MetadataType2 : MetadataType1
    {
        
        private TextType logicalIDTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType LogicalIDText
        {
            get
            {
                return this.logicalIDTextField;
            }
            set
            {
                this.logicalIDTextField = value;
            }
        }
    }
}
