namespace MyTravelCopilot.Models.Request
{
    public class ExpensesRequest
    {
        public ExpensesRequest(string description, int quantity, double cost, DateTime date)
        {
            ExpenseId = Guid.NewGuid();
            Description = description;
            Quantity = quantity;
            Cost = cost;
            Date = date;
        }

        public Guid ExpenseId { get; private set; }
        public string Description {  get; private set; }
        public int Quantity {  get; private set; }
        public double Cost { get; private set; }
        public DateTime Date { get; private set; }
    }
}
