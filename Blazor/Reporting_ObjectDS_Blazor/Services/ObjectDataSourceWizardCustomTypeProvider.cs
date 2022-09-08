using DevExpress.DataAccess.Web;
using System;
using System.Collections.Generic;

namespace Reporting_ObjectDS_Blazor
{
    public class ObjectDataSourceWizardCustomTypeProvider : IObjectDataSourceWizardTypeProvider
    {
        public IEnumerable<Type> GetAvailableTypes(string context)
        {
            return new[] { typeof(EmployeeList) };
        }
    }
}
