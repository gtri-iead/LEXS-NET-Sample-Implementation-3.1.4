namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class VictimWitnessAssociationType : AssociationType
    {
        
        private ReferenceType[] victimPersonReferenceField;
        
        private ReferenceType[] victimOrganizationReferenceField;
        
        private ReferenceType[] witnessPersonReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimPersonReference", Order=0)]
        public ReferenceType[] VictimPersonReference
        {
            get
            {
                return this.victimPersonReferenceField;
            }
            set
            {
                this.victimPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimOrganizationReference", Order=1)]
        public ReferenceType[] VictimOrganizationReference
        {
            get
            {
                return this.victimOrganizationReferenceField;
            }
            set
            {
                this.victimOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WitnessPersonReference", Order=2)]
        public ReferenceType[] WitnessPersonReference
        {
            get
            {
                return this.witnessPersonReferenceField;
            }
            set
            {
                this.witnessPersonReferenceField = value;
            }
        }
    }
}
