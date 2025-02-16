using System;
using System.Threading.Tasks;
using WaterQualityMonitor.Models;

namespace WaterQualityMonitor.Services
{
    public class SensorService : ISensorService
    {
        private readonly Random _random = new();

        public Task<SensorData> GetSensorDataAsync()
        {
            var data = new SensorData
            {
                PH = _random.NextDouble() * (8.5 - 6.5) + 6.5,
                Cl = _random.NextDouble() * (2.0 - 0.5) + 0.5,
                Tu = _random.NextDouble() * (5.0 - 0.1) + 0.1,
                EC = _random.NextDouble() * (500 - 100) + 100
            };
            return Task.FromResult(data);
        }
    }

    public interface ISensorService
    {
        Task<SensorData> GetSensorDataAsync();
    }
}
