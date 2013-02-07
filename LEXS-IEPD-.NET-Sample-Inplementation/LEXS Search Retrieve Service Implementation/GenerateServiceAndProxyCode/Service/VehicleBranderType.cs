namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class VehicleBranderType : ComplexObjectType
    {
        
        private ReferenceType roleOfOrganizationReferenceField;
        
        private IdentificationType vehicleBranderIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType RoleOfOrganizationReference
        {
            get
            {
                return this.roleOfOrganizationReferenceField;
            }
            set
            {
                this.roleOfOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public IdentificationType VehicleBranderIdentification
        {
            get
            {
                return this.vehicleBranderIdentificationField;
            }
            set
            {
                this.vehicleBranderIdentificationField = value;
            }
        }
    }
}
