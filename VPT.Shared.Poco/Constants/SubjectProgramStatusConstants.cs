namespace VPT.Shared.Poco.Constants
{
    public class SubjectProgramStatuseConstants
    {
        /// <summary>
        /// Program is Unknown to subject
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// Program is assigned to subject
        /// </summary>
        public const string Assigned = "Assigned";

        /// <summary>
        /// Subject was referred to the program
        /// </summary>
        public const string Referred = "Referred";

        /// <summary>
        /// Subject is waiting for room in the program
        /// </summary>
        public const string WaitList = "Waiting List";

        /// <summary>
        /// Subject is attending the program
        /// </summary>
        public const string InProgress = "In Progress";

        /// <summary>
        /// Subject is Suspended with Credit from the program
        /// </summary>
        public const string SuspendedCredit = "Suspended - Credit";

        /// <summary>
        /// Subject is Suspended without Credit from the program
        /// </summary>
        public const string SuspendedNoCredit = "Suspended - No Credit";

        /// <summary>
        /// Subject has completed the program successfully
        /// </summary>
        public const string Completed = "Completed";

        /// <summary>
        /// Subject was terminated from the program
        /// </summary>
        public const string Terminated = "Terminated";

        /// <summary>
        /// Subject is in pending for completetion
        /// </summary>
        public const string PendingComplete = "Pending Complete";

        /// <summary>
        /// Subject unsuccessfuly completed program
        /// </summary>
        public const string UnsuccessfulComplete = "Unsuccessfully Complete - Other";

        /// <summary>
        /// Program Overrided for subject
        /// </summary>
        public const string Override = "Override";

        /// <summary>
        /// Subject unsuccessfuly completed program -ClassPerformance
        /// </summary>
        public const string UnsuccessfulCompleteClassPerformance = "Unsuccessfully Complete - Class Performance";

        /// <summary>
        /// Subject unsuccessfuly completed program -ClassAttendance
        /// </summary>
        public const string UnsuccessfulCompleteClassAttendance = "Unsuccessfully Complete - Class Attendance";

        /// <summary>
        /// Subject unsuccessfuly completed program -Transferred
        /// </summary>
        public const string UnsuccessfulCompleteTransferred = "Unsuccessfully Complete - Transferred and Did Not Continue Program";

        /// <summary>
        /// Subject unsuccessfuly completed program -Absconder
        /// </summary>
        public const string UnsuccessfulCompleteAbsconder = "Unsuccessfully Complete - Absconder";

        /// <summary>
        /// Subject unsuccessfuly completed program -Violation
        /// </summary>
        public const string UnsuccessfulCompleteViolation = "Unsuccessfully Complete - Violation";

        /// <summary>
        /// Subject unsuccessfuly completed program -DrugUse
        /// </summary>
        public const string UnsuccessfulCompleteDrugUse = "Unsuccessfully Complete - Drug Use";

    }
}
