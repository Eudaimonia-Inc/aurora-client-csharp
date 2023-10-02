namespace eudaimonia.datasync.application.Models.Dtos
{
    public class CryptoAggregateStream
    {
        private double? volumeWeighted;
        public string Identifier { get; set; }
        public long Time { get; set; }
        public decimal Volume { get; set; }
        public double? VolumeWeighted { get => volumeWeighted; set => volumeWeighted = value.HasValue && !double.IsNaN(value.Value) ? value : null; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
    }
}
