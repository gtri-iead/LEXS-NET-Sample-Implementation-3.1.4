namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityPersonType : EntityType1
    {
        
        private PersonType1 personField;
        
        private ResourceType[] resourceField;
        
        private JudicialOfficialType[] appellateCaseDecisionIssuingJudgeField;
        
        private JudicialOfficialType[] appellateCaseNoticeProsecutingAttorneyField;
        
        private EnforcementOfficialType[] arrestOfficialField;
        
        private SubjectType[] arrestSubjectField;
        
        private JudicialOfficialType[] attorneyField;
        
        private SubjectType[] bailSubjectField;
        
        private EnforcementOfficialType[] bookingEmployeeField;
        
        private EnforcementOfficialType[] bookingReleaseCorrectionsAnalystField;
        
        private EnforcementOfficialType[] bookingSearchOfficialField;
        
        private SubjectType[] bookingSubjectField;
        
        private EnforcementOfficialType[] bookingTelephoneCallSupervisingOfficialField;
        
        private EnforcementOfficialType[] bookingTransportOfficialField;
        
        private JurorType[] caseJurorField;
        
        private WitnessType[] caseWitnessField;
        
        private SubjectType[] chargeSubjectField;
        
        private VictimType[] chargeVictimField;
        
        private EnforcementOfficialType[] citationIssuingOfficialField;
        
        private SubjectType[] citationSubjectField;
        
        private SubjectType[] convictionSubjectField;
        
        private JudicialOfficialType[] courtEventJudgeField;
        
        private SubjectType[] courtOrderDesignatedSubjectField;
        
        private JudicialOfficialType[] courtOrderIssuingJudicialOfficialField;
        
        private EnforcementOfficialType[] courtOrderServiceOfficialEnforcementField;
        
        private JudicialOfficialType[] courtOrderServiceOfficialJudicialField;
        
        private EnforcementOfficialType[] custodyTransferReceivingEnforcementOfficialField;
        
        private EnforcementOfficialType[] custodyTransferReleasingEnforcementOfficialField;
        
        private SubjectType[] custodyTransferSubjectField;
        
        private EnforcementOfficialType[] enforcementOfficialField;
        
        private SubjectType[] forceSubjectField;
        
        private VictimType[] forceVictimField;
        
        private EnforcementOfficialType[] incidentAssistingOfficialField;
        
        private EnforcementOfficialType[] incidentReportingOfficialField;
        
        private EnforcementOfficialType[] incidentResponseOfficialField;
        
        private SubjectType[] incidentSubjectField;
        
        private EnforcementOfficialType[] incidentSupervisingOfficialField;
        
        private VictimType[] incidentVictimField;
        
        private WitnessType[] incidentWitnessField;
        
        private JudicialOfficialType[] judgeField;
        
        private JudicialOfficialType[] judicialOfficialField;
        
        private JurorType[] jurorField;
        
        private MissingPersonType[] missingPersonField;
        
        private WitnessType[] missingPersonLastSeenWitnessField;
        
        private EnforcementOfficialType[] propertySeizureSeizingEnforcementOfficialField;
        
        private RegisteredOffenderType[] registeredOffenderField;
        
        private RegisteredOffenderType[] registeredSexOffenderField;
        
        private SubjectType[] sentenceSubjectField;
        
        private EnforcementOfficialType[] serviceCallDispatchedOfficialField;
        
        private JudicialOfficialType[] severityLevelAssignedJudgeField;
        
        private SubjectType[] subjectField;
        
        private SubjectType[] suspectField;
        
        private JudicialOfficialType[] verdictIssuingJudgeField;
        
        private SubjectType[] verdictSubjectField;
        
        private VictimType[] victimField;
        
        private EnforcementOfficialType[] visitationSupervisingOfficialEnforcementField;
        
        private JudicialOfficialType[] visitationSupervisingOfficialJudicialField;
        
        private WitnessType[] witnessField;
        
        private OtherInvolvedPersonType[] informantField;
        
        private SubjectType[] inmateField;
        
        private OtherInvolvedPersonType[] otherInvolvedPersonField;
        
        private SubjectType[] paroleeField;
        
        private SubjectType[] prisonerField;
        
        private SubjectType[] probationerField;
        
        private OtherInvolvedPersonType[] protectedPartyField;
        
        private SubjectType[] supervisionSubjectField;
        
        private LesseeType[] lesseeField;
        
        private LessorType[] lessorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public PersonType1 Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseDecisionIssuingJudge", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=2)]
        public JudicialOfficialType[] AppellateCaseDecisionIssuingJudge
        {
            get
            {
                return this.appellateCaseDecisionIssuingJudgeField;
            }
            set
            {
                this.appellateCaseDecisionIssuingJudgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseNoticeProsecutingAttorney", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=3)]
        public JudicialOfficialType[] AppellateCaseNoticeProsecutingAttorney
        {
            get
            {
                return this.appellateCaseNoticeProsecutingAttorneyField;
            }
            set
            {
                this.appellateCaseNoticeProsecutingAttorneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=4)]
        public EnforcementOfficialType[] ArrestOfficial
        {
            get
            {
                return this.arrestOfficialField;
            }
            set
            {
                this.arrestOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=5)]
        public SubjectType[] ArrestSubject
        {
            get
            {
                return this.arrestSubjectField;
            }
            set
            {
                this.arrestSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attorney", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=6)]
        public JudicialOfficialType[] Attorney
        {
            get
            {
                return this.attorneyField;
            }
            set
            {
                this.attorneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BailSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=7)]
        public SubjectType[] BailSubject
        {
            get
            {
                return this.bailSubjectField;
            }
            set
            {
                this.bailSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingEmployee", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=8)]
        public EnforcementOfficialType[] BookingEmployee
        {
            get
            {
                return this.bookingEmployeeField;
            }
            set
            {
                this.bookingEmployeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingReleaseCorrectionsAnalyst", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=9)]
        public EnforcementOfficialType[] BookingReleaseCorrectionsAnalyst
        {
            get
            {
                return this.bookingReleaseCorrectionsAnalystField;
            }
            set
            {
                this.bookingReleaseCorrectionsAnalystField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingSearchOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=10)]
        public EnforcementOfficialType[] BookingSearchOfficial
        {
            get
            {
                return this.bookingSearchOfficialField;
            }
            set
            {
                this.bookingSearchOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=11)]
        public SubjectType[] BookingSubject
        {
            get
            {
                return this.bookingSubjectField;
            }
            set
            {
                this.bookingSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingTelephoneCallSupervisingOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=12)]
        public EnforcementOfficialType[] BookingTelephoneCallSupervisingOfficial
        {
            get
            {
                return this.bookingTelephoneCallSupervisingOfficialField;
            }
            set
            {
                this.bookingTelephoneCallSupervisingOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingTransportOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=13)]
        public EnforcementOfficialType[] BookingTransportOfficial
        {
            get
            {
                return this.bookingTransportOfficialField;
            }
            set
            {
                this.bookingTransportOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseJuror", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=14)]
        public JurorType[] CaseJuror
        {
            get
            {
                return this.caseJurorField;
            }
            set
            {
                this.caseJurorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseWitness", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=15)]
        public WitnessType[] CaseWitness
        {
            get
            {
                return this.caseWitnessField;
            }
            set
            {
                this.caseWitnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute("ChargeVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute("CitationIssuingOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=18)]
        public EnforcementOfficialType[] CitationIssuingOfficial
        {
            get
            {
                return this.citationIssuingOfficialField;
            }
            set
            {
                this.citationIssuingOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CitationSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute("ConvictionSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=20)]
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
        [System.Xml.Serialization.XmlElementAttribute("CourtEventJudge", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=21)]
        public JudicialOfficialType[] CourtEventJudge
        {
            get
            {
                return this.courtEventJudgeField;
            }
            set
            {
                this.courtEventJudgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtOrderDesignatedSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=22)]
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
        [System.Xml.Serialization.XmlElementAttribute("CourtOrderIssuingJudicialOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=23)]
        public JudicialOfficialType[] CourtOrderIssuingJudicialOfficial
        {
            get
            {
                return this.courtOrderIssuingJudicialOfficialField;
            }
            set
            {
                this.courtOrderIssuingJudicialOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtOrderServiceOfficialEnforcement", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=24)]
        public EnforcementOfficialType[] CourtOrderServiceOfficialEnforcement
        {
            get
            {
                return this.courtOrderServiceOfficialEnforcementField;
            }
            set
            {
                this.courtOrderServiceOfficialEnforcementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtOrderServiceOfficialJudicial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=25)]
        public JudicialOfficialType[] CourtOrderServiceOfficialJudicial
        {
            get
            {
                return this.courtOrderServiceOfficialJudicialField;
            }
            set
            {
                this.courtOrderServiceOfficialJudicialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustodyTransferReceivingEnforcementOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=26)]
        public EnforcementOfficialType[] CustodyTransferReceivingEnforcementOfficial
        {
            get
            {
                return this.custodyTransferReceivingEnforcementOfficialField;
            }
            set
            {
                this.custodyTransferReceivingEnforcementOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustodyTransferReleasingEnforcementOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=27)]
        public EnforcementOfficialType[] CustodyTransferReleasingEnforcementOfficial
        {
            get
            {
                return this.custodyTransferReleasingEnforcementOfficialField;
            }
            set
            {
                this.custodyTransferReleasingEnforcementOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustodyTransferSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=28)]
        public SubjectType[] CustodyTransferSubject
        {
            get
            {
                return this.custodyTransferSubjectField;
            }
            set
            {
                this.custodyTransferSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnforcementOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=29)]
        public EnforcementOfficialType[] EnforcementOfficial
        {
            get
            {
                return this.enforcementOfficialField;
            }
            set
            {
                this.enforcementOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=30)]
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
        [System.Xml.Serialization.XmlElementAttribute("ForceVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=31)]
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
        [System.Xml.Serialization.XmlElementAttribute("IncidentAssistingOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=32)]
        public EnforcementOfficialType[] IncidentAssistingOfficial
        {
            get
            {
                return this.incidentAssistingOfficialField;
            }
            set
            {
                this.incidentAssistingOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentReportingOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=33)]
        public EnforcementOfficialType[] IncidentReportingOfficial
        {
            get
            {
                return this.incidentReportingOfficialField;
            }
            set
            {
                this.incidentReportingOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentResponseOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=34)]
        public EnforcementOfficialType[] IncidentResponseOfficial
        {
            get
            {
                return this.incidentResponseOfficialField;
            }
            set
            {
                this.incidentResponseOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=35)]
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
        [System.Xml.Serialization.XmlElementAttribute("IncidentSupervisingOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=36)]
        public EnforcementOfficialType[] IncidentSupervisingOfficial
        {
            get
            {
                return this.incidentSupervisingOfficialField;
            }
            set
            {
                this.incidentSupervisingOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentVictim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=37)]
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
        [System.Xml.Serialization.XmlElementAttribute("IncidentWitness", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=38)]
        public WitnessType[] IncidentWitness
        {
            get
            {
                return this.incidentWitnessField;
            }
            set
            {
                this.incidentWitnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Judge", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=39)]
        public JudicialOfficialType[] Judge
        {
            get
            {
                return this.judgeField;
            }
            set
            {
                this.judgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JudicialOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=40)]
        public JudicialOfficialType[] JudicialOfficial
        {
            get
            {
                return this.judicialOfficialField;
            }
            set
            {
                this.judicialOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Juror", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=41)]
        public JurorType[] Juror
        {
            get
            {
                return this.jurorField;
            }
            set
            {
                this.jurorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MissingPerson", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=42)]
        public MissingPersonType[] MissingPerson
        {
            get
            {
                return this.missingPersonField;
            }
            set
            {
                this.missingPersonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MissingPersonLastSeenWitness", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=43)]
        public WitnessType[] MissingPersonLastSeenWitness
        {
            get
            {
                return this.missingPersonLastSeenWitnessField;
            }
            set
            {
                this.missingPersonLastSeenWitnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertySeizureSeizingEnforcementOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=44)]
        public EnforcementOfficialType[] PropertySeizureSeizingEnforcementOfficial
        {
            get
            {
                return this.propertySeizureSeizingEnforcementOfficialField;
            }
            set
            {
                this.propertySeizureSeizingEnforcementOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegisteredOffender", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=45)]
        public RegisteredOffenderType[] RegisteredOffender
        {
            get
            {
                return this.registeredOffenderField;
            }
            set
            {
                this.registeredOffenderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegisteredSexOffender", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=46)]
        public RegisteredOffenderType[] RegisteredSexOffender
        {
            get
            {
                return this.registeredSexOffenderField;
            }
            set
            {
                this.registeredSexOffenderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SentenceSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=47)]
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
        [System.Xml.Serialization.XmlElementAttribute("ServiceCallDispatchedOfficial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=48)]
        public EnforcementOfficialType[] ServiceCallDispatchedOfficial
        {
            get
            {
                return this.serviceCallDispatchedOfficialField;
            }
            set
            {
                this.serviceCallDispatchedOfficialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeverityLevelAssignedJudge", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=49)]
        public JudicialOfficialType[] SeverityLevelAssignedJudge
        {
            get
            {
                return this.severityLevelAssignedJudgeField;
            }
            set
            {
                this.severityLevelAssignedJudgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=50)]
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
        [System.Xml.Serialization.XmlElementAttribute("Suspect", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=51)]
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
        [System.Xml.Serialization.XmlElementAttribute("VerdictIssuingJudge", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=52)]
        public JudicialOfficialType[] VerdictIssuingJudge
        {
            get
            {
                return this.verdictIssuingJudgeField;
            }
            set
            {
                this.verdictIssuingJudgeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VerdictSubject", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=53)]
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
        [System.Xml.Serialization.XmlElementAttribute("Victim", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=54)]
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
        [System.Xml.Serialization.XmlElementAttribute("VisitationSupervisingOfficialEnforcement", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=55)]
        public EnforcementOfficialType[] VisitationSupervisingOfficialEnforcement
        {
            get
            {
                return this.visitationSupervisingOfficialEnforcementField;
            }
            set
            {
                this.visitationSupervisingOfficialEnforcementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitationSupervisingOfficialJudicial", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=56)]
        public JudicialOfficialType[] VisitationSupervisingOfficialJudicial
        {
            get
            {
                return this.visitationSupervisingOfficialJudicialField;
            }
            set
            {
                this.visitationSupervisingOfficialJudicialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Witness", Namespace="http://niem.gov/niem/domains/jxdm/4.0", IsNullable=true, Order=57)]
        public WitnessType[] Witness
        {
            get
            {
                return this.witnessField;
            }
            set
            {
                this.witnessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Informant", IsNullable=true, Order=58)]
        public OtherInvolvedPersonType[] Informant
        {
            get
            {
                return this.informantField;
            }
            set
            {
                this.informantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Inmate", IsNullable=true, Order=59)]
        public SubjectType[] Inmate
        {
            get
            {
                return this.inmateField;
            }
            set
            {
                this.inmateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInvolvedPerson", IsNullable=true, Order=60)]
        public OtherInvolvedPersonType[] OtherInvolvedPerson
        {
            get
            {
                return this.otherInvolvedPersonField;
            }
            set
            {
                this.otherInvolvedPersonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parolee", IsNullable=true, Order=61)]
        public SubjectType[] Parolee
        {
            get
            {
                return this.paroleeField;
            }
            set
            {
                this.paroleeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prisoner", IsNullable=true, Order=62)]
        public SubjectType[] Prisoner
        {
            get
            {
                return this.prisonerField;
            }
            set
            {
                this.prisonerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Probationer", IsNullable=true, Order=63)]
        public SubjectType[] Probationer
        {
            get
            {
                return this.probationerField;
            }
            set
            {
                this.probationerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProtectedParty", IsNullable=true, Order=64)]
        public OtherInvolvedPersonType[] ProtectedParty
        {
            get
            {
                return this.protectedPartyField;
            }
            set
            {
                this.protectedPartyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupervisionSubject", IsNullable=true, Order=65)]
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
        [System.Xml.Serialization.XmlElementAttribute("Lessee", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=66)]
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
        [System.Xml.Serialization.XmlElementAttribute("Lessor", Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=67)]
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
    }
}
