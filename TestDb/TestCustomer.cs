namespace CrmBl.Test
{
    public class TestCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public ICollection<TestOrder> Orders { get; set; } = null!;
    }
}
