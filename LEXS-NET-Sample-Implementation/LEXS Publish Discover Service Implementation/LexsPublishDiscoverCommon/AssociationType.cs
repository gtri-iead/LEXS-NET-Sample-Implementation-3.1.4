namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VisitorAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VictimWitnessAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TelephoneCallAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectWitnessAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectVictimAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalMailAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonTelephoneNumberListAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonLastSeenWitnessAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonContactAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemTelephoneNumberAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemNetworkAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemInstantMessengerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemEmailAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstantMessengerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityTelephoneNumberAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNetworkAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityInstantMessengerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityEmailAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAttachmentLinkAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailMessageAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeclarationPersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BailBondAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityTelephoneNumberAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityNetworkAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityInstantMessengerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityHashAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityEmailAddressAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectPersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentPersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedActivityAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonWorkerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonOrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonResidenceAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonItemAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonEmploymentAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonConveyanceAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonUnionAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationUnitAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationItemAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemContainerAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImmediateFamilyAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdoptedChildAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuardianAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthorityFigureAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityPersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityInvolvedPersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityOrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityItemAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class AssociationType : ComplexObjectType
    {
        
        private DateType associationBeginDateField;
        
        private DateType associationEndDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DateType AssociationBeginDate
        {
            get
            {
                return this.associationBeginDateField;
            }
            set
            {
                this.associationBeginDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public DateType AssociationEndDate
        {
            get
            {
                return this.associationEndDateField;
            }
            set
            {
                this.associationEndDateField = value;
            }
        }
    }
}
