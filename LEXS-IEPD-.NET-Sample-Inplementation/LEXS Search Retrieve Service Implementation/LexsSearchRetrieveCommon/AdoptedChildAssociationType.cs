namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/screening/2.0")]
    public partial class AdoptedChildAssociationType : ImmediateFamilyAssociationType
    {
        
        private DateType adoptionEffectiveDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DateType AdoptionEffectiveDate
        {
            get
            {
                return this.adoptionEffectiveDateField;
            }
            set
            {
                this.adoptionEffectiveDateField = value;
            }
        }
    }
}
