namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class VesselType : ConveyanceType
    {
        
        private IdentificationType vesselRegistrationIdentificationField;
        
        private BMACodeType vesselMakeCodeField;
        
        private BTYCodeType vesselCategoryCodeField;
        
        private IdentificationType vesselHullIdentificationField;
        
        private object[] items1Field;
        
        private object[] items2Field;
        
        private object item2Field;
        
        private object item3Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType VesselRegistrationIdentification
        {
            get
            {
                return this.vesselRegistrationIdentificationField;
            }
            set
            {
                this.vesselRegistrationIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public BMACodeType VesselMakeCode
        {
            get
            {
                return this.vesselMakeCodeField;
            }
            set
            {
                this.vesselMakeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public BTYCodeType VesselCategoryCode
        {
            get
            {
                return this.vesselCategoryCodeField;
            }
            set
            {
                this.vesselCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public IdentificationType VesselHullIdentification
        {
            get
            {
                return this.vesselHullIdentificationField;
            }
            set
            {
                this.vesselHullIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VesselHullMaterialCode", typeof(HULCodeType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("VesselHullMaterialText", typeof(TextType), IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute("VesselHullShapeCode", typeof(HSPCodeType), IsNullable=true, Order=5)]
        [System.Xml.Serialization.XmlElementAttribute("VesselHullShapeText", typeof(TextType), IsNullable=true, Order=5)]
        public object[] Items2
        {
            get
            {
                return this.items2Field;
            }
            set
            {
                this.items2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VesselPropulsionCode", typeof(PROCodeType), IsNullable=true, Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("VesselPropulsionText", typeof(TextType), IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute("VesselTrailerMakeCode", typeof(BTMACodeType), IsNullable=true, Order=7)]
        [System.Xml.Serialization.XmlElementAttribute("VesselTrailerMakeName", typeof(TextType), IsNullable=true, Order=7)]
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
    }
}
