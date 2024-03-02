namespace MyTravelCopilot.Models.Response
{
    public class ExpensesResponse
    {
        public Guid ExpenseId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
    }
}
