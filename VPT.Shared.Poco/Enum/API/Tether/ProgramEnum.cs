namespace VPT.Shared.Poco.Enum.API.Tether
{
    public enum ProgramEnum
    {
        CurrentProgram = 1,
        AllPrograms = 2
    }
    public class ProgramEnumType
    {
        public const string CurrentProgram = "CURRENT";
        public const string AllPrograms = "ALL";

        public static int GetByString(string state)
        {
            switch (state)
            {
                case CurrentProgram:
                    return (int)ProgramEnum.CurrentProgram;

                case AllPrograms:
                    return (int)ProgramEnum.AllPrograms;

                default:
                    return (int)ProgramEnum.CurrentProgram;
            }
        }

    }
}
