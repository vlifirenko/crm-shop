namespace CrmBl.Test
{
    public class TestOrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public TestOrder Order { get; set; } = null!;
        public TestProduct Product { get; set; } = null!;
    }
}
