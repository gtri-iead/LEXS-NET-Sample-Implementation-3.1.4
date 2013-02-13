namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonUnionAssociationType : PersonAssociationType
    {
        
        private MarriageStatusType[] personUnionStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonUnionStatus", IsNullable=true, Order=0)]
        public MarriageStatusType[] PersonUnionStatus
        {
            get
            {
                return this.personUnionStatusField;
            }
            set
            {
                this.personUnionStatusField = value;
            }
        }
    }
}
