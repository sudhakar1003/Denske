namespace DenskeCreditApp.api.Services.ResponceModel
{
    public class CreditResponceModel
    {
        public long Id { get; set; }
        public string? DecisionSelection { get; set; }
        public double ApplliedAmount { get; set; }
        public int IntrestRate { get; set; }
        public double TotalFutureDebt { get; set; }
    }
}
