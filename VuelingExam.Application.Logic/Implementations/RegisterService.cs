using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Vueling.Infrastucture.Repositories.Contracts;
using VuelingExam.Application.Logic.Contracts;
using VuelingExam.Domain.Entities;

namespace VuelingExam.Application.Logic.Implementations
{
	public class RegisterService: IService<Register>
	{
		private readonly IRepository<Register> repository = null;
		private readonly ILog logger = null;

		public RegisterService()
		{
		}

		public RegisterService(ILog logger, IRepository<Register> repository)
		{
			this.logger = logger;
			this.repository = repository;
		}

		public bool Create(Register model)
		{
			if (model == null)
			{
				logger.Debug("Finish Create method");
				throw new NullReferenceException();
			}
			var response = repository.Create(model);
			logger.Debug("Finish Create method");
			return response;
		}

	}
}
