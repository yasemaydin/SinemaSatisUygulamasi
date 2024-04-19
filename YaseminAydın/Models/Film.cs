namespace YaseminAydın.Models
{
    public partial class Film
    {
        public int id { get; set; }
        public string FilmAd { get; set; }
        public TimeSpan Seans1 { get; set; }
        public TimeSpan Seans2 { get; set; }
        public TimeSpan Seans3 { get; set; }
    }
}