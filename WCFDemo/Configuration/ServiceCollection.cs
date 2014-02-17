using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Web.Hosting;
using System.IO;

namespace WCFDemo.Configuration
{
    public class ServiceElement : ConfigurationElement
    {
        /// <summary>
        /// Type name of the service
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        /// <summary>
        /// Server certificate file (.pfx file).
        /// Can be an absolute or relative file.
        /// If the file require the password you can use this format: file|password .
        /// </summary>
        [ConfigurationProperty("serverCertificate", IsRequired = false)]
        public string ServerCertificate
        {
            get { return (string)this["serverCertificate"]; }
            set { this["serverCertificate"] = value; }
        }

        /// <summary>
        /// List of client certificates used for authentication.
        /// Each certificate file must be separated by a comma.
        /// </summary>
        [ConfigurationProperty("clientCertificates", IsRequired = false)]
        public string ClientCertificates
        {
            get { return (string)this["clientCertificates"]; }
            set { this["clientCertificates"] = value; }
        }

        public X509Certificate2 GetServerCertificate()
        {
            //Load the certificate from a file
            return LoadFromFile(ServerCertificate);
        }

        public static X509Certificate2 LoadFromFile(string file)
        {
            if (file != null)
                file = file.Trim();

            if (string.IsNullOrEmpty(file))
                return null;

            string[] parts = file.Split('|');
            if (parts.Length > 2)
                throw new ArgumentException("Certificate file name format not valid, but be in the format 'file|password'");

            var path = parts[0].Trim();
            string fullPath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, path);
            string password = string.Empty;
            if (parts.Length == 2)
                password = parts[1];

            return new X509Certificate2(fullPath, password);
        }

        public IEnumerable<X509Certificate2> GetClientCertificates()
        {
            foreach (string file in ClientCertificates.Split(','))
            {
                string fullpath = file.Trim();

                if (string.IsNullOrEmpty(fullpath))
                    continue;

                fullpath = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, fullpath);

                //Load the certificate from a file
                X509Certificate2 certificate = new X509Certificate2(fullpath, string.Empty);

                yield return certificate;
            }
        }
    }

    public class ServiceCollection : ConfigurationElementCollection
    {
        public ServiceElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as ServiceElement;
            }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                this.BaseAdd(index, value);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ServiceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ServiceElement)element).Name;
        }

        public ServiceElement GetElementByKey(string serviceName)
        {
            foreach (ServiceElement service in this)
            {
                if (string.Equals(serviceName, service.Name, StringComparison.InvariantCultureIgnoreCase))
                    return service;
            }

            return null;
        }
    }
}
