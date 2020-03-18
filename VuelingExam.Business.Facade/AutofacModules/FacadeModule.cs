using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using VuelingExam.Application.Logic.AutofacModules;
using VuelingExam.Application.Logic.Contracts;
using VuelingExam.Application.Logic.Implementations;
using VuelingExam.Domain.Entities;

namespace VuelingExam.Business.Facade.AutofacModules
{
	public class FacadeModule: Autofac.Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<RegisterService>()
				.As<IService<Register>>();

			builder.RegisterModule(new LogginModule());
			builder.RegisterModule(new ApplicationLogicModule());

			base.Load(builder);

		}
	}
}