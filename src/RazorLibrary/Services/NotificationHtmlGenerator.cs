using RazorLibrary.Interfaces;
using RazorLibrary.Model;
using RazorLight;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RazorLibrary.Services
{
    public class NotificationHtmlGenerator : IHtmlGenerator<NotificationModel>
    {
        private readonly IRazorEngine _engine;

        public NotificationHtmlGenerator(IRazorEngine engine)
        {
            _engine = engine;
        }

        public async Task<string> Create(NotificationModel model)
        {
            var template = File.ReadAllText("Templates/Notification.cshtml");
            return await _engine.CompileHtml<NotificationModel>(template, model);
        }
    }
}
