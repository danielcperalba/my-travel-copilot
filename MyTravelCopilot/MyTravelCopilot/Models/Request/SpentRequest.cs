namespace MyTravelCopilot.Models.Request
{
    public class SpentRequest
    {
        public SpentRequest(string description, int quantity, double cost, DateTime date)
        {
            SpentId = Guid.NewGuid();
            Description = description;
            Quantity = quantity;
            Cost = cost;
            Date = date;
        }

        public Guid SpentId { get; private set; }
        public string Description {  get; private set; }
        public int Quantity {  get; private set; }
        public double Cost { get; private set; }
        public DateTime Date { get; private set; }
    }
}
