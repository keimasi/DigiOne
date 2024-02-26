namespace ReportManagement.Application.Contracts.SiteVisit
{
    public interface ISiteVisitApplication
    {
        void LogVisitAdd(string ip);
        SiteVisitViewModel GetVisitStatistics();
    }
}
