namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class WeaponType : ComplexObjectType
    {
        
        private ReferenceType roleOfItemReferenceField;
        
        private ReferenceType weaponUserReferenceField;
        
        private TextType weaponUsageTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType RoleOfItemReference
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType WeaponUserReference
        {
            get
            {
                return this.weaponUserReferenceField;
            }
            set
            {
                this.weaponUserReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType WeaponUsageText
        {
            get
            {
                return this.weaponUsageTextField;
            }
            set
            {
                this.weaponUsageTextField = value;
            }
        }
    }
}
