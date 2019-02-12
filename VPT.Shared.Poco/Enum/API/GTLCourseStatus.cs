namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The GTL Course Status we support
    /// </summary>
    public enum GTLCourseStatus
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Course is assigned to subject (1)
        /// </summary>
        Assigned = 1,        

        /// <summary>
        /// Subject has completed the course successfully (2)
        /// </summary>
        Completed = 2 
    }


    /// <summary>
    /// Display names for the various Course Status we support
    /// </summary>
    public class CourseStatusConstants
    {
        /// <summary>
        /// Not specified (0)
        /// </summary>
        public const string Unknown = "Unknown"; 

        /// <summary>
        /// Course is assigned to subject (1)
        /// </summary>
        public const string Assigned = "Assigned";
        
        /// <summary>
        /// Subject has completed the course successfully (2)
        /// </summary>
        public const string Completed = "Completed";
        

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)GTLCourseStatus.Unknown:
                    return Unknown;

                case (int)GTLCourseStatus.Assigned:
                    return Assigned;

                case (int)GTLCourseStatus.Completed:
                    return Completed;

                default:
                    return Unknown;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(GTLCourseStatus value)
        {
            return GetByEnum((int)value);
        }
    }

}
