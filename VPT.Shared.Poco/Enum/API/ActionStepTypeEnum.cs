namespace VPT.Shared.Poco.Enum.API
{
    public enum ActionStepTypeEnum
    {
        /// <summary>
        /// The action step type is program (1)
        /// </summary>
        Program = 1,

        /// <summary>
        /// The action step type is general (2)
        /// </summary>
        General = 2,

    }

    public class ActionStepTypeConstants
    {
        /// <summary>
        /// The notification is in an unknown state (0)
        /// </summary>
        public const string Program = "Program";

        /// <summary>
        /// The notification has been viewed (1)
        /// </summary>
        public const string General = "General";


        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ActionStepTypeEnum.Program:
                    return Program;

                case (int)ActionStepTypeEnum.General:
                    return General;

                default:
                    return General;
            }
        }

        public static ActionStepTypeEnum GetByString(string state)
        {
            switch (state)
            {
                case Program:
                    return ActionStepTypeEnum.Program;

                case General:
                    return ActionStepTypeEnum.General;

                default:
                    return ActionStepTypeEnum.General;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ActionStepTypeEnum value)
        {
            return GetByEnum((int)value);
        }
    }
}
