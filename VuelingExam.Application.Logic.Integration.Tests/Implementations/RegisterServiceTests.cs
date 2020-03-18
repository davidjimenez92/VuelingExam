using System;
using System.IO;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Application.Logic.Contracts;
using VuelingExam.Domain.Entities;
using VuelingExam.Infrastucture.Repositories.Integration.Tests;
using VuelingExam.Infrastucture.Repositories.Integration.Tests.AutofacModules;
using VuelingExam.Test.Framework;

namespace VuelingExam.Application.Logic.Implementations.Unit.Tests
{
	[TestClass()]
	public class RegisterServiceTests : IoCSupportedTest<RepositoryModule>
	{
		private static IService<Register> service = null;
		private static string[] inputRegister = null;

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			XmlConfigurator.Configure();
		}

		[TestInitialize]
		public void Setup()
		{
			service = Resolve<IService<Register>>();
			inputRegister = new string[] {"David", "Earth", new DateTime(2020, 12, 23).ToString("dd/MM/yyyy") };
		}

		[TestCleanup]
		public void TearDown()
		{
			File.Delete(Resource.FilePath);
		}

		[TestMethod()]
		public void CreateTest()
		{
			var response = service.Create(inputRegister);
			Assert.IsTrue(response);
		}
	}
}