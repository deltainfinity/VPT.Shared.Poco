namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The Search Types we support
    /// </summary>
    public enum ObjectType
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        None = 0,

        /// <summary>
        /// This is an job (1)
        /// </summary>
        Job = 1,

        /// <summary>
        /// This is a program (2)
        /// </summary>
        Program = 2,

        /// <summary>
        /// This is a provider (3)
        /// </summary>
        Provider = 3,

        /// <summary>
        /// This is a subject (4)
        /// </summary>
        Subject = 4,

        /// <summary>
        /// This is a agent (5)
        /// </summary>
        Agent = 5,

        /// <summary>
        /// This is a case note (6)
        /// </summary>
        CaseNote = 6,

        /// <summary>
        /// This is a student (7)
        /// </summary>
        Student = 7

    }

    /// <summary>
    /// Display names for the various Key Type's we support
    /// </summary>
    public class ObjectTypeConstants
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string None = "N/A";

        /// <summary>
        /// This is an job (1)
        /// </summary>
        public const string Job = "Job";

        /// <summary>
        /// This is a program (2)
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string Program = "Program";

        /// <summary>
        /// This is a provider (3)
        /// </summary>
        public const string Provider = "Provider";

        /// <summary>
        /// This is a subject (4)
        /// </summary>
        public const string Subject = "Subject";

        /// <summary>
        /// This is a agent (5)
        /// </summary>
        public const string Agent = "Agent";

        /// <summary>
        /// This is a case note (6)
        /// </summary>
        public const string CaseNote = "Case Note";

        /// <summary>
        /// This is a student (7)
        /// </summary>
        public const string Student = "Student";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ObjectType.None:
                    return None;

                case (int)ObjectType.Job:
                    return Job;

                case (int)ObjectType.Program:
                    return Program;

                case (int)ObjectType.Provider:
                    return Provider;

                case (int)ObjectType.Subject:
                    return Subject;

                case (int)ObjectType.Agent:
                    return Agent;

                case (int)ObjectType.CaseNote:
                    return CaseNote;

                case (int)ObjectType.Student:
                    return Student;

                default:
                    return None;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ObjectType value)
        {
            return GetByEnum((int)value);
        }
    }
}
