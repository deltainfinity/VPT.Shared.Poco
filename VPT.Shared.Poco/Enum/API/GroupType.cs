namespace VPT.Shared.Poco.Enum.API
{
    public enum GroupType
    {
        
        /// <summary>
        /// The group type is agent (1)
        /// </summary>
        Agent = 1,

        /// <summary>
        ///  The group type is subject (2)
        /// </summary>
        Subject = 2,

        /// <summary>
        ///  The group type is student (2)
        /// </summary>
        Student = 3,

        /// <summary>
        ///  The group type is Manager (4)
        /// </summary>
        Manager = 4



    }
    public class GroupConstants
    {
      
        /// <summary>
        /// The group type is agent (1)
        /// </summary>
        public const string Agent = "Agent";

        /// <summary>
        ///  The group type is subject (2)
        /// </summary>
        public const string Subject = "Subject";

        /// <summary>
        ///  The group type is student (3)
        /// </summary>
        public const string Student = "Student";

        /// <summary>
        ///  The group type is Manager (4)
        /// </summary>
        public const string Manager = "Manager";


        public static string GetByEnum(int value)
    {
        switch (value)
        {
            case (int)GroupType.Agent:
                return Agent;

            case (int)GroupType.Subject:
                return Subject;

           case (int)GroupType.Student:
                return Student;
           
           case (int)GroupType.Manager:
                return Manager;

           default:
                return null;
        }
    }

    public static GroupType GetByString(string state)
    {
        switch (state)
        {
            case Agent:
                return GroupType.Agent;

            case Subject:
                    return GroupType.Subject;

            case Student:
                    return GroupType.Student;

            case Manager:
                    return GroupType.Manager;

                default:
                    return 0;
        }
    }

    /// <summary>
    /// Get the display string for an enum by it's value in enum form
    /// </summary>
    /// <param name="value">The enum value in enum form</param>
    /// <returns>The display string for the value or the default if one cannot be found</returns>
    public static string GetByEnum(GroupType value)
    {
        return GetByEnum((int)value);
    }
    }
}
