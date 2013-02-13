namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class TransportationAssociationType : AssociationType
    {
        
        private ReferenceType[] conveyanceReferenceField;
        
        private ReferenceType[] conveyedItemReferenceField;
        
        private ReferenceType[] conveyanceOperatorReferenceField;
        
        private ReferenceType[] conveyedPersonReferenceField;
        
        private QuantityType[] conveyancePassengerQuantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceReference", Order=0)]
        public ReferenceType[] ConveyanceReference
        {
            get
            {
                return this.conveyanceReferenceField;
            }
            set
            {
                this.conveyanceReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyedItemReference", Order=1)]
        public ReferenceType[] ConveyedItemReference
        {
            get
            {
                return this.conveyedItemReferenceField;
            }
            set
            {
                this.conveyedItemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceOperatorReference", Order=2)]
        public ReferenceType[] ConveyanceOperatorReference
        {
            get
            {
                return this.conveyanceOperatorReferenceField;
            }
            set
            {
                this.conveyanceOperatorReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyedPersonReference", Order=3)]
        public ReferenceType[] ConveyedPersonReference
        {
            get
            {
                return this.conveyedPersonReferenceField;
            }
            set
            {
                this.conveyedPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyancePassengerQuantity", IsNullable=true, Order=4)]
        public QuantityType[] ConveyancePassengerQuantity
        {
            get
            {
                return this.conveyancePassengerQuantityField;
            }
            set
            {
                this.conveyancePassengerQuantityField = value;
            }
        }
    }
}
