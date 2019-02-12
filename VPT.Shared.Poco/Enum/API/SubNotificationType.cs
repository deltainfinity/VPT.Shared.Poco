namespace VPT.Shared.Poco.Enum.API
{
    public enum SubNotificationType
    {

        /// <summary>
        /// Program assigned to subject notification to agent (1)
        /// </summary>
        ProgramAssignedNotificationToSubject = 1,

        /// <summary>
        /// Subject assigned to caseload notification (2)
        /// </summary>
        AssignSubjectToCaseload = 2,

        /// <summary>
        /// Casenote saved notification  (3)
        /// </summary>
        SaveCaseNote = 3,

        /// <summary>
        /// Notification to facilitator when assigned as facilitataor to a program (4)
        /// </summary>
        AssignedAsProgramFacilitator = 4,

        /// <summary>
        /// Notification to facilitator when subject completes required number of sessions  (5)
        /// </summary>
        ProgramSessionCompletedToFacilitator = 5,

        /// <summary>
        /// Notification to subject when case manager changes program status to complete  (6)
        /// </summary>
        ProgramStatusChangedToCompleteToSubject = 6,

        /// <summary>
        /// Notification to agent when facilitator changes program status to complete  (7)
        /// </summary>
        ProgramStatusChangedToCompleteToAgent = 7,

        /// <summary>
        /// Notification to case manager when subject unsuccessfuly complete a program's session (8)
        /// </summary>
        ProgramStatusChangedToUnsuccessfulComplete = 8,

        /// <summary>
        /// Notification to case manager when subject is absent for a session  (9)
        /// </summary>
        AbsentFromProgramSession = 9,

        /// <summary>
        /// Notification to case manager when subject is recieved bad rating  (10)
        /// </summary>
        BadRatingForProgramSession = 10,

        /// <summary>
        /// Notification to facilitator when assigned agent reffered subject for a program (11)
        /// </summary>
        AssignedAgentReferredSubjectToProgram = 11,

        /// <summary>
        /// Notification to case manager when subject is excused absent for a session  (12)
        /// </summary>
        ExcusedAbsentFromProgramSession = 12,

        /// <summary>
        /// Notification to care group memebers when subject's actionstep exceeded due date (13)
        /// </summary>
        ActionStepExceeedDueDate = 13,

        /// <summary>
        /// Notification to reciever when a Request is created (14)
        /// </summary>
        FSWReferalNotification = 14

    }

    public class SubNotificationTypeConstants
    {
        /// <summary>
        /// Program assigned to subject notification to agent (1)
        /// </summary>
        public const string ProgramAssignedNotificationToSubject = "ProgramAssignedNotificationToSubject";

        /// <summary>
        /// Subject assigned to caseload notification  (2)
        /// </summary>
        public const string AssignSubjectToCaseload = "AssignSubjectToCaseload";

        /// <summary>
        /// Casenote saved notification  (3)
        /// </summary>
        public const string SaveCaseNote = "SaveCaseNote";

        /// <summary>
        /// Notification to facilitator when assigned as facilitataor to a program (4)
        /// </summary>
        public const string AssignedAsProgramFacilitator = "AssignedAsProgramFacilitator";

        /// <summary>
        /// Notification to facilitator when subject completes required number of sessions  (5)
        /// </summary>
        public const string ProgramSessionCompletedToFacilitator = "ProgramSessionCompletedToFacilitator";

        /// <summary>
        /// Notification to subject when case manager changes program status to complete  (6)
        /// </summary>
        public const string ProgramStatusChangedToCompleteToSubject = "ProgramStatusChangedToCompleteToSubject";

        /// <summary>
        /// Notification to agent when facilitator changes program status to complete  (7)
        /// </summary>
        public const string ProgramStatusChangedToCompleteToAgent = "ProgramStatusChangedToCompleteToAgent";

        /// <summary>
        /// Notification to case manager when subject unsuccessfuly complete a program's session (8)
        /// </summary>
        public const string ProgramStatusChangedToUnsuccessfulComplete = "ProgramStatusChangedToUnsuccessfulComplete";

        /// <summary>
        /// Notification to case manager when subject is absent for a session  (9)
        /// </summary>
        public const string AbsentFromProgramSession = "AbsentFromProgramSession";

        /// <summary>
        /// Notification to case manager when subject is recieved bad rating in a program session  (10)
        /// </summary>
        public const string BadRatingForProgramSession = "BadRatingForProgramSession";

        /// <summary>
        /// Notification to facilitator when assigned agent reffered subject for a program (11)
        /// </summary>
        public const string AssignedAgentReferredSubjectToProgram = "AssignedAgentReferredSubjectToProgram";

        /// <summary>
        /// Notification to case manager when subject is excused absent for a session  (12)
        /// </summary>
        public const string ExcusedAbsentFromProgramSession = "ExcusedAbsentFromProgramSession";

        /// <summary>
        /// Notification to care group memebers when subject's actionstep exceeded due date (13)
        /// </summary>
        public const string ActionStepExceeedDueDate = "ActionStepExceeedDueDate";

        /// <summary>
        /// Notification to reciever when a Request is created (14)
        /// </summary>
        public const string FSWReferalNotification = "FSWReferalNotification";

        /// <summary>
        /// Get the display string for an enum by it's value in integer form
        /// </summary>
        /// <param name="value">The enum value in integer form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(int value)
        {
            switch (value)
            {

                case (int)SubNotificationType.ProgramAssignedNotificationToSubject:
                    return ProgramAssignedNotificationToSubject;

                case (int)SubNotificationType.AssignSubjectToCaseload:
                    return AssignSubjectToCaseload;

                case (int)SubNotificationType.SaveCaseNote:
                    return SaveCaseNote;

                case (int)SubNotificationType.AssignedAsProgramFacilitator:
                    return AssignedAsProgramFacilitator;

                case (int)SubNotificationType.ProgramSessionCompletedToFacilitator:
                    return ProgramSessionCompletedToFacilitator;

                case (int)SubNotificationType.ProgramStatusChangedToCompleteToSubject:
                    return ProgramStatusChangedToCompleteToSubject;

                case (int)SubNotificationType.ProgramStatusChangedToCompleteToAgent:
                    return ProgramStatusChangedToCompleteToAgent;

                case (int)SubNotificationType.ProgramStatusChangedToUnsuccessfulComplete:
                    return ProgramStatusChangedToUnsuccessfulComplete;

                case (int)SubNotificationType.AbsentFromProgramSession:
                    return AbsentFromProgramSession;

                case (int)SubNotificationType.BadRatingForProgramSession:
                    return BadRatingForProgramSession;

                case (int)SubNotificationType.AssignedAgentReferredSubjectToProgram:
                    return AssignedAgentReferredSubjectToProgram;

                case (int)SubNotificationType.ExcusedAbsentFromProgramSession:
                    return ExcusedAbsentFromProgramSession;

                case (int)SubNotificationType.ActionStepExceeedDueDate:
                    return ActionStepExceeedDueDate;

                case (int)SubNotificationType.FSWReferalNotification:
                    return FSWReferalNotification;
                    
                default:
                    return ProgramAssignedNotificationToSubject;

            }
        }

        public static SubNotificationType GetByString(string type)
        {
            switch (type)
            {
                case ProgramAssignedNotificationToSubject:
                    return SubNotificationType.ProgramAssignedNotificationToSubject;

                case AssignSubjectToCaseload:
                    return SubNotificationType.AssignSubjectToCaseload;

                case SaveCaseNote:
                    return SubNotificationType.SaveCaseNote;

                case AssignedAsProgramFacilitator:
                    return SubNotificationType.AssignedAsProgramFacilitator;

                case ProgramSessionCompletedToFacilitator:
                    return SubNotificationType.ProgramSessionCompletedToFacilitator;

                case ProgramStatusChangedToCompleteToSubject:
                    return SubNotificationType.ProgramStatusChangedToCompleteToSubject;

                case ProgramStatusChangedToCompleteToAgent:
                    return SubNotificationType.ProgramStatusChangedToCompleteToAgent;

                case ProgramStatusChangedToUnsuccessfulComplete:
                    return SubNotificationType.ProgramStatusChangedToUnsuccessfulComplete;

                case AbsentFromProgramSession:
                    return SubNotificationType.AbsentFromProgramSession;

                case BadRatingForProgramSession:
                    return SubNotificationType.BadRatingForProgramSession;

                case AssignedAgentReferredSubjectToProgram:
                    return SubNotificationType.AssignedAgentReferredSubjectToProgram;

                case ExcusedAbsentFromProgramSession:
                    return SubNotificationType.ExcusedAbsentFromProgramSession;

                case ActionStepExceeedDueDate:
                    return SubNotificationType.ActionStepExceeedDueDate;

                case FSWReferalNotification:
                    return SubNotificationType.FSWReferalNotification;

                default:
                    return SubNotificationType.ProgramAssignedNotificationToSubject;

            }
        }

        /// <summary>
        /// Get the display string for an enum by it's value in enum form
        /// </summary>
        /// <param name="value">The enum value in enum form</param>
        /// <returns>The display string for the value or the default if one cannot be found</returns>
        public static string GetByEnum(SubNotificationType value)
        {
            return GetByEnum((int)value);
        }
    }
}
