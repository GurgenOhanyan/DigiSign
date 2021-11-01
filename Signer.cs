using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using PdfSharp.Pdf;

namespace DigiSign
{
    public class Signer : ISigner
    {
        private IAPIClient _aPIClient;

        public Signer(IAPIClient aPIClient)
        {
            _aPIClient = aPIClient;
        }
        
        public byte[] Sign(byte[] file)
        {
            var certificate = _aPIClient.GetCertificate();
            var signedFile = new byte[6];
            //
            // Signe file
            //
            return signedFile;
        }
    }
}
