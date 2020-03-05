using System.Threading.Tasks;

namespace DevTalksBlazorNative.Services
{
    public interface IStorageService
    {
        Task<string> Load(string filename);
        Task Save(string filename, string content);
    }
}