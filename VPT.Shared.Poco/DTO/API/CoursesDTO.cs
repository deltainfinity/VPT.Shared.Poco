using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CoursesDTO
    {
        public CoursesDTO()
        { }
        public CoursesDTO(List<VIDSProgramRecommendationDTO> coursesDTO,string recommendedDate)
        {
            Courses = coursesDTO;
            RecommendedDate = recommendedDate;
        }

        [JsonProperty("courses")]
        public List<VIDSProgramRecommendationDTO> Courses { get; set; }

        [JsonProperty("recommendedDate")]
        public string RecommendedDate { get; set; }

    }
}
