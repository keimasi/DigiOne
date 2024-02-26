using System;
using System.Linq;
using ReportManagement.Application.Contracts.SiteVisit;
using ReportManagment.Domain.SiteVisit;

namespace ReportManagement.Application
{
    public class SiteVisitApplication : ISiteVisitApplication
    {
        private readonly ISiteVisitRepository _siteVisitRepository;

        public SiteVisitApplication(ISiteVisitRepository siteVisitRepository)
        {
            _siteVisitRepository = siteVisitRepository;
        }

        public void LogVisitAdd(string ip)
        {
            var last24Hours = DateTime.UtcNow.AddHours(-24);

            var ipExists = _siteVisitRepository.GetAll().Any(v => v.Ip == ip && v.CreateDate >= last24Hours);

            if (!ipExists)
            {
                var siteVisit = new SiteVisitEntity(ip);

                _siteVisitRepository.Create(siteVisit);
                _siteVisitRepository.Save();
            }
        }

        public SiteVisitViewModel GetVisitStatistics()
        {
            var today = DateTime.UtcNow.Date;
            var yesterday = today.AddDays(-1);

            var Statistics = _siteVisitRepository.GetAll();

            return new SiteVisitViewModel
            {
                VisitToday = Statistics.Count(x => x.CreateDate >= today),
                VisitYesterday = Statistics.Count(x => x.CreateDate >= yesterday && x.CreateDate < today),
                VisitTotal = Statistics.Count
            };
        }
    }
}
