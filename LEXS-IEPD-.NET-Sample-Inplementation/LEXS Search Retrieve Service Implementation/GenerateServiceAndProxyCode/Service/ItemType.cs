namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditCardType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubstanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrugType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirearmType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExplosiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConveyanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VesselType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AircraftType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntangibleItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ItemType : ComplexObjectType
    {
        
        private TextType itemDescriptionTextField;
        
        private IdentificationType itemSerialIdentificationField;
        
        private ItemValueType itemValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType ItemDescriptionText
        {
            get
            {
                return this.itemDescriptionTextField;
            }
            set
            {
                this.itemDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public IdentificationType ItemSerialIdentification
        {
            get
            {
                return this.itemSerialIdentificationField;
            }
            set
            {
                this.itemSerialIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public ItemValueType ItemValue
        {
            get
            {
                return this.itemValueField;
            }
            set
            {
                this.itemValueField = value;
            }
        }
    }
}
