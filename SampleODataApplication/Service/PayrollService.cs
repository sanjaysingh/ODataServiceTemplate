using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using SampleODataApplication.Data;

namespace SampleODataApplication
{
    /// <summary>
    /// Payroll service class.
    /// </summary>
    [JSONPSupportBehavior()]
    public class PayrollService : DataService<PayrollDb>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Employees", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Projects", EntitySetRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }
    }
}
