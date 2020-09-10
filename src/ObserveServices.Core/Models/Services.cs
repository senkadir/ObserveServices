using System.Collections.Generic;
using System.Linq;

namespace ObserveServices.Core
{
    public class Services
    {
        public Statistics Statistics
        {
            get
            {
                return new Statistics
                {
                    TotalCount = TransientServices.Count() + ScopedServices.Count() + SingletonServices.Count(),
                    TransientCount = TransientServices.Count(),
                    ScopedCount = ScopedServices.Count(),
                    SingletonCount = SingletonServices.Count()
                };
            }
        }

        public IEnumerable<string> TransientServices { get; set; }

        public IEnumerable<string> ScopedServices { get; set; }

        public IEnumerable<string> SingletonServices { get; set; }
    }

    public class Statistics
    {
        public int TotalCount { get; set; }

        public int TransientCount { get; set; }

        public int ScopedCount { get; set; }

        public int SingletonCount { get; set; }
    }
}
