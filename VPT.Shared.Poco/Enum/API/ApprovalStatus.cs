namespace VPT.Shared.Poco.Enum.API
{
    public enum ApprovalStatus
    {
        /// <summary>
        /// The referral is in a pending state (0)
        /// </summary>
        Pending = 0,

        /// <summary>
        /// The referral is in an approved state (1)
        /// </summary>
        Approved = 1,

        /// <summary>
        /// The referral is in a rejected stated (2)
        /// </summary>
        Rejected = 2
    }

    public class ApprovalStatusConstants
    {
        /// <summary>
        /// The referral is in a pending state (0)
        /// </summary>
        public const string Pending = "Pending";

        /// <summary>
        /// The referral is in an approved state (1)
        /// </summary>
        public const string Approved = "Approved";

        /// <summary>
        /// The referral is in a rejected stated (2)
        /// </summary>
        public const string Rejected = "Rejected";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ApprovalStatus.Pending:
                    return Pending;

                case (int)ApprovalStatus.Approved:
                    return Approved;

                case (int)ApprovalStatus.Rejected:
                    return Rejected;

                default:
                    return Pending;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ApprovalStatus value)
        {
            return GetByEnum((int)value);
        }
    }
}
