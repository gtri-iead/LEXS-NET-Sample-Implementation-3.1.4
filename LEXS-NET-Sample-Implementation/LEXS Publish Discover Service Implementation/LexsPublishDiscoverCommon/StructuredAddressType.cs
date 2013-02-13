namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class StructuredAddressType : ComplexObjectType
    {
        
        private object[] itemsField;
        
        private ProperNameTextType locationCityNameField;
        
        private ProperNameTextType itemField;
        
        private ProperNameTextType item1Field;
        
        private @string locationPostalCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressSecondaryUnitText", typeof(TextType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("LocationStreet", typeof(StreetType), IsNullable=true, Order=0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public ProperNameTextType LocationCityName
        {
            get
            {
                return this.locationCityNameField;
            }
            set
            {
                this.locationCityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationStateName", IsNullable=true, Order=2)]
        public ProperNameTextType Item
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
        [System.Xml.Serialization.XmlElementAttribute("LocationCountryName", IsNullable=true, Order=3)]
        public ProperNameTextType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public @string LocationPostalCode
        {
            get
            {
                return this.locationPostalCodeField;
            }
            set
            {
                this.locationPostalCodeField = value;
            }
        }
    }
}
