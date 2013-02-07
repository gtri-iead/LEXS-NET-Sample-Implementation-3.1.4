namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityTelephoneNumberAssociationType : AssociationType
    {
        
        private ReferenceType personReferenceField;
        
        private ReferenceType organizationReferenceField;
        
        private ReferenceType telephoneNumberReferenceField;
        
        private boolean telephoneNumberPrimaryIndicatorField;
        
        private boolean telephoneNumberHomeIndicatorField;
        
        private boolean telephoneNumberWorkIndicatorField;
        
        private boolean telephoneNumberEmergencyIndicatorField;
        
        private boolean telephoneNumberDayIndicatorField;
        
        private boolean telephoneNumberEveningIndicatorField;
        
        private boolean telephoneNumberNightIndicatorField;
        
        private boolean telephoneNumberUnspecifiedIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType OrganizationReference
        {
            get
            {
                return this.organizationReferenceField;
            }
            set
            {
                this.organizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType TelephoneNumberReference
        {
            get
            {
                return this.telephoneNumberReferenceField;
            }
            set
            {
                this.telephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public boolean TelephoneNumberPrimaryIndicator
        {
            get
            {
                return this.telephoneNumberPrimaryIndicatorField;
            }
            set
            {
                this.telephoneNumberPrimaryIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public boolean TelephoneNumberHomeIndicator
        {
            get
            {
                return this.telephoneNumberHomeIndicatorField;
            }
            set
            {
                this.telephoneNumberHomeIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public boolean TelephoneNumberWorkIndicator
        {
            get
            {
                return this.telephoneNumberWorkIndicatorField;
            }
            set
            {
                this.telephoneNumberWorkIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public boolean TelephoneNumberEmergencyIndicator
        {
            get
            {
                return this.telephoneNumberEmergencyIndicatorField;
            }
            set
            {
                this.telephoneNumberEmergencyIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public boolean TelephoneNumberDayIndicator
        {
            get
            {
                return this.telephoneNumberDayIndicatorField;
            }
            set
            {
                this.telephoneNumberDayIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public boolean TelephoneNumberEveningIndicator
        {
            get
            {
                return this.telephoneNumberEveningIndicatorField;
            }
            set
            {
                this.telephoneNumberEveningIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public boolean TelephoneNumberNightIndicator
        {
            get
            {
                return this.telephoneNumberNightIndicatorField;
            }
            set
            {
                this.telephoneNumberNightIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public boolean TelephoneNumberUnspecifiedIndicator
        {
            get
            {
                return this.telephoneNumberUnspecifiedIndicatorField;
            }
            set
            {
                this.telephoneNumberUnspecifiedIndicatorField = value;
            }
        }
    }
}
