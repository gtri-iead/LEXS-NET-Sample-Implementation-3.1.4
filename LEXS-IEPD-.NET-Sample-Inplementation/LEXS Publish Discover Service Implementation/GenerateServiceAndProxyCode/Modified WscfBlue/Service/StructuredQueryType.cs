namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredQueryType : ComplexObjectType
    {
        
        private DigestQueryStatementType[] digestQueryStatementField;
        
        private StructuredPayloadQueryStatementType[] structuredPayloadQueryStatementField;
        
        private RoleListType roleListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DigestQueryStatement", Order=0)]
        public DigestQueryStatementType[] DigestQueryStatement
        {
            get
            {
                return this.digestQueryStatementField;
            }
            set
            {
                this.digestQueryStatementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadQueryStatement", Order=1)]
        public StructuredPayloadQueryStatementType[] StructuredPayloadQueryStatement
        {
            get
            {
                return this.structuredPayloadQueryStatementField;
            }
            set
            {
                this.structuredPayloadQueryStatementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RoleListType RoleList
        {
            get
            {
                return this.roleListField;
            }
            set
            {
                this.roleListField = value;
            }
        }
    }
}
