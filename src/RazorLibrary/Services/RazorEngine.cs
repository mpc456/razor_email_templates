using RazorLibrary.Interfaces;
using RazorLight;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RazorLibrary.Services
{
    public class RazorEngine : IRazorEngine
    {
        private readonly IRazorLightEngine _engine;

        public RazorEngine()
        {
            _engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(Directory.GetCurrentDirectory())
                .UseMemoryCachingProvider()
                .Build();
        }

        public async Task<string> CompileHtml<T>(string template, T model)
        {
            return await _engine.CompileRenderStringAsync<T>(GetHashString(template), template, model, null);
        }

        private static string GetHashString(string inputString)
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
