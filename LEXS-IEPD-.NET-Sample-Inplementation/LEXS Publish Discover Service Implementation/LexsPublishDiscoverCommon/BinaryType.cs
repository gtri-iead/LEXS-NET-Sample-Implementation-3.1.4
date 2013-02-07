namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class BinaryType : ComplexObjectType
    {
        
        private @string binaryIDField;
        
        private base64Binary itemField;
        
        private DateType binaryCaptureDateField;
        
        private TextType binaryDescriptionTextField;
        
        private @string binaryFormatIDField;
        
        private TextType binaryFormatStandardNameField;
        
        private NonNegativeDecimalType binarySizeValueField;
        
        private TextType binaryCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @string BinaryID
        {
            get
            {
                return this.binaryIDField;
            }
            set
            {
                this.binaryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryBase64Object", IsNullable=true, Order=1)]
        public base64Binary Item
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public DateType BinaryCaptureDate
        {
            get
            {
                return this.binaryCaptureDateField;
            }
            set
            {
                this.binaryCaptureDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public @string BinaryFormatID
        {
            get
            {
                return this.binaryFormatIDField;
            }
            set
            {
                this.binaryFormatIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType BinaryFormatStandardName
        {
            get
            {
                return this.binaryFormatStandardNameField;
            }
            set
            {
                this.binaryFormatStandardNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
