using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class DomainDetailsDTO 
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public DomainDetailsDTO()
        { }
        /// <summary>
        /// Copy constructor used to populate the object
        /// </summary>
        /// <param name="domains">The list of domains</param>
        /// <param name="goals">The list of goals</param>
        /// <param name="actionsteps">The list of actionsteps</param>
        /// <param name="agentlist">The list of agents</param>


        public DomainDetailsDTO(IList<Tag> domains, IList<Goal> goals, IList<ActionStep> actionsteps,IList<PersonDetailsDTO> agentlist)
            : base()
        {
            Domains = new List<TagDTO>();
            if (domains != null && domains.Any())
            {
                foreach (var domain in domains)
                {
                    Domains.Add(new TagDTO(domain));
                }
            }

            Goals = new List<GoalDTO>();
            if (goals != null && goals.Any())
            {
                foreach (var goal in goals)
                {
                    Goals.Add(new GoalDTO(goal));
                }
            }
            ActionSteps = new List<ActionStepDTO>();
            if (actionsteps != null && actionsteps.Any())
            {
                foreach (var actionstep in actionsteps)
                {
                    ActionSteps.Add(new ActionStepDTO(actionstep));
                }
            }

            AgentList = agentlist;


        }
        /// <summary>
        /// List of contact domains
        /// </summary>
        [JsonProperty("domain")]
        public IList<TagDTO> Domains { get; set; }

        /// <summary>
        /// List of goals
        /// </summary>
        [JsonProperty("goal")]
        public IList<GoalDTO> Goals { get; set; }

        /// <summary>
        /// List of action steps
        /// </summary>
        [JsonProperty("actionStep")]
        public IList<ActionStepDTO> ActionSteps { get; set; }
        /// <summary>
        /// List of subject agents
        /// </summary>
        [JsonProperty("agentList")]
        public IList<PersonDetailsDTO> AgentList { get; set; }



    }
}
