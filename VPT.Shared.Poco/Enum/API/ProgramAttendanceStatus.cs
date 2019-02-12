using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramAttendanceStatus
    {
        /// <summary>
        /// The subject behaviour was bad (1)
        /// </summary>
        Absent = 0,

        /// <summary>
        ///  The subject behaviour was appropriate (2)
        /// </summary>
        Present = 1,

        /// <summary>
        ///  The subject behaviour was good (3)
        /// </summary>
        ExcusedAbsence = 2

    }
    public class ProgramAttendanceStatusConstants
    {

        /// <summary>
        /// The subject behaviour was bad (1)
        /// </summary>
        public const string Absent = "Absent";

        /// <summary>
        ///  The subject behaviour was appropriate (2)
        /// </summary>
        public const string Present = "Present";

        /// <summary>
        ///  The subject behaviour was good (3)
        /// </summary>
        public const string ExcusedAbsence = "Excused Absence";

       

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramAttendanceStatus.Absent:
                    return Absent;

                case (int)ProgramAttendanceStatus.Present:
                    return Present;

                case (int)ProgramAttendanceStatus.ExcusedAbsence:
                    return ExcusedAbsence;

                default:
                    return null;
            }
        }

        public static ProgramAttendanceStatus GetByString(string state)
        {
            switch (state)
            {
                case Absent:
                    return ProgramAttendanceStatus.Absent;

                case Present:
                    return ProgramAttendanceStatus.Present;

                case ExcusedAbsence:
                    return ProgramAttendanceStatus.ExcusedAbsence;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ProgramAttendanceStatus value)
        {
            return GetByEnum((int)value);
        }
    }
}
