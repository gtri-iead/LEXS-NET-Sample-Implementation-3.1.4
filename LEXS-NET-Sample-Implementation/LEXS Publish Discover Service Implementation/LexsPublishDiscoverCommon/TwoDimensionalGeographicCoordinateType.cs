namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class TwoDimensionalGeographicCoordinateType : ComplexObjectType
    {
        
        private LatitudeCoordinateType geographicCoordinateLatitudeField;
        
        private LongitudeCoordinateType geographicCoordinateLongitudeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public LatitudeCoordinateType GeographicCoordinateLatitude
        {
            get
            {
                return this.geographicCoordinateLatitudeField;
            }
            set
            {
                this.geographicCoordinateLatitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public LongitudeCoordinateType GeographicCoordinateLongitude
        {
            get
            {
                return this.geographicCoordinateLongitudeField;
            }
            set
            {
                this.geographicCoordinateLongitudeField = value;
            }
        }
    }
}
