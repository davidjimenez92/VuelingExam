using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Infrastucture.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Infrastucture.Repositories.Integration.Tests.AutofacModules;
using VuelingExam.Test.Framework;
using Vueling.Infrastucture.Repositories.Contracts;
using VuelingExam.Domain.Entities;
using log4net.Config;
using System.IO;
using VuelingExam.Infrastucture.Repositories.Integration.Tests;

namespace Vueling.Infrastucture.Repositories.Implementations.Unit.Tests
{
	[TestClass()]
	public class RegisterRepositoryTests: IoCSupportedTest<RepositoryModule>
	{
		private static IRepository<Register> repository = null;
		private static Register inputRegister = null;

		[ClassInitialize]
		public static void ClassInitialize(TestContext context)
		{
			XmlConfigurator.Configure();
		}

		[TestInitialize]
		public void Setup()
		{
			repository = Resolve<IRepository<Register>>();
			inputRegister = new Register() { Name = "David", Planet = "Earth", Date = new DateTime(2020, 12, 23)};
			Register register1 = new Register() { Name = "Register 1", Planet = "Planet 1", Date = DateTime.Now };
			Register register2 = new Register() { Name = "Register 2", Planet = "Planet 2", Date = DateTime.Now };
			Register register3 = new Register() { Name = "Register 3", Planet = "Planet 3", Date = DateTime.Now };
			repository.Create(register1);
			repository.Create(register2);
			repository.Create(register3);
		}

		[TestCleanup]
		public void TearDown()
		{
			File.Delete(Resource.FilePath);
		}

		[TestMethod()]
		public void CreateTest()
		{
			var response = repository.Create(inputRegister);
			Assert.IsTrue(response);
		}
	}
}