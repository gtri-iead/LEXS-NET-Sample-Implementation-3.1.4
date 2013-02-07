namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class LongitudeCoordinateType : ComplexObjectType
    {
        
        private LongitudeDegreeType longitudeDegreeValueField;
        
        private AngularMinuteType longitudeMinuteValueField;
        
        private AngularSecondType longitudeSecondValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public LongitudeDegreeType LongitudeDegreeValue
        {
            get
            {
                return this.longitudeDegreeValueField;
            }
            set
            {
                this.longitudeDegreeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public AngularMinuteType LongitudeMinuteValue
        {
            get
            {
                return this.longitudeMinuteValueField;
            }
            set
            {
                this.longitudeMinuteValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public AngularSecondType LongitudeSecondValue
        {
            get
            {
                return this.longitudeSecondValueField;
            }
            set
            {
                this.longitudeSecondValueField = value;
            }
        }
    }
}
