using RazorLibrary.Model;
using RazorLibrary.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RazorLibraryTest
{
    public class NotificationHtmlGeneratorTests
    {
        [Fact]
        public async Task CanCreateNotificationEmail()
        {
            var service = new NotificationHtmlGenerator();

            var model = new NotificationModel
            {
                Name = "Jone",
                Title = "Test Email",
                Content = "This is a test"
            };

            var html = await service.Create(model);

            Assert.NotNull(html);
        }
    }
}