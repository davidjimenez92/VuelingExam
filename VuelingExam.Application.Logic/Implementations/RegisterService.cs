using System;
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

		public bool Create(string[] list)
		{
			logger.Debug("Start Create method");
			if (list == null)
			{
				logger.Debug("Finish Create method");
				throw new NullReferenceException();
			}
			var model = new Register() { Name = list[0], Planet = list[1], Date = DateTime.Parse(list[2])};
			var response = repository.Create(model);
			logger.Debug("Finish Create method");
			return response;
		}

	}
}
