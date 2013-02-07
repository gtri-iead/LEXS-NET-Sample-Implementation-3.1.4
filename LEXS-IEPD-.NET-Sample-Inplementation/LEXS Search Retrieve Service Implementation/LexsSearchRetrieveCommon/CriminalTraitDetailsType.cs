namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CriminalTraitDetailsType : ComplexObjectType
    {
        
        private TextType criminalTraitColorTextField;
        
        private TextType criminalTraitCommunicationDescriptionTextField;
        
        private TextType criminalTraitDescriptionTextField;
        
        private TextType criminalTraitDressTextField;
        
        private TextType criminalTraitModusOperandiTextField;
        
        private TextType criminalTraitTattooDescriptionTextField;
        
        private TextType criminalTraitTurfTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType CriminalTraitColorText
        {
            get
            {
                return this.criminalTraitColorTextField;
            }
            set
            {
                this.criminalTraitColorTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType CriminalTraitCommunicationDescriptionText
        {
            get
            {
                return this.criminalTraitCommunicationDescriptionTextField;
            }
            set
            {
                this.criminalTraitCommunicationDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType CriminalTraitDescriptionText
        {
            get
            {
                return this.criminalTraitDescriptionTextField;
            }
            set
            {
                this.criminalTraitDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType CriminalTraitDressText
        {
            get
            {
                return this.criminalTraitDressTextField;
            }
            set
            {
                this.criminalTraitDressTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType CriminalTraitModusOperandiText
        {
            get
            {
                return this.criminalTraitModusOperandiTextField;
            }
            set
            {
                this.criminalTraitModusOperandiTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType CriminalTraitTattooDescriptionText
        {
            get
            {
                return this.criminalTraitTattooDescriptionTextField;
            }
            set
            {
                this.criminalTraitTattooDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType CriminalTraitTurfText
        {
            get
            {
                return this.criminalTraitTurfTextField;
            }
            set
            {
                this.criminalTraitTurfTextField = value;
            }
        }
    }
}
