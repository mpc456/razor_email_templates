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
    public class NotificationHtmlGenerator
    {
        public async Task<string> Create(NotificationModel model)
        {
            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(Directory.GetCurrentDirectory())
                .UseMemoryCachingProvider()
                .Build();

            var template = File.ReadAllText("Templates/Notification.cshtml");

            return await engine.CompileRenderStringAsync<NotificationModel>(GetHashString(template), template, model, null);
        }

        public static string GetHashString(string inputString)
        {
            var sb = new StringBuilder();
            var hashbytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(inputString));
            foreach (byte b in hashbytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
