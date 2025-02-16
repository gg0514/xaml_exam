using System;
using System.IO;
using System.Threading.Tasks;
using WaterQualityMonitor.Models;

namespace WaterQualityMonitor.Services
{
    public class FileService : IFileService
    {
        private readonly string _filePath = "sensor_data.csv";

        public async Task SaveDataAsync(SensorData data)
        {
            string log = $"{data}\n";
            await File.AppendAllTextAsync(_filePath, log);
        }
    }

    public interface IFileService
    {
        Task SaveDataAsync(SensorData data);
    }
}
