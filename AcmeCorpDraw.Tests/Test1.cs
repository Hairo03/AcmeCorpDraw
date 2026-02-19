using AcmeCorpDraw.Domain.DTOs;
using AcmeCorpDraw.Domain.DTOs.Validation;
using AcmeCorpDraw.Domain.Interfaces;
using AcmeCorpDraw.Domain.Models;
using AcmeCorpDraw.WebApp.Services;
using Moq;
using System.ComponentModel.DataAnnotations;

namespace AcmeCorpDraw.Tests
{
    [TestClass]
    public sealed class SubmissionServiceTests
    {
        private Mock<ISubmissionRepository> _mockSubmissionRepo;
        private Mock<ISerialNumberRepository> _mockSerialRepo;
        private SubmissionService _submissionService;

        [TestInitialize]
        public void Setup()
        {
            _mockSubmissionRepo = new Mock<ISubmissionRepository>();
            _mockSerialRepo = new Mock<ISerialNumberRepository>();
            _submissionService = new SubmissionService(_mockSubmissionRepo.Object, _mockSerialRepo.Object);
        }

        [TestMethod]
        public async Task CreateSubmissionAsync_WithValidData_ReturnsSuccess()
        {
            // Arrange
            _mockSerialRepo.Setup(x => x.IsValidAsync(It.IsAny<string>())).ReturnsAsync(true);
            _mockSubmissionRepo.Setup(x => x.CountBySerialAsync(It.IsAny<string>())).ReturnsAsync(0);
            _mockSubmissionRepo.Setup(x => x.AddAsync(It.IsAny<Submission>())).Returns(Task.CompletedTask);

            var dto = new SubmissionDTO
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                SerialNumber = "ACME-0JIE-XYX2-N0AT",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            // Act
            var result = await _submissionService.CreateSubmissionAsync(dto);

            // Assert
            Assert.IsTrue(result.Success, "Expected submission to succeed");
            Assert.IsNull(result.ErrorMessage, "Expected no error message");
            Assert.IsNotNull(result.Submission, "Expected submission object to be returned");
            Assert.AreEqual(dto.FirstName, result.Submission.FirstName);
            Assert.AreEqual(dto.LastName, result.Submission.LastName);
            Assert.AreEqual(dto.Email, result.Submission.Email);
            Assert.AreEqual(dto.SerialNumber, result.Submission.SerialNumber);
            Assert.AreEqual(dto.DateOfBirth, result.Submission.DateOfBirth);
        }

        [TestMethod]
        public async Task CreateSubmissionAsync_WithInvalidSerial_ReturnsError()
        {
            // Arrange
            _mockSerialRepo.Setup(x => x.IsValidAsync(It.IsAny<string>())).ReturnsAsync(false);

            var dto = new SubmissionDTO
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                SerialNumber = "INVALID-SERIAL",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            // Act
            var result = await _submissionService.CreateSubmissionAsync(dto);

            // Assert
            Assert.IsFalse(result.Success, "Expected submission to fail");
            Assert.AreEqual("Invalid serial number.", result.ErrorMessage);
            Assert.IsNull(result.Submission, "Expected no submission object");
        }

        [TestMethod]
        public async Task GetAllSubmissionsAsync_ReturnsAllSubmissions()
        {
            // Arrange
            var expectedSubmissions = new List<Submission>
            {
                new Submission
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@example.com",
                    SerialNumber = "ACME-0JIE-XYX2-N0AT",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    SubmittedAt = DateTime.UtcNow
                },
                new Submission
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane@example.com",
                    SerialNumber = "ACME-0OIF-73CP-X5VS",
                    DateOfBirth = new DateTime(1995, 5, 15),
                    SubmittedAt = DateTime.UtcNow
                }
            };

            _mockSubmissionRepo.Setup(x => x.GetAllAsync()).ReturnsAsync(expectedSubmissions);

            // Act
            var result = await _submissionService.GetAllSubmissionsAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }

    [TestClass]
    public sealed class MinimumAgeAttributeTests
    {
        [TestMethod]
        public void MinimumAge_WithAgeOver18_PassesValidation()
        {
            // Arrange
            var attribute = new MinimumAgeAttribute(18);
            var dateOfBirth = DateTime.Today.AddYears(-25);
            var validationContext = new ValidationContext(new object());

            // Act
            var result = attribute.GetValidationResult(dateOfBirth, validationContext);

            // Assert
            Assert.AreEqual(ValidationResult.Success, result);
        }

        [TestMethod]
        public void MinimumAge_WithAgeUnder18_FailsValidation()
        {
            // Arrange
            var attribute = new MinimumAgeAttribute(18);
            var dateOfBirth = DateTime.Today.AddYears(-17);
            var validationContext = new ValidationContext(new object());

            // Act
            var result = attribute.GetValidationResult(dateOfBirth, validationContext);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(ValidationResult.Success, result);
            Assert.AreEqual("You must be at least 18 years old to enter the draw.", result.ErrorMessage);
        }
    }
}
