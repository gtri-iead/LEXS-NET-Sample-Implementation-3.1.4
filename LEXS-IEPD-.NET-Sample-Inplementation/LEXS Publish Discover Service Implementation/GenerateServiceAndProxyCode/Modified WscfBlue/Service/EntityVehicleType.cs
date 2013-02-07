namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityVehicleType : EntityType
    {
        
        private VehicleType vehicleField;
        
        private ResourceType[] resourceField;
        
        private VictimType[] chargeVictimField;
        
        private VictimType[] forceVictimField;
        
        private VictimType[] incidentVictimField;
        
        private VictimType[] victimField;
        
        private PropertyType[] propertyField;
        
        private WeaponType[] weaponField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public VehicleType Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ChargeVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=2)]
        public VictimType[] ChargeVictim
        {
            get
            {
                return this.chargeVictimField;
            }
            set
            {
                this.chargeVictimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=3)]
        public VictimType[] ForceVictim
        {
            get
            {
                return this.forceVictimField;
            }
            set
            {
                this.forceVictimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=4)]
        public VictimType[] IncidentVictim
        {
            get
            {
                return this.incidentVictimField;
            }
            set
            {
                this.incidentVictimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Victim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=5)]
        public VictimType[] Victim
        {
            get
            {
                return this.victimField;
            }
            set
            {
                this.victimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=6)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weapon", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=7)]
        public WeaponType[] Weapon
        {
            get
            {
                return this.weaponField;
            }
            set
            {
                this.weaponField = value;
            }
        }
    }
}
