namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class FirearmType : TangibleItemType
    {
        
        private MAKCodeType firearmMakeCodeField;
        
        private TYPCodeType firearmCategoryCodeField;
        
        private object item2Field;
        
        private boolean firearmAutomaticIndicatorField;
        
        private object[] items1Field;
        
        private object item3Field;
        
        private TextType firearmGaugeTextField;
        
        private TextType firearmGripTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public MAKCodeType FirearmMakeCode
        {
            get
            {
                return this.firearmMakeCodeField;
            }
            set
            {
                this.firearmMakeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TYPCodeType FirearmCategoryCode
        {
            get
            {
                return this.firearmCategoryCodeField;
            }
            set
            {
                this.firearmCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FirearmCategoryDescriptionCode", typeof(TYPDescriptionCodeType), IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("FirearmCategoryDescriptionText", typeof(TextType), IsNullable=true, Order=2)]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public boolean FirearmAutomaticIndicator
        {
            get
            {
                return this.firearmAutomaticIndicatorField;
            }
            set
            {
                this.firearmAutomaticIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FirearmCaliberCode", typeof(CALCodeType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("FirearmCaliberText", typeof(TextType), IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute("FirearmFinishCode", typeof(GUNColorFinishCodeType), IsNullable=true, Order=5)]
        [System.Xml.Serialization.XmlElementAttribute("FirearmFinishText", typeof(TextType), IsNullable=true, Order=5)]
        public object Item3
        {
            get
            {
                return this.item3Field;
            }
            set
            {
                this.item3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType FirearmGaugeText
        {
            get
            {
                return this.firearmGaugeTextField;
            }
            set
            {
                this.firearmGaugeTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public TextType FirearmGripText
        {
            get
            {
                return this.firearmGripTextField;
            }
            set
            {
                this.firearmGripTextField = value;
            }
        }
    }
}
