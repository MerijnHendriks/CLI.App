/* CertUtil.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace App.Utils
{
    public class CertUtil
    {
        public static void MakeSelfSigned(string name = "foobar", string password = "P@55w0rd", int years = 5)
        {
            var ecdsa = ECDsa.Create(); // generate asymmetric key pair
            var req = new CertificateRequest($"cn={name}", ecdsa, HashAlgorithmName.SHA256);
            var cert = req.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(years));

            // Create PFX (PKCS #12) with private key
            File.WriteAllBytes("cert.pfx", cert.Export(X509ContentType.Pfx, password));

            // Create Base 64 encoded CERT (public key only)
            var publicKey = "-----BEGIN CERTIFICATE-----\r\n"
                          + Convert.ToBase64String(cert.Export(X509ContentType.Cert), Base64FormattingOptions.InsertLineBreaks)
                          +"\r\n-----END CERTIFICATE-----";

            File.WriteAllText("cert.cert", publicKey);
        }
    }
}
