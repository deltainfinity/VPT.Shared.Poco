namespace VPT.Shared.Poco.Enum.API
{
    /// <summary>
    /// The tag types we support
    /// </summary>
    public enum NoteType
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        General = 0,

        /// <summary>
        /// This is an assigned program related note. This should set ProgramID on the note. (1)
        /// </summary>
        Program = 1,

        /// <summary>
        /// This is an assigned job related note. This should set JobID on the note. (2)
        /// </summary>
        Job = 2,

        /// <summary>
        /// This is a LMS related note (3)
        /// </summary>
        LMS = 3,

        /// <summary>
        /// This is a case planning related note (4)
        /// </summary>
        CasePlanning = 4,

        /// <summary>
        /// This is a contact note (5)
        /// </summary>
        Contact = 5,

        /// <summary>
        /// This is a collateral note (6)
        /// </summary>
        Collateral = 6,

        /// <summary>
        /// This is a phone call related note (7)
        /// </summary>
        PhoneCall = 7,

        /// <summary>
        /// This is a email related note (8)
        /// </summary>
        Email = 8,

        /// <summary>
        /// This is a programming note (9)
        /// </summary>
        Programming = 9,

        Goal = 10,
    }

    /// <summary>
    /// Display names for the various tag types we support
    /// </summary>
    public class NoteTypeConstants
    {
        /// <summary>
        /// Not specified this should not ever be used (0)
        /// </summary>
        public const string General = "General";

        /// <summary>
        /// This is an assigned program related note. This should set ProgramID on the note. (1)
        /// </summary>
        public const string Program = "Program";

        /// <summary>
        /// This is an assigned job related note. This should set JobID on the note. (2)
        /// </summary>
        public const string Job = "Job";

        /// <summary>
        /// This is a LMS related note (3)
        /// </summary>
        public const string LMS = "LMS";

        /// <summary>
        /// This is a case planning related note (4)
        /// </summary>
        public const string CasePlanning = "Case Planning";

        /// <summary>
        /// This is a contact note (5)
        /// </summary>
        public const string Contact = "Contact";

        /// <summary>
        /// This is a collateral note (6)
        /// </summary>
        public const string Collateral = "Collateral";

        /// <summary>
        /// This is a phone call related note (7)
        /// </summary>
        public const string PhoneCall = "Phone Call";

        /// <summary>
        /// This is a email related note (8)
        /// </summary>
        public const string Email = "Email";

        /// <summary>
        /// This is a programming note (9)
        /// </summary>
        public const string Programming = "Programming";

        public const string Goal = "Goal";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)NoteType.General:
                    return General;

                case (int)NoteType.Program:
                    return Program;

                case (int)NoteType.Job:
                    return Job;

                case (int)NoteType.LMS:
                    return LMS;

                case (int)NoteType.CasePlanning:
                    return CasePlanning;

                case (int)NoteType.Contact:
                    return Contact;

                case (int)NoteType.Collateral:
                    return Collateral;

                case (int)NoteType.PhoneCall:
                    return PhoneCall;

                case (int)NoteType.Email:
                    return Email;

                case (int)NoteType.Programming:
                    return Programming;

                case (int)NoteType.Goal:
                    return Goal;

                default:
                    return General;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(NoteType value)
        {
            return GetByEnum((int)value);
        }
    }
}
