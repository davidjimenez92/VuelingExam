using Autofac;
using Vueling.Infrastucture.Repositories.Contracts;
using Vueling.Infrastucture.Repositories.Implementations;
using VuelingExam.Domain.Entities;

namespace VuelingExam.Application.Logic.AutofacModules
{
	public class ApplicationLogicModule: Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder
				.RegisterType<RegisterRepository>()
				.As<IRepository<Register>>();

			base.Load(builder);

		}
	}
}
