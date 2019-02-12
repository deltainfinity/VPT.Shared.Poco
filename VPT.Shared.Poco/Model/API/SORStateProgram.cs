using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a SOR State Program 
    /// </summary>

    public class SORStateProgram
    {
        public SORStateProgram()
        { }

        public SORStateProgram(SORStateProgramDTO sorStateProgram)
        {
            StateProgramLookupID = sorStateProgram.StateProgramLookupID;
            StateProgramID = sorStateProgram.StateProgramID;
            ProgramStatus = sorStateProgram.ProgramStatus;
            HourlyPayRate = sorStateProgram.HourlyPayRate;
            Credit = sorStateProgram.Credit;
            IncentiveProgram = sorStateProgram.IncentiveProgram;
            StateProgramName = sorStateProgram.StateProgramName;
        }

        public int StateProgramLookupID { get; set; }

        public string StateProgramID { get; set; }

        public string ProgramStatus { get; set; }

        public decimal HourlyPayRate { get; set; }

        public int Credit { get; set; }

        public bool IncentiveProgram { get; set; }

        public string StateProgramName { get; set; }
    }
}

