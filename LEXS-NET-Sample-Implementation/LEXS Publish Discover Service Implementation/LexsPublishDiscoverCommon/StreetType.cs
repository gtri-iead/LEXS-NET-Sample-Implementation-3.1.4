namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class StreetType : ComplexObjectType
    {
        
        private TextType streetFullTextField;
        
        private TextType streetNumberTextField;
        
        private TextType streetPredirectionalTextField;
        
        private ProperNameTextType streetNameField;
        
        private TextType streetCategoryTextField;
        
        private TextType streetPostdirectionalTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType StreetFullText
        {
            get
            {
                return this.streetFullTextField;
            }
            set
            {
                this.streetFullTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType StreetNumberText
        {
            get
            {
                return this.streetNumberTextField;
            }
            set
            {
                this.streetNumberTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType StreetPredirectionalText
        {
            get
            {
                return this.streetPredirectionalTextField;
            }
            set
            {
                this.streetPredirectionalTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public ProperNameTextType StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType StreetCategoryText
        {
            get
            {
                return this.streetCategoryTextField;
            }
            set
            {
                this.streetCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType StreetPostdirectionalText
        {
            get
            {
                return this.streetPostdirectionalTextField;
            }
            set
            {
                this.streetPostdirectionalTextField = value;
            }
        }
    }
}
