using Moq;
using NUnit.Framework;
using TestNinja.Interface;
using TestNinja.Mocking;

namespace TestNinjaUnitTest.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _service;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _service = new VideoService(_fileReader.Object);
        }
        
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            //Arrange
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            
            //Act
            var result = _service.ReadVideoTitle();

            //Assert
            Assert.That(result,Does.Contain("error").IgnoreCase);
        }
    }
}