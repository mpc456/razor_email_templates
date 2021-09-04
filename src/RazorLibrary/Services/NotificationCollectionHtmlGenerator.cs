using RazorLibrary.Interfaces;
using RazorLibrary.Model;
using System.IO;
using System.Threading.Tasks;

namespace RazorLibrary.Services
{
    public class NotificationCollectionHtmlGenerator : IHtmlGenerator<NotificationCollection>
    {
        private readonly IRazorEngine _engine;

        public NotificationCollectionHtmlGenerator(IRazorEngine engine)
        {
            _engine = engine;
        }

        public async Task<string> Create(NotificationCollection model)
        {
            var template = File.ReadAllText("Templates/NotificationCollection.cshtml");
            return await _engine.CompileHtml<NotificationCollection>(template, model);
        }
    }
}
