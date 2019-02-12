using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Enum.Accounts
{
    public enum CommCenterSearchBy
    {
        FirstName = 0,
        LastName = 1,
        SORID = 2,
        All =3
    }

    public class CommCenterSearchByConstant
    {
        public const string FirstName = "FirstName";
        public const string LastName = "LastName";

        public static string GetByEnum(CommCenterSearchBy value)
        {
            switch (value)
            {
                case CommCenterSearchBy.FirstName:
                    return FirstName;

                case CommCenterSearchBy.LastName:
                    return LastName;
                default:
                    return FirstName;
            }
        }

    }
}
