using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DevTalksBlazorNative.Services
{
    public class StorageService : IStorageService
    {
        public async Task<string> Load(string filename)
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, filename);

            if (!File.Exists(filePath)) return null;

            return File.ReadAllText(filePath);
        }

        public async Task Save(string filename, string content)
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, filename);
            File.WriteAllText(filePath, content);
        }
    }
}
