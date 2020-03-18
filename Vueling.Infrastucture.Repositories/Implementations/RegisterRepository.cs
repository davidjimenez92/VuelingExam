using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Vueling.Infrastucture.Repositories.Utilities;
using VuelingExam.Domain.Entities;

namespace Vueling.Infrastucture.Repositories.Implementations
{
	class RegisterRepository
	{
		private readonly ILog logger = null;
		private static readonly string path = Resource.FilePath;

		private readonly RepositoryUtilities util = new RepositoryUtilities(path);

		public bool Create(Register model)
		{
			logger.Debug("Start Create method");
			if (model == null)
			{
				logger.Debug("Finish Create method");
				throw new NullReferenceException();
			}
			util.CreateFile();
			logger.Debug("Finish Create method");
			return util.AppendRegister(model);
		}
	}
}
