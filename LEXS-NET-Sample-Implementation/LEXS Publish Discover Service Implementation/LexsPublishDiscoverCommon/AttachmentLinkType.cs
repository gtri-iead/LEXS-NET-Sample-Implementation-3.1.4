namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class AttachmentLinkType : ComplexObjectType
    {
        
        private AnyURIType attachmentURIField;
        
        private boolean attachmentViewableIndicatorField;
        
        private TextType binaryDescriptionTextField;
        
        private NonNegativeDecimalType binarySizeValueField;
        
        private TextType binaryCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnyURIType AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public boolean AttachmentViewableIndicator
        {
            get
            {
                return this.attachmentViewableIndicatorField;
            }
            set
            {
                this.attachmentViewableIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=2)]
        public TextType BinaryDescriptionText
        {
            get
            {
                return this.binaryDescriptionTextField;
            }
            set
            {
                this.binaryDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
        public NonNegativeDecimalType BinarySizeValue
        {
            get
            {
                return this.binarySizeValueField;
            }
            set
            {
                this.binarySizeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        public TextType BinaryCategoryText
        {
            get
            {
                return this.binaryCategoryTextField;
            }
            set
            {
                this.binaryCategoryTextField = value;
            }
        }
    }
}
