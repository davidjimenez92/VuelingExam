using Microsoft.VisualStudio.TestTools.UnitTesting;
using VuelingExam.Application.Logic.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExam.Domain.Entities;
using VuelingExam.Application.Logic.Contracts;
using Autofac.Extras.Moq;

namespace VuelingExam.Application.Logic.Implementations.Unit.Tests
{
	[TestClass()]
	public class RegisterServiceTests
	{
		public static Register inputRegister = null;

		[TestInitialize]
		public void Setup()
		{
			inputRegister = new Register() { Name = "David", Planet = "Earth", Date = DateTime.Now };
		}

		[TestMethod()]
		public void CreateTest()
		{
			using (var mock = AutoMock.GetLoose())
			{
				mock.Mock<IService<Register>>().Setup(service => service.Create(inputRegister)).Returns(true);
				var sut = mock.Create<IService<Register>>();

				var spected = sut.Create(inputRegister);

				mock.Mock<IService<Register>>().Verify(service => service.Create(inputRegister));
				Assert.IsTrue(spected);
			}
		}

		[TestMethod]
		[ExpectedException(typeof(NullReferenceException))]
		public void CreateWithNullParameterThrowsNullReferenceException()
		{
			using (var mock = AutoMock.GetLoose())
			{
				//Arrange - configure the mock
				mock.Mock<IService<Register>>().Setup(service => service.Create(null)).Throws(new NullReferenceException());
				var sut = mock.Create<IService<Register>>();

				sut.Create(null);
			}
		}
	}
}