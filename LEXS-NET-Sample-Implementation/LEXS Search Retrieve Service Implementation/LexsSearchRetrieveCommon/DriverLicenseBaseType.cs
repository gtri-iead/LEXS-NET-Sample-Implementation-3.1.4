namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class DriverLicenseBaseType : ComplexObjectType
    {
        
        private IdentificationType driverLicenseIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType DriverLicenseIdentification
        {
            get
            {
                return this.driverLicenseIdentificationField;
            }
            set
            {
                this.driverLicenseIdentificationField = value;
            }
        }
    }
}
