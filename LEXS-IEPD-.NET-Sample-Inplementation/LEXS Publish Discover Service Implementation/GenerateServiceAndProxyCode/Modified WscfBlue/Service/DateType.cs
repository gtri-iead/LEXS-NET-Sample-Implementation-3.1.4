namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class DateType : ComplexObjectType
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Date", typeof(date), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DateTime", typeof(dateTime), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Year", typeof(gYear), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("YearMonth", typeof(gYearMonth), IsNullable=true, Order=0)]
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
