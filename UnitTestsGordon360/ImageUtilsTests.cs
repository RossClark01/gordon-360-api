using Gordon360.Exceptions;
// using UnitTestsGordon360.Images;
using Microsoft.AspNetCore.Http;
// using Moq;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Gordon360.Models.CCT;

namespace Gordon360.Utilities.Tests
{
    public class ImageUtilsTests
    {
        // May need to use the following commented-out code later
        // private const string TestImagePath = "c:\\Users\\arabella.ji\\Source\\Repos\\gordon-cs\\gordon-360-api\\UnitTestsGordon360\\activityImage.png"; 
        private const string TestImagePath = "\\\\cftrain1\\photos\\testimage.png";
        //private const string TestImageData = "base64-encoded-image-data";
        private const string TestImageData = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABAQMAAAAl21bKAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAABlBMVEVyhbP///+V8u2BAAAAAWJLR0QB/wIt3gAAAAlwSFlzAAALEgAACxIB0t1+/AAAAAd0SU1FB+cGFxQSHPLBPCwAAAAKSURBVAjXY2AAAAACAAHiIbwzAAAAJXRFWHRkYXRlOmNyZWF0ZQAyMDIzLTA1LTI1VDE4OjQyOjAwKzAwOjAw1iuafQAAACV0RVh0ZGF0ZTptb2RpZnkAMjAxNi0wOC0xOFQxNjoxNTo0MSswMDowMLyx2xsAAAAASUVORK5CYII=";
        private const string ValidImagePath = "\\\\cftrain1\\photos\\21607000171196.jpg";
        private const string ValidImageData = "base64-encoded-image-data";
        private const string NonExistingImagePath = "path/to/non/existing/image.jpg";
        private const string DefaultImageURL = "https://example.com/default-image.jpg";
        // private const string TestImageData = UnitTestsGordon360.

        [Fact]
        public void DeleteImage_ShouldDeleteImageFromPath()
        {
            // Arrange
            File.Create(TestImagePath).Dispose(); // Create a test image file

            // Act
            ImageUtils.DeleteImage(TestImagePath);

            // Assert
            Assert.False(File.Exists(TestImagePath));
        }

        [Fact]
        public void RetrieveImageFromPath_WithValidImagePath_ShouldReturnImageData()
        {
            // Arrange
            ImageUtils.UploadImage(TestImagePath, TestImageData, ImageFormat.Png);
            
        // Act & Assert
        Assert.Throws<Exception>(() => ImageUtils.DeleteImage(imagePath));
    }

    [Fact]
    public void RetrieveImageFromPath_ExistingImagePath_ReturnsBase64Data()
    {
        // Arrange
        string imagePath = "path/to/image.jpg";
        File.Create(imagePath).Dispose();

            // Act
            string imageData = ImageUtils.RetrieveImageFromPath(TestImagePath);

            // Assert
            Assert.Equal(imageData, TestImageData);
        }

        [Fact]
        public void RetrieveImageFromPath_WithNullImagePath_ShouldReturnEmptyString()
        {
            // Act
            string imageData = ImageUtils.RetrieveImageFromPath(null);

            // Assert
            Assert.Equal(string.Empty, imageData);
        }

        [Fact]
        public void UploadImage_WithValidImageData_ShouldSaveImage()
        {
        // Arrange
        string imagePath = "path/to/save/image.jpg";
        string imageData = "base64-encoded-image-data";

            // Act
            ImageUtils.UploadImage(TestImagePath, TestImageData, ImageFormat.Jpeg);

            // Assert
            Assert.True(File.Exists(TestImagePath));
        }

        [Fact]
        public async Task UploadImageAsync_WithValidImageFile_ShouldSaveImage()
        {
            // Arrange
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(TestImageData);
            writer.Flush();
            stream.Position = 0;
            var formFile = new FormFile(stream, 0, stream.Length, "image", "image.jpg");

            // Act
            ImageUtils.UploadImageAsync(TestImagePath, formFile);

            // Assert
            await Task.Delay(500); // Wait for the file to be saved asynchronously
            Assert.True(File.Exists(TestImagePath));
        }

        /*
        [Fact]
        public async Task DownloadImageFromURL_WithValidURL_ShouldReturnImageData()
        {
            // Arrange
            string testImageURL = "https://example.com/image.jpg";
            var httpClientMock = new Mock<HttpClientWrapper>();
            httpClientMock.Setup(m => m.GetAsync(testImageURL))
                .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent(TestImageData)
                });

            // Act
            string imageData = await ImageUtils.DownloadImageFromURL(testImageURL, httpClientMock.Object);

            // Assert
            Assert.Equal(TestImageData, imageData);
        }
        */

        [Fact]
        public async Task GetImageFromPathOrDefaultFromURL_WithExistingImagePath_ShouldRetrieveImage()
        {
            // Arrange
            File.Create(TestImagePath).Dispose(); // Create a test image file

            // Act
            string imageData = await ImageUtils.GetImageFromPathOrDefaultFromURL(TestImagePath, DefaultImageURL);

            // Assert
            Assert.Equal(TestImageData, imageData);
        }

        /*
        [Fact]
        public async Task GetImageFromPathOrDefaultFromURL_WithNonExistingImagePath_ShouldDownloadDefaultImage()
        {
            // Arrange
            var httpClientMock = new Mock<HttpClientWrapper>();
            httpClientMock.Setup(m => m.GetAsync(DefaultImageURL))
                .ReturnsAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent(TestImageData)
                });

            // Act
            string imageData = await ImageUtils.GetImageFromPathOrDefaultFromURL(NonExistingImagePath, DefaultImageURL, httpClientMock.Object);

            // Assert
            Assert.Equal(TestImageData, imageData);
        }
        */

        [Fact]
        public void GetImageFormat_WithValidImageFile_ShouldReturnFormatExtensionAndFormat()
        {
            // Arrange
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream);
            writer.Write(TestImageData);
            writer.Flush();
            stream.Position = 0;
            var formFile = new FormFile(stream, 0, stream.Length, "image", "image.jpg");

            // Act
            var (formatExtension, format) = ImageUtils.GetImageFormat(formFile);

            // Assert
            Assert.Equal("jpg", formatExtension);
            Assert.Equal(ImageFormat.Jpeg, format);
        }

        [Fact]
        public void GetImageFormat_WithInvalidImageFile_ShouldThrowBadInputException()
        {
            // Arrange
            using var stream = new MemoryStream();
            var formFile = new FormFile(stream, 0, stream.Length, "image", "image.txt");

            // Act & Assert
            Assert.Throws<BadInputException>(() => ImageUtils.GetImageFormat(formFile));
        }

        [Fact]
        public void GetImageFormat_WithValidBase64Image_ShouldReturnFormatExtensionAndFormat()
        {
            // Arrange
            string base64Image = $"data:image/jpeg;base64,{TestImageData}";

            // Act
            var (formatExtension, format, imageData) = ImageUtils.GetImageFormat(base64Image);

            // Assert
            Assert.Equal("jpeg", formatExtension);
            Assert.Equal(ImageFormat.Jpeg, format);
            Assert.Equal(TestImageData, imageData);
        }

        [Fact]
        public void GetImageFormat_WithInvalidBase64Image_ShouldThrowBadInputException()
        {
            // Arrange
            string base64Image = "invalid-base64-image";

            // Act & Assert
            Assert.Throws<BadInputException>(() => ImageUtils.GetImageFormat(base64Image));
        }
    }
}
