namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubstanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrugType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirearmType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExplosiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConveyanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VesselType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AircraftType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class TangibleItemType : ItemType
    {
        
        private TextType itemField;
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        private LengthMeasureType itemHeightMeasureField;
        
        private LengthMeasureType itemLengthMeasureField;
        
        private ProperNameTextType itemMakeNameField;
        
        private ProperNameTextType itemModelNameField;
        
        private gYear itemModelYearDateField;
        
        private VSTCodeType item1Field;
        
        private WeightMeasureType itemWeightMeasureField;
        
        private LengthMeasureType itemWidthMeasureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemCategoryText", IsNullable=true, Order=0)]
        public TextType Item
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
        [System.Xml.Serialization.XmlElementAttribute("ItemColorDescriptionText", typeof(TextType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleColorPrimaryCode", typeof(VCOCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleColorSecondaryCode", typeof(VCOCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("VesselColorPrimaryCode", typeof(BCOCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("VesselColorSecondaryCode", typeof(BCOCodeType), IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
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
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public LengthMeasureType ItemHeightMeasure
        {
            get
            {
                return this.itemHeightMeasureField;
            }
            set
            {
                this.itemHeightMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public LengthMeasureType ItemLengthMeasure
        {
            get
            {
                return this.itemLengthMeasureField;
            }
            set
            {
                this.itemLengthMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public ProperNameTextType ItemMakeName
        {
            get
            {
                return this.itemMakeNameField;
            }
            set
            {
                this.itemMakeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public ProperNameTextType ItemModelName
        {
            get
            {
                return this.itemModelNameField;
            }
            set
            {
                this.itemModelNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public gYear ItemModelYearDate
        {
            get
            {
                return this.itemModelYearDateField;
            }
            set
            {
                this.itemModelYearDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehicleStyleCode", IsNullable=true, Order=8)]
        public VSTCodeType Item1
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public WeightMeasureType ItemWeightMeasure
        {
            get
            {
                return this.itemWeightMeasureField;
            }
            set
            {
                this.itemWeightMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public LengthMeasureType ItemWidthMeasure
        {
            get
            {
                return this.itemWidthMeasureField;
            }
            set
            {
                this.itemWidthMeasureField = value;
            }
        }
    }
}
