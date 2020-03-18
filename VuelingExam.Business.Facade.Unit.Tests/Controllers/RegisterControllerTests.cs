using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Business.Facade.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using VuelingExam.Business.Facade.Contracts;
using VuelingExam.Domain.Entities;

namespace VuelingExam.Business.Facade.Controllers.Unit.Tests
{
	[TestClass()]
	public class RegisterControllerTests
	{
		public static string[] inputRegister = null;

		[TestInitialize]
		public void Setup()
		{
			inputRegister = new string[] { "David", "Earth", "2020/12/23"};
		}

		[TestMethod()]
		public void PostTest()
		{
			using (var mock = AutoMock.GetLoose())
			{
				mock.Mock<IController<Register>>().Setup(controller => controller.Post(inputRegister)).Returns(true);
				var sut = mock.Create<IController<Register>>();

				var spected = sut.Post(inputRegister);

				mock.Mock<IController<Register>>().Verify(controller => controller.Post(inputRegister));
				Assert.IsTrue(spected);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void PostWithNullParameterThrowsNullReferenceException()
		{
			using (var mock = AutoMock.GetLoose())
			{
				//Arrange - configure the mock
				mock.Mock<IController<Register>>().Setup(repository => repository.Post(null)).Throws(new NullReferenceException());
				var sut = mock.Create<IController<Register>>();

				sut.Post(null);
			}
		}
	}
}