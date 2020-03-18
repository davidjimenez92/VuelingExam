using Autofac;
using Vueling.Infrastucture.Repositories.Contracts;
using Vueling.Infrastucture.Repositories.Implementations;
using VuelingExam.Domain.Entities;
using VuelingExam.Test.Framework;

namespace VuelingExam.Infrastucture.Repositories.Integration.Tests.AutofacModules
{
	public class RepositoryModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<RegisterRepository>().As<IRepository<Register>>();

			builder.RegisterModule<LogginModule>();

			base.Load(builder);
		}
	}
}
