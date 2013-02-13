namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PersonAugmentationType", Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class PersonAugmentationType1 : AugmentationType
    {
        
        private DriverLicenseType[] driverLicenseField;
        
        private IdentificationType[] personFBIIdentificationField;
        
        private IdentificationType[] personStateFingerprintIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverLicense", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public DriverLicenseType[] DriverLicense
        {
            get
            {
                return this.driverLicenseField;
            }
            set
            {
                this.driverLicenseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonFBIIdentification", IsNullable=true, Order=1)]
        public IdentificationType[] PersonFBIIdentification
        {
            get
            {
                return this.personFBIIdentificationField;
            }
            set
            {
                this.personFBIIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonStateFingerprintIdentification", IsNullable=true, Order=2)]
        public IdentificationType[] PersonStateFingerprintIdentification
        {
            get
            {
                return this.personStateFingerprintIdentificationField;
            }
            set
            {
                this.personStateFingerprintIdentificationField = value;
            }
        }
    }
}
