namespace DataShowing.Models
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
