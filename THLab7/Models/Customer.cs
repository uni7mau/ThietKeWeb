namespace THLab7.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string name { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
