using DevExpress.DataAccess.Web;
using Reporting_ObjectDS_AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
public class CustomObjectDataSourceConstructorFilterService : IObjectDataSourceConstructorFilterService
{
    public IEnumerable<ConstructorInfo> Filter(Type dataSourceType, IEnumerable<ConstructorInfo> constructors)
    {
        if (dataSourceType == typeof(EmployeeList)) 
            return constructors;
        else
            return constructors.Where(x => x.GetParameters().Length > 0);
    }
}
