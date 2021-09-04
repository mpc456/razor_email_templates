using RazorLibrary.Model;
using System.Threading.Tasks;

namespace RazorLibrary.Services
{
    public interface IHtmlGenerator<T>
    {
        Task<string> Create(T model);
    }
}