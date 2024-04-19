namespace YaseminAydın.Models
{
    public partial class Seans
    {
        public int id { get; set; }
        public string? FilmAd { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan SeansSaat { get; set; }
        public string? Salon { get; set; }
        public string? MusteriAd { get; set; }
        public string? MusteriSoyad { get; set; }
        public string? KimlikNo { get; set; }
    }
}