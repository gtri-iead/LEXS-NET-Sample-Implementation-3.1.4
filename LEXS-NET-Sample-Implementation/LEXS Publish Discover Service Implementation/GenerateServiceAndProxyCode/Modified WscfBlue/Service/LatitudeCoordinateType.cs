namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class LatitudeCoordinateType : ComplexObjectType
    {
        
        private LatitudeDegreeType latitudeDegreeValueField;
        
        private AngularMinuteType latitudeMinuteValueField;
        
        private AngularSecondType latitudeSecondValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public LatitudeDegreeType LatitudeDegreeValue
        {
            get
            {
                return this.latitudeDegreeValueField;
            }
            set
            {
                this.latitudeDegreeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public AngularMinuteType LatitudeMinuteValue
        {
            get
            {
                return this.latitudeMinuteValueField;
            }
            set
            {
                this.latitudeMinuteValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public AngularSecondType LatitudeSecondValue
        {
            get
            {
                return this.latitudeSecondValueField;
            }
            set
            {
                this.latitudeSecondValueField = value;
            }
        }
    }
}
