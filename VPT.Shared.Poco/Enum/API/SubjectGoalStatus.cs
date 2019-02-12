using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Enum.API
{
    public enum SubjectGoalStatus
    {
        /// <summary>
        /// Program is assigned to subject (1)
        /// </summary>
        Assigned = 1,

        /// <summary>
        ///  Subject is attending the program (2)
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// Subject has completed the program successfully (3)
        /// </summary>
        Completed = 3,

        /// <summary>
        ///program was terminated successfully (4)
        /// </summary>
        Terminated = 4,

        /// <summary>
        /// program was On Hold successfully (5)
        /// </summary>
        OnHold = 5,

        /// <summary>
        /// program was WaitList successfully (6)
        /// </summary>
        WaitList = 6,
        /// <summary>
        /// Program is Referred to subject (7)
        /// </summary>
        Referred = 7
    }
    public class SubjectGoalConstants
    {

        /// <summary>
        /// Not specified (1)
        /// </summary>
        public const string Assigned = "Assigned";
        /// <summary>
        /// Subject is attending the program (2)
        /// </summary>
        public const string InProgress = "In Progress";
        /// <summary>
        /// Subject has completed the program successfully (3)
        /// </summary>
        public const string Completed = "Completed";
        /// <summary>
        /// program was terminated successfully (4)
        /// </summary>
        public const string Terminated = "Terminated";
        /// <summary>
        /// program was On Hold successfully (5)
        /// </summary>
        public const string OnHold = "On Hold";
        /// <summary>
        ///program was WaitList successfully (6)
        /// </summary>
        public const string WaitList = "Waiting List";
        /// <summary>
        ///program was Referred successfully (7)
        /// </summary>
        public const string Referred = "Referred";

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)SubjectGoalStatus.Assigned:
                    return Assigned;

                case (int)SubjectGoalStatus.InProgress:
                    return InProgress;
                case (int)SubjectGoalStatus.Completed:
                    return Completed;
                case (int)SubjectGoalStatus.Terminated:
                    return Terminated;
                case (int)SubjectGoalStatus.OnHold:
                    return OnHold;
                case (int)SubjectGoalStatus.WaitList:
                    return WaitList;
                case (int)SubjectGoalStatus.Referred:
                    return Referred;
                default:
                    return null;
            }
        }

        public static SubjectGoalStatus GetByString(string state)
        {
            switch (state)
            {
                case Assigned:
                    return SubjectGoalStatus.Assigned;

                case InProgress:
                    return SubjectGoalStatus.InProgress;
                case Completed:
                    return SubjectGoalStatus.Completed;
                case Terminated:
                    return SubjectGoalStatus.Terminated;
                case OnHold:
                    return SubjectGoalStatus.OnHold;
                case WaitList:
                    return SubjectGoalStatus.WaitList;

                default:
                    return 0;
            }
        }
        public static int GetByStatus(string state)
        {
            switch (state)
            {
                case Assigned:
                    return (int)SubjectGoalStatus.Assigned;

                case InProgress:
                    return (int)SubjectGoalStatus.InProgress;
                case Completed:
                    return (int)SubjectGoalStatus.Completed;
                case Terminated:
                    return (int)SubjectGoalStatus.Terminated;
                case OnHold:
                    return (int)SubjectGoalStatus.OnHold;

                default:
                    return 0;
            }
        }
        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(SubjectGoalStatus value)
        {
            return GetByEnum((int)value);
        }
    }
}
