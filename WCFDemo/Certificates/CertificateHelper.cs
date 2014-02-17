using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Web.Hosting;
using System.IO;

namespace WCFDemo.Certificates
{
    static class CertificateHelper
    {
        /// <summary>
        /// Load a certificate from the specified file.
        /// The filename can contains the password when using this format: file|password.
        /// The file can be a relative file or an absolute file.
        /// Return null if the file is not specified.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
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
    }
}
