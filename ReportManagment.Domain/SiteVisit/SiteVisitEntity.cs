using _0_Framwork.Domain;

namespace ReportManagment.Domain.SiteVisit
{
    public class SiteVisitEntity : EntityBace
    {
        public string Ip { get; private set; }

        public SiteVisitEntity(string ip)
        {
            Ip = ip;
        }
    }
}
