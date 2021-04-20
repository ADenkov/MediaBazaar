using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public enum LocationType
    {
        ALL,
        STORE,
        HQ
    }

    public enum EmployeeArchived
    {
        ARCHIVED,
        AVAILABLE
    }

    public enum EmployeeJob
    {
        ALL,
        ADMINISTRATOR,
        MANAGER,
        FLOOR,
        WAREHOUSE
    }

    public enum EmployeeGender
    {
        ALL,
        FEMALE,
        MALE,
        UNDEFINED
    }

    public enum ProductCondition
    {
        ALL,
        OPENED,
        MISSING,
        RETURNED,
        DEFECTIVE,
        NEW
    }
}
