namespace WCFDemo
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class DemoService : IDemoService
    {
        
        public virtual TestResponse Test(TestRequest request)
        {
            return new TestResponse { Result1 = "Successful" };
        }
    }
}
