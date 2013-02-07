namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubstanceMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthMeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class MeasureType : ComplexObjectType
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurePointValue", typeof(MeasurePointValueType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("MeasureRangeValue", typeof(MeasureRangeValueType), IsNullable=true, Order=0)]
        public object[] Items
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
    }
}
