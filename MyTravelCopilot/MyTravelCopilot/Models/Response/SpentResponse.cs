namespace MyTravelCopilot.Models.Response
{
    public class SpentResponse
    {
        public Guid SpentId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
    }
}
