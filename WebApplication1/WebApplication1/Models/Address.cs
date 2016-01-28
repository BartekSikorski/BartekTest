namespace WebApplication1.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNo { get; set; }
        public int FlatNo { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public AddressType Type { get; set; }

        public Person Person { get; set; }
    }

    public enum AddressType
    {
        zameldowania,
        korespondencyjny
    }
}