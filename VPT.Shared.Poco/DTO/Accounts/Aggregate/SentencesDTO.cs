using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class SentencesDTO
    {
        public SentencesDTO()
        { }

        public SentencesDTO(SentencesDTO Sentences)
        {
            SentencingCourt = Sentences.SentencingCourt;
            SentencingJudge = Sentences.SentencingJudge;
            SentenceVerified = Sentences.SentenceVerified;
            CaseNumber = Sentences.CaseNumber;
            SentenceExternalId = Sentences.SentenceExternalId;
            Source = Sentences.Source;
            SentenceDate = Sentences.SentenceDate;
            Type = Sentences.Type;
            SentenceType = Sentences.SentenceType;
            State = Sentences.State;
            County = Sentences.County;


        }
        public string SentencingCourt { get; set; }

        /// <summary>
        /// The name of the judge that ordered the sentence
        /// </summary>
        public string SentencingJudge { get; set; }

        /// <summary>
        /// Has the sentence been verified
        /// </summary>
        public bool SentenceVerified { get; set; }
        /// <summary>
        /// Case Number of subjects. 
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// The unique ID for the sentence in the system of record
        /// </summary>
        public string SentenceExternalId { get; set; }

        /// <summary>
        /// The source document/site for the sentence information
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// The date and time the subject was sentence
        /// </summary>
        public DateTime? SentenceDate { get; set; }

        /// <summary>
        /// The type of subject, adult or juvenile, at the time of the sentence.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The type of sentence, ex: Prison, Jail, Probation
        /// </summary>
        public string SentenceType { get; set; }

        /// <summary>
        /// The state the subject was sentenced in 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The county the subject was sentenced in 
        /// </summary>
        public string County { get; set; }
    }
}
