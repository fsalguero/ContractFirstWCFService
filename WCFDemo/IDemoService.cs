namespace WCFDemo
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="IDemoService")]
    public interface IDemoService
    {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message TestRequest does not match the default value (http://tempuri.org)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org:testIn")]
        [System.ServiceModel.FaultContractAttribute(typeof(ErrorMessage), Action="http://tempuri.org:testIn", Name="ErrorMessage", Namespace="http://tempuri.org/")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        TestResponse Test(TestRequest request);
    }
}
