using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiSign.Manager.Areas.Api.ApiModels
{
    public class GetCertificateResponse
    {
        public byte[] File { get; set; }
        public string Password { get; set; }
    }
}
