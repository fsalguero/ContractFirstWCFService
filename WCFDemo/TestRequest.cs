namespace WCFDemo
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0, Name="name")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1, Name="number")]
        public int Number;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2, Name="field1")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3, Name="field2")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4, Name="field3")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5, Name="field4")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field4;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6, Name="field5")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field5;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7, Name="field6")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Field6;
        
        public TestRequest()
        {
        }
        
        public TestRequest(string name, int number, string field1, string field2, string field3, string field4, string field5, string field6)
        {
            this.Name = name;
            this.Number = number;
            this.Field1 = field1;
            this.Field2 = field2;
            this.Field3 = field3;
            this.Field4 = field4;
            this.Field5 = field5;
            this.Field6 = field6;
        }
    }
}
