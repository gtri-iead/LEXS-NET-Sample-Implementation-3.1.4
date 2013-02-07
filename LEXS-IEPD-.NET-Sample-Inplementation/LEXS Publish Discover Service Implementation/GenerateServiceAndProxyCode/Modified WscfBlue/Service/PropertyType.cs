namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PropertyType : ComplexObjectType
    {
        
        private ReferenceType[] roleOfItemReferenceField;
        
        private ItemValueType[] propertyCurrentResaleValueField;
        
        private ItemValueType[] propertyRecoveredValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleOfItemReference", Order=0)]
        public ReferenceType[] RoleOfItemReference
        {
            get
            {
                return this.roleOfItemReferenceField;
            }
            set
            {
                this.roleOfItemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyCurrentResaleValue", IsNullable=true, Order=1)]
        public ItemValueType[] PropertyCurrentResaleValue
        {
            get
            {
                return this.propertyCurrentResaleValueField;
            }
            set
            {
                this.propertyCurrentResaleValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyRecoveredValue", IsNullable=true, Order=2)]
        public ItemValueType[] PropertyRecoveredValue
        {
            get
            {
                return this.propertyRecoveredValueField;
            }
            set
            {
                this.propertyRecoveredValueField = value;
            }
        }
    }
}
