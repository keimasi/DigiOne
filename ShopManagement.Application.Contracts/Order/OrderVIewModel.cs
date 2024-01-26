namespace ShopManagement.Application.Contracts.Order
{
    public class OrderVIewModel
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayAmount { get;  set; }
        public bool IsPaid { get; set; }
        public bool IsCanceled { get; set; }
        public string IssueTracking { get; set; }
        public long RefId { get; set; }
        public string CreateDate { get; set; }
    }
}
