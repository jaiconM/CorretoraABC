namespace CorretoraABC.Web.Models
{
    public class HomeViewModel
    {
        public DateTime Data { get; set; }
        public decimal FechamentoDoDia { get; set; }
        public decimal Ema9 { get; set; }
        public decimal Ema12 { get; set; }
        public decimal Ema26 { get; set; }
        public decimal Macd { get; set; }
        public decimal MacdSignal { get; set; }
        public decimal MacdHistograma { get; set; }
    }
}