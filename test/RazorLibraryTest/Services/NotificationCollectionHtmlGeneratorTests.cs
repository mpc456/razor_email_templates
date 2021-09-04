using RazorLibrary.Model;
using RazorLibrary.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace RazorLibraryTest.Services
{
    public class NotificationCollectionHtmlGeneratorTests
    {
        [Fact]
        public async Task CanCreateHtml()
        {
            var service = new NotificationCollectionHtmlGenerator(new RazorEngine());

            var model = new NotificationCollection
            {
                Notifications = new List<NotificationModel>
                {
                    new NotificationModel
                    {
                        Name = "User 1",
                        Title = "Test Email",
                        Content = "This is a test"
                    },
                    new NotificationModel
                    {
                        Name = "User 2",
                        Title = "Test Email",
                        Content = "This is a test"
                    },
                }
            };

            var html = await service.Create(model);

            Assert.NotNull(html);
        }
    }
}
