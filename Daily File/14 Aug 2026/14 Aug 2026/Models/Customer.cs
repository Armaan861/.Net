namespace _14_Aug_2026.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Passward { get; set; }= string.Empty;
        public string Role {  get; set; } = "Customer";

        public ICollection<CustomerProduct> CustomerProduct { get; set; } = new List<CustomerProduct>();
    }
}
