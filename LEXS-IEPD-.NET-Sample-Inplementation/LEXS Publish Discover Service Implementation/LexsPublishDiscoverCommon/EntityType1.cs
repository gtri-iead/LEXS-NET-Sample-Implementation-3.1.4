namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityVesselType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityVehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityTelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityTangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntitySubstanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityPersonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityOrganizationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNetworkAddressType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityLocationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityIntangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityInstantMessengerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityHashType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityFirearmType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityExplosiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityEmailType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityDrugType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCreditCardType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAssociationsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAircraftType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityActivityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EntityType", Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityType1 : ComplexObjectType
    {
        
        private MetadataType2[] metadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata", IsNullable=true, Order=0)]
        public MetadataType2[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }
    }
}
