using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VuelingExam.Domain.Entities;
using Autofac.Extras.Moq;
using Vueling.Infrastucture.Repositories.Contracts;

namespace Vueling.Infrastucture.Repositories.Implementations.Unit.Tests
{
	[TestClass()]
	public class RegisterRepositoryTests
	{
		public static Register inputRegister = null;

		[TestInitialize]
		public void Setup()
		{
			inputRegister = new Register() { Name = "David", Planet = "Earth", Date = DateTime.Now};
		}

		[TestMethod()]
		public void CreateTest()
		{
			using (var mock = AutoMock.GetLoose())
			{
				mock.Mock<IRepository<Register>>().Setup(repository => repository.Create(inputRegister)).Returns(true);
				var sut = mock.Create<IRepository<Register>>();

				var spected = sut.Create(inputRegister);

				mock.Mock<IRepository<Register>>().Verify(repository => repository.Create(inputRegister));
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
				mock.Mock<IRepository<Register>>().Setup(repository => repository.Create(null)).Throws(new NullReferenceException());
				var sut = mock.Create<IRepository<Register>>();

				sut.Create(null);
			}
		}
	}
}