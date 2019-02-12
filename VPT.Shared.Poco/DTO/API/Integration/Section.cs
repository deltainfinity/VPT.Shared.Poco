using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class Section
    {
        public Section()
        {

        }

        public string Description;
        public string HelpText;
        public bool isProtectiveNote;
        public string Name;
        public string Note;
        public List<Question> questions;
        public int SectionID;
    }
}