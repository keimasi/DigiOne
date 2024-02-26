using _0_Framwork.Infrastructure;
using ReportManagment.Domain.SiteVisit;

namespace ReportManagement.Infrastructure.EFCore.Repository
{
    public class SiteVisitRepository : RepositoryBace<int, SiteVisitEntity>, ISiteVisitRepository
    {
        private readonly ReportContext _context;

        public SiteVisitRepository(ReportContext context) : base(context)
        {
            _context = context;
        }
    }
}
