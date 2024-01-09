namespace AccountManagement.Application.Contracts.Account
{
    public class AccountViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string RoleName { get; set; }
        public string CreateDate { get; set; }
    }
}