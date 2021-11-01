using DigiSign.Manager.Areas.Api.ApiModels;
using DigiSign.Manager.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiSign.Manager.Areas.Api.Controllers
{
    [Route("api/[controller]")]
    [Area("Api")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        protected readonly IRepository _repository;
        public CertificatesController(IRepository repository)
        {
            _repository = repository;
        }

        public GetCertificateResponse Get(int id)
        {
            var model = _repository.Read(1);
            var response = new GetCertificateResponse();
            if (model == null)
                return response;
            response.File = model.Body;
            response.Password = model.Password;
            return response;
        }
    }
}
