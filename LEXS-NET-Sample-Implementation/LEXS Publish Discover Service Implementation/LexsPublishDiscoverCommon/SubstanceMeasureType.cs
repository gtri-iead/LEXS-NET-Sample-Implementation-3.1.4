namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class SubstanceMeasureType : MeasureType
    {
        
        private DrugMeasurementCodeType substanceUnitCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DrugMeasurementCodeType SubstanceUnitCode
        {
            get
            {
                return this.substanceUnitCodeField;
            }
            set
            {
                this.substanceUnitCodeField = value;
            }
        }
    }
}
