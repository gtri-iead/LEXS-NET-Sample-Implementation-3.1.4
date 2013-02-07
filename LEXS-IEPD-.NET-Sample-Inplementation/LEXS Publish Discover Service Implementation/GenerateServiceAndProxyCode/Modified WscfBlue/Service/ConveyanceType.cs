namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VesselType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AircraftType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ConveyanceType : TangibleItemType
    {
        
        private nonNegativeInteger conveyanceEngineQuantityField;
        
        private IdentificationType[] conveyanceRegistrationPlateIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public nonNegativeInteger ConveyanceEngineQuantity
        {
            get
            {
                return this.conveyanceEngineQuantityField;
            }
            set
            {
                this.conveyanceEngineQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceRegistrationPlateIdentification", IsNullable=true, Order=1)]
        public IdentificationType[] ConveyanceRegistrationPlateIdentification
        {
            get
            {
                return this.conveyanceRegistrationPlateIdentificationField;
            }
            set
            {
                this.conveyanceRegistrationPlateIdentificationField = value;
            }
        }
    }
}
