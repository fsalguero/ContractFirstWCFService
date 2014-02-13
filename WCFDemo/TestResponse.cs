namespace WCFDemo
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TestResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0, Name="result1")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Result1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1, Name="result2")]
        public short Result2;
        
        public TestResponse()
        {
        }
        
        public TestResponse(string result1, short result2)
        {
            this.Result1 = result1;
            this.Result2 = result2;
        }
    }
}
