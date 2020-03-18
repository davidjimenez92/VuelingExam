using System;
using System.Collections.Generic;
using System.Web.Http;
using log4net;
using VuelingExam.Application.Logic.Contracts;
using VuelingExam.Business.Facade.Contracts;
using VuelingExam.Domain.Entities;

namespace VuelingExam.Business.Facade.Controllers
{
    public class RegisterController : ApiController, IController<Register>
    {
        private readonly ILog logger = null;
        private readonly IService<Register> service = null;

        public RegisterController()
        {
        }

        public RegisterController(ILog logger, IService<Register> service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpPost]
        public bool Post(string[] list)
        {
            logger.Error("Start Post method");
            var response = service.Create(list);
            logger.Error("Finish Post method");
            return response;
        }
    }
}
