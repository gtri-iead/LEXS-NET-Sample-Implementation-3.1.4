namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityOrganizationType : EntityType
    {
        
        private OrganizationType organizationField;
        
        private SubjectType[] chargeSubjectField;
        
        private VictimType[] chargeVictimField;
        
        private SubjectType[] citationSubjectField;
        
        private SubjectType[] convictionSubjectField;
        
        private SubjectType[] courtOrderDesignatedSubjectField;
        
        private CriminalOrganizationType[] criminalOrganizationField;
        
        private SubjectType[] forceSubjectField;
        
        private VictimType[] forceVictimField;
        
        private SubjectType[] incidentSubjectField;
        
        private VictimType[] incidentVictimField;
        
        private SubjectType[] sentenceSubjectField;
        
        private SubjectType[] subjectField;
        
        private SubjectType[] suspectField;
        
        private SubjectType[] verdictSubjectField;
        
        private VictimType[] victimField;
        
        private SubjectType[] supervisionSubjectField;
        
        private LesseeType[] lesseeField;
        
        private LessorType[] lessorField;
        
        private VehicleBranderType[] vehicleBranderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public OrganizationType Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=1)]
        public SubjectType[] ChargeSubject
        {
            get
            {
                return this.chargeSubjectField;
            }
            set
            {
                this.chargeSubjectField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CitationSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=3)]
        public SubjectType[] CitationSubject
        {
            get
            {
                return this.citationSubjectField;
            }
            set
            {
                this.citationSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConvictionSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=4)]
        public SubjectType[] ConvictionSubject
        {
            get
            {
                return this.convictionSubjectField;
            }
            set
            {
                this.convictionSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtOrderDesignatedSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=5)]
        public SubjectType[] CourtOrderDesignatedSubject
        {
            get
            {
                return this.courtOrderDesignatedSubjectField;
            }
            set
            {
                this.courtOrderDesignatedSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CriminalOrganization", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=6)]
        public CriminalOrganizationType[] CriminalOrganization
        {
            get
            {
                return this.criminalOrganizationField;
            }
            set
            {
                this.criminalOrganizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=7)]
        public SubjectType[] ForceSubject
        {
            get
            {
                return this.forceSubjectField;
            }
            set
            {
                this.forceSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute("IncidentSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=9)]
        public SubjectType[] IncidentSubject
        {
            get
            {
                return this.incidentSubjectField;
            }
            set
            {
                this.incidentSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute("SentenceSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=11)]
        public SubjectType[] SentenceSubject
        {
            get
            {
                return this.sentenceSubjectField;
            }
            set
            {
                this.sentenceSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=12)]
        public SubjectType[] Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Suspect", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=13)]
        public SubjectType[] Suspect
        {
            get
            {
                return this.suspectField;
            }
            set
            {
                this.suspectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VerdictSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=14)]
        public SubjectType[] VerdictSubject
        {
            get
            {
                return this.verdictSubjectField;
            }
            set
            {
                this.verdictSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Victim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute("SupervisionSubject", IsNullable=true, Order=16)]
        public SubjectType[] SupervisionSubject
        {
            get
            {
                return this.supervisionSubjectField;
            }
            set
            {
                this.supervisionSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lessee", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=17)]
        public LesseeType[] Lessee
        {
            get
            {
                return this.lesseeField;
            }
            set
            {
                this.lesseeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lessor", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=18)]
        public LessorType[] Lessor
        {
            get
            {
                return this.lessorField;
            }
            set
            {
                this.lessorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehicleBrander", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=19)]
        public VehicleBranderType[] VehicleBrander
        {
            get
            {
                return this.vehicleBranderField;
            }
            set
            {
                this.vehicleBranderField = value;
            }
        }
    }
}
