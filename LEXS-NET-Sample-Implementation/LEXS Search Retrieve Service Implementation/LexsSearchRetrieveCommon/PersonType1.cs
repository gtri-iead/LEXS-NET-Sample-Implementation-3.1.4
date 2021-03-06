namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PersonType", Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PersonType1 : PersonType
    {
        
        private PersonAugmentationType1 personAugmentationField;
        
        private PersonAugmentationType personAugmentation1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0", Order=0)]
        public PersonAugmentationType1 PersonAugmentation
        {
            get
            {
                return this.personAugmentationField;
            }
            set
            {
                this.personAugmentationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAugmentation", IsNullable=true, Order=1)]
        public PersonAugmentationType PersonAugmentation1
        {
            get
            {
                return this.personAugmentation1Field;
            }
            set
            {
                this.personAugmentation1Field = value;
            }
        }
    }
}
