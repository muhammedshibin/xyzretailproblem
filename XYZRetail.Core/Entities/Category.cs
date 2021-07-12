namespace XYZRetail.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public decimal SalesTax { get; set; }
        public decimal ImportTax { get; set; }
    }
}