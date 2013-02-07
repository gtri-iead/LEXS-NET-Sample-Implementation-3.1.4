namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class VehicleType : ConveyanceType
    {
        
        private IdentificationType vehicleIdentificationField;
        
        private VMACodeType vehicleMakeCodeField;
        
        private VMOCodeType vehicleModelCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType VehicleIdentification
        {
            get
            {
                return this.vehicleIdentificationField;
            }
            set
            {
                this.vehicleIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public VMACodeType VehicleMakeCode
        {
            get
            {
                return this.vehicleMakeCodeField;
            }
            set
            {
                this.vehicleMakeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public VMOCodeType VehicleModelCode
        {
            get
            {
                return this.vehicleModelCodeField;
            }
            set
            {
                this.vehicleModelCodeField = value;
            }
        }
    }
}
