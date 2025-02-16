namespace WaterQualityMonitor.Models
{
    public class SensorData
    {
        public double PH { get; set; }
        public double Cl { get; set; }
        public double Tu { get; set; }
        public double EC { get; set; }

        // CSV 저장 시 필요한 텍스트 형식 반환
        public override string ToString()
        {
            return $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}, pH: {PH}, Cl: {Cl}, Tu: {Tu}, EC: {EC}";
        }
    }
}