using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;

namespace WCFDemo.Certificates
{
    /// <summary>
    /// A class that derive from the ServiceHost system class to automatically set the 
    /// server certificate used for service authentication.
    /// This class set the Credentials.ServiceCertificate.Certificate property override any certificate configuration.
    /// Consider anyway that you must correctly configure the binding security.
    /// </summary>
    public class CertificateServiceHost : ServiceHost
    {
        public CertificateServiceHost(Type serviceType, Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
        }

        protected override void ApplyConfiguration()
        {
            base.ApplyConfiguration();

            //Check if there is a valid configuration section
            Configuration.Section section = Configuration.Section.GetSection();
            if (section == null || section.Services == null)
                return;

            //Check if there is a valid configuration for this service
            Configuration.ServiceElement element = section.Services.GetElementByKey(Description.Name);
            if (element == null)
                return;

            X509Certificate2 serverCertificate = element.GetServerCertificate();

            //Set the server certificate
            if (serverCertificate != null)
                this.Credentials.ServiceCertificate.Certificate = serverCertificate;

            //Set the client certificates and the validator
            if (string.IsNullOrEmpty(element.ClientCertificates) == false)
            {
                X509ClientCertificateAuthentication authentication =
                            this.Credentials.ClientCertificate.Authentication;

                authentication.CertificateValidationMode =
                    System.ServiceModel.Security.X509CertificateValidationMode.Custom;

                authentication.CustomCertificateValidator =
                    new CustomCertificateValidator(element.GetClientCertificates());
            }
        }
    }
}