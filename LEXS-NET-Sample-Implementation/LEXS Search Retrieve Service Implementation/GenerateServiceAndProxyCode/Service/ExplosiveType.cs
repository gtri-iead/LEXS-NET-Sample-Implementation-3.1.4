namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ExplosiveType : TangibleItemType
    {
        
        private object[] items1Field;
        
        private object[] items2Field;
        
        private object[] items3Field;
        
        private object[] items4Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveComponentCode", typeof(ExplosiveComponentCodeType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveComponentText", typeof(TextType), IsNullable=true, Order=0)]
        public object[] Items1
        {
            get
            {
                return this.items1Field;
            }
            set
            {
                this.items1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveContainerCode", typeof(ExplosiveContainerCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveContainerText", typeof(TextType), IsNullable=true, Order=1)]
        public object[] Items2
        {
            get
            {
                return this.items2Field;
            }
            set
            {
                this.items2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveFillerCode", typeof(ExplosiveFillerCodeType), IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveFillerText", typeof(TextType), IsNullable=true, Order=2)]
        public object[] Items3
        {
            get
            {
                return this.items3Field;
            }
            set
            {
                this.items3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveIgnitionCode", typeof(ExplosiveIgnitionCodeType), IsNullable=true, Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("ExplosiveIgnitionText", typeof(TextType), IsNullable=true, Order=3)]
        public object[] Items4
        {
            get
            {
                return this.items4Field;
            }
            set
            {
                this.items4Field = value;
            }
        }
    }
}
