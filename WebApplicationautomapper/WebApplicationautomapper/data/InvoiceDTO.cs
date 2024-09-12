namespace WebApplicationautomapper.data
{
    public class InvoiceDTO
    {
        public string Name { get; set; }
        //public string Descriptionofpayment { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int DiscountedPrice { get; set; } = 0;
    }
}
