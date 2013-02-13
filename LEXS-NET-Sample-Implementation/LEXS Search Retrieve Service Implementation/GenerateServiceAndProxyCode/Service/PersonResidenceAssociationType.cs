namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonResidenceAssociationType : PersonLocationAssociationType
    {
        
        private TextType[] residenceDescriptionTextField;
        
        private TextType[] residenceOccupancyCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResidenceDescriptionText", IsNullable=true, Order=0)]
        public TextType[] ResidenceDescriptionText
        {
            get
            {
                return this.residenceDescriptionTextField;
            }
            set
            {
                this.residenceDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResidenceOccupancyCategoryText", IsNullable=true, Order=1)]
        public TextType[] ResidenceOccupancyCategoryText
        {
            get
            {
                return this.residenceOccupancyCategoryTextField;
            }
            set
            {
                this.residenceOccupancyCategoryTextField = value;
            }
        }
    }
}
