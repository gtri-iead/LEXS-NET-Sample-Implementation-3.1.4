namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DigestType : ComplexObjectType
    {
        
        private EntityType1[] itemsField;
        
        private EntityAssociationsType associationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityActivity", typeof(EntityActivityType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityAircraft", typeof(EntityAircraftType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCreditCard", typeof(EntityCreditCardType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDocument", typeof(EntityDocumentType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDrug", typeof(EntityDrugType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityEmail", typeof(EntityEmailType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityExplosive", typeof(EntityExplosiveType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityFirearm", typeof(EntityFirearmType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityHash", typeof(EntityHashType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityInstantMessenger", typeof(EntityInstantMessengerType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityIntangibleItem", typeof(EntityIntangibleItemType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityLocation", typeof(EntityLocationType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityNetworkAddress", typeof(EntityNetworkAddressType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOrganization", typeof(EntityOrganizationType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityPerson", typeof(EntityPersonType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySubstance", typeof(EntitySubstanceType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTangibleItem", typeof(EntityTangibleItemType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTelephoneNumber", typeof(EntityTelephoneNumberType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVehicle", typeof(EntityVehicleType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVessel", typeof(EntityVesselType), Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=0)]
        public EntityType1[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1", IsNullable=true, Order=1)]
        public EntityAssociationsType Associations
        {
            get
            {
                return this.associationsField;
            }
            set
            {
                this.associationsField = value;
            }
        }
    }
}
