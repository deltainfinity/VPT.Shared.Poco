namespace VPT.Shared.Poco.Enum.API
{
    public enum ProgramAssignType
    {
        /// <summary>
        /// The program is assigned directly through program search (1)
        /// </summary>
        DirectProgramAssign = 1,

        /// <summary>
        /// The program is assigned through treatment pathway (2)
        /// </summary>
        TreatmentPathwayAssign = 2,

        /// <summary>
        /// The program is assigned through action step(3)
        /// </summary>
        ActionStepAssign = 3,

    }

    public class ProgramAssignTypeConstants
    {
        /// <summary>
        /// The program is assigned directly through program search (1)
        /// </summary>
        public const string DirectProgramAssign = "DirectProgramAssign";

        /// <summary>
        /// The program is assigned through treatment pathway (2)
        /// </summary>
        public const string TreatmentPathwayAssign = "TreatmentPathwayAssign";

        /// <summary>
        /// The program is assigned through action step(3)
        /// </summary>
        public const string ActionStepAssign = "ActionStepAssign";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {
                case (int)ProgramAssignType.DirectProgramAssign:
                    return DirectProgramAssign;

                case (int)ProgramAssignType.TreatmentPathwayAssign:
                    return TreatmentPathwayAssign;

                case (int)ProgramAssignType.ActionStepAssign:
                    return ActionStepAssign;

                default:
                    return DirectProgramAssign;
            }
        }

        public static ProgramAssignType GetByString(string state)
        {
            switch (state)
            {
                case DirectProgramAssign:
                    return ProgramAssignType.DirectProgramAssign;

                case TreatmentPathwayAssign:
                    return ProgramAssignType.TreatmentPathwayAssign;

                case ActionStepAssign:
                    return ProgramAssignType.ActionStepAssign;

                default:
                    return ProgramAssignType.DirectProgramAssign;
            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(ProgramAssignType value)
        {
            return GetByEnum((int)value);
        }
    }
}
