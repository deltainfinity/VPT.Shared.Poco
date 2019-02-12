using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramSessionBehavior
    {
        /// <summary>
        /// The subject behaviour was bad (1)
        /// </summary>
        Bad = 1,

        /// <summary>
        ///  The subject behaviour was appropriate (2)
        /// </summary>
        Appropriate = 2,

        /// <summary>
        ///  The subject behaviour was good (3)
        /// </summary>
        Good = 3

    }
    public class ProgramSessionBehaviorConstants
    {

        /// <summary>
        /// The subject behaviour was bad (1)
        /// </summary>
        public const string Bad = "Bad";

        /// <summary>
        ///  The subject behaviour was appropriate (2)
        /// </summary>
        public const string Appropriate = "Appropriate";

        /// <summary>
        ///  The subject behaviour was good (3)
        /// </summary>
        public const string Good = "Good";

       

        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramSessionBehavior.Bad:
                    return Bad;

                case (int)ProgramSessionBehavior.Appropriate:
                    return Appropriate;

                case (int)ProgramSessionBehavior.Good:
                    return Good;

                default:
                    return null;
            }
        }

        public static ProgramSessionBehavior GetByString(string state)
        {
            switch (state)
            {
                case Bad:
                    return ProgramSessionBehavior.Bad;

                case Appropriate:
                    return ProgramSessionBehavior.Appropriate;

                case Good:
                    return ProgramSessionBehavior.Good;

                default:
                    return 0;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ProgramSessionBehavior value)
        {
            return GetByEnum((int)value);
        }
    }
}
