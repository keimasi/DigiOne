namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public class ColleagueDiscountViewModel
    {
        public int Id { get; set; }
        public int DiscountRate { get; set; }
        public string product { get; set; }
        public bool IsRemoved { get; set; }
        public string CreateDate { get; set; }
    }
}