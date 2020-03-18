using Autofac;
using VuelingExam.Application.Logic.Contracts;
using VuelingExam.Application.Logic.Implementations;
using VuelingExam.Domain.Entities;
using VuelingExam.Test.Framework;

namespace VuelingExam.Application.Logic.Integration.Tests.AutofacModules
{
	public class ApplicationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<RegisterService>().As<IService<Register>>();

			builder.RegisterModule<LogginModule>();

			base.Load(builder);
		}
	}
}
