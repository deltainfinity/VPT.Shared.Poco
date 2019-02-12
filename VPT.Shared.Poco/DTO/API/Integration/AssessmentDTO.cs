using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Integration
{

    public class AssessmentDTO  {
        public AssessmentDTO()
        {

        }
        public AssessmentDTO(Assessment source)
        {
            AssessmentID = source.AssessmentID;
            Name = source.Name;
        }

        public int AssessmentID;
        public string AssessmentURL;
        public string Description;
        public List<CustomField> ExtendedFields;
        public string LastModifiedBy;
        public DateTime LastModifiedOn;
        public string MaterialsURL;
        public string Name;
        public int OffenderAssessmentId;
        public string OffenderAssessmentPIN;
        public int OffenderId;
        public List<Section> sections;
        public string Status;

    }
}
