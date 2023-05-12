namespace CrmBl.Test
{
    public class TestOrder
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public TestCustomer Customer { get; set; } = null!;
        public ICollection<TestOrderDetail> OrderDetails { get; set; } = null!;
    }
}
