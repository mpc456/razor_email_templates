using System.Threading.Tasks;

namespace RazorLibrary.Interfaces
{
    public interface IRazorEngine
    {
        Task<string> CompileHtml<T>(string template, T model);
    }
}