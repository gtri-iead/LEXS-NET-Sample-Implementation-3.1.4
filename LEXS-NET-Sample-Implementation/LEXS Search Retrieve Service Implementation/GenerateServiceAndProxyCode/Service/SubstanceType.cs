namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrugType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class SubstanceType : TangibleItemType
    {
        
        private TextType[] items1Field;
        
        private object[] substanceCodeField;
        
        private TextType substanceContainerDescriptionTextField;
        
        private SubstanceMeasureType substanceQuantityMeasureField;
        
        private TextType substanceCompositionDescriptionTextField;
        
        private TextType substanceFormTextField;
        
        private TextType substanceFoundDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubstanceCategoryText", IsNullable=true, Order=0)]
        public TextType[] Items1
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
        [System.Xml.Serialization.XmlElementAttribute("SubstanceCode", Order=1)]
        public object[] SubstanceCode
        {
            get
            {
                return this.substanceCodeField;
            }
            set
            {
                this.substanceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType SubstanceContainerDescriptionText
        {
            get
            {
                return this.substanceContainerDescriptionTextField;
            }
            set
            {
                this.substanceContainerDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public SubstanceMeasureType SubstanceQuantityMeasure
        {
            get
            {
                return this.substanceQuantityMeasureField;
            }
            set
            {
                this.substanceQuantityMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType SubstanceCompositionDescriptionText
        {
            get
            {
                return this.substanceCompositionDescriptionTextField;
            }
            set
            {
                this.substanceCompositionDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType SubstanceFormText
        {
            get
            {
                return this.substanceFormTextField;
            }
            set
            {
                this.substanceFormTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType SubstanceFoundDescriptionText
        {
            get
            {
                return this.substanceFoundDescriptionTextField;
            }
            set
            {
                this.substanceFoundDescriptionTextField = value;
            }
        }
    }
}
