namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityIntangibleItemType : EntityType1
    {
        
        private IntangibleItemType intangibleItemField;
        
        private ResourceType[] resourceField;
        
        private PropertyType[] propertyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public IntangibleItemType IntangibleItem
        {
            get
            {
                return this.intangibleItemField;
            }
            set
            {
                this.intangibleItemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resource", Namespace="http://niem.gov/niem/domains/emergencyManagement/2.0", IsNullable=true, Order=1)]
        public ResourceType[] Resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=2)]
        public PropertyType[] Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }
}
