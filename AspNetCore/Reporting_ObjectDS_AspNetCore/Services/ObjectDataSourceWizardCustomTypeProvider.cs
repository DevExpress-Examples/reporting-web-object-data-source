using DevExpress.DataAccess.Web;
using System;
using System.Collections.Generic;

namespace Reporting_ObjectDS_AspNetCore.Services {
    public class ObjectDataSourceWizardCustomTypeProvider : IObjectDataSourceWizardTypeProvider {
        public IEnumerable<Type> GetAvailableTypes(string context) {
            return new[] { typeof(EmployeeList) };
        }
    }
}
