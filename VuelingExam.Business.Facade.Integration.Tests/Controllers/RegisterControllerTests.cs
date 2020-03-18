using System;
using System.IO;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Business.Facade.Contracts;
using VuelingExam.Business.Facade.Integration.Tests.AutofacModule;
using VuelingExam.Domain.Entities;
using VuelingExam.Infrastucture.Repositories.Integration.Tests;
using VuelingExam.Test.Framework;

namespace VuelingExam.Business.Facade.Controllers.Unit.Tests
{
	[TestClass()]
	public class RegisterControllerTests: IoCSupportedTest<ControllerModule>
	{
		private static IController<Register> controller = null;
		private static string[] inputRegister = null;

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			XmlConfigurator.Configure();
		}

		[TestInitialize]
		public void Setup()
		{
			controller = Resolve<IController<Register>>();
			inputRegister = new string[] { "David", "Earth", new DateTime(2020, 12, 23).ToString("dd/MM/yyyy") };
		}

		[TestCleanup]
		public void TearDown()
		{
			File.Delete(Resource.FilePath);
		}
		[TestMethod()]
		public void PostTest()
		{
			var response = controller.Post(inputRegister);
			Assert.IsTrue(response);
		}
	}
}