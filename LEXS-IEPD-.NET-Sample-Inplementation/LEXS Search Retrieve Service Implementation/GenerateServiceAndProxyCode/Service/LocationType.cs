namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class LocationType : ComplexObjectType
    {
        
        private AddressType locationAddressField;
        
        private TwoDimensionalGeographicCoordinateType locationTwoDimensionalGeographicCoordinateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public AddressType LocationAddress
        {
            get
            {
                return this.locationAddressField;
            }
            set
            {
                this.locationAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TwoDimensionalGeographicCoordinateType LocationTwoDimensionalGeographicCoordinate
        {
            get
            {
                return this.locationTwoDimensionalGeographicCoordinateField;
            }
            set
            {
                this.locationTwoDimensionalGeographicCoordinateField = value;
            }
        }
    }
}
