namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class AircraftType : ConveyanceType
    {
        
        private @string aircraftTailIDField;
        
        private VMACodeType aircraftMakeCodeField;
        
        private VMOCodeType aircraftModelCodeField;
        
        private VSTCodeType aircraftStyleCodeField;
        
        private object item2Field;
        
        private object item3Field;
        
        private FacilityType aircraftBaseAirportField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @string AircraftTailID
        {
            get
            {
                return this.aircraftTailIDField;
            }
            set
            {
                this.aircraftTailIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public VMACodeType AircraftMakeCode
        {
            get
            {
                return this.aircraftMakeCodeField;
            }
            set
            {
                this.aircraftMakeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public VMOCodeType AircraftModelCode
        {
            get
            {
                return this.aircraftModelCodeField;
            }
            set
            {
                this.aircraftModelCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public VSTCodeType AircraftStyleCode
        {
            get
            {
                return this.aircraftStyleCodeField;
            }
            set
            {
                this.aircraftStyleCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AircraftFuselageColorCode", typeof(VCOCodeType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("AircraftFuselageColorText", typeof(TextType), IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute("AircraftWingColorCode", typeof(VCOCodeType), IsNullable=true, Order=5)]
        [System.Xml.Serialization.XmlElementAttribute("AircraftWingColorText", typeof(TextType), IsNullable=true, Order=5)]
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
        public FacilityType AircraftBaseAirport
        {
            get
            {
                return this.aircraftBaseAirportField;
            }
            set
            {
                this.aircraftBaseAirportField = value;
            }
        }
    }
}
