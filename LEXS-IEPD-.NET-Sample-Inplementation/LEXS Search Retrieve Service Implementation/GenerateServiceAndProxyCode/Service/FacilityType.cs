namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class FacilityType : ComplexObjectType
    {
        
        private IdentificationType facilityIdentificationField;
        
        private ProperNameTextType facilityNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType FacilityIdentification
        {
            get
            {
                return this.facilityIdentificationField;
            }
            set
            {
                this.facilityIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public ProperNameTextType FacilityName
        {
            get
            {
                return this.facilityNameField;
            }
            set
            {
                this.facilityNameField = value;
            }
        }
    }
}
