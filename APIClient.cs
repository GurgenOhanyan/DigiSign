using DigiSign.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DigiSign
{
    public class APIClient : IAPIClient
    {
        private static HttpClient httpClient;

        private string apiKey;
        public APIClient(string baseUrl, string apiKey)
        {
            httpClient = new HttpClient() { BaseAddress = new Uri(baseUrl) };
        }
        public async Task<X509Certificate> GetCertificate()
        {
            try
            {
                var response = await httpClient.GetStringAsync("api/getcertificate");
                var model = JsonConvert.DeserializeObject<GetCertficateResponse>(response);
                var certificate = new X509Certificate(model.File, model.Password);
                return certificate;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
