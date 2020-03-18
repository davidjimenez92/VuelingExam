using Autofac;
using VuelingExam.Business.Facade.Contracts;
using VuelingExam.Business.Facade.Controllers;
using VuelingExam.Domain.Entities;
using VuelingExam.Test.Framework;

namespace VuelingExam.Business.Facade.Integration.Tests.AutofacModule
{
	public class ControllerModule: Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<RegisterController>().As<IController<Register>>();

			builder.RegisterModule<LogginModule>();

			base.Load(builder);
		}
	}
}
