using Autofac.Extras.Moq;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Moq;
using NUnit.Framework;
using Shouldly;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace SamTech.Exam.Framework.Tests
{
    [ExcludeFromCodeCoverage]
    public class StudentServiceTests
    {
        private AutoMock _mock;
        private Mock<IStudentRepository> _studentRepositoryMock;
        private Mock<IStudentUnitOfWork> _studentUnitOfWorkMock;
        private IStudentService _studentService;

        [OneTimeSetUp]
        public void ClassSetup()
        {
            _mock = AutoMock.GetLoose();
        }

        [OneTimeTearDown]
        public void ClassCleanUp()
        {
            _mock?.Dispose();
        }

        [SetUp]
        public void Setup()
        {
            _studentRepositoryMock = _mock.Mock<IStudentRepository>();
            _studentUnitOfWorkMock = _mock.Mock<IStudentUnitOfWork>();
            _studentService = _mock.Create<StudentService>();
        }

        [TearDown]
        public void Clean()
        {
            _studentRepositoryMock.Reset();
            _studentUnitOfWorkMock.Reset();
        }

        [Test]
        public void AddStudent_StudentAlreadyExists_ThrowsException()
        {
            //Arrange
            var student = new Student
            {
                Id = 1,
                Email = "sam@gmail.com",
                Name = "Shamim",
                Username = "sam"
            };

            var studentToMatch = new Student
            {
                Name = "Shamim"
            };

            _studentUnitOfWorkMock.Setup(x => x.StudentRepository)
                .Returns(_studentRepositoryMock.Object);

            _studentRepositoryMock.Setup(x => x.GetCount(
                It.Is<Expression<Func<Student, bool>>>(y => y.Compile()(studentToMatch))))
                .Returns(1).Verifiable();

            //Act
            Should.Throw<DuplicationException>(() =>
                _studentService.AddStudent(student)
            );

            //Assert
            _studentUnitOfWorkMock.VerifyAll();
        }
    }
}