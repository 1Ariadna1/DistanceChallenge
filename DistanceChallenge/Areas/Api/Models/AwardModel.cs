using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class AwardModel
    {
        public AwardModel()
        {

        }

        public AwardModel(Data.Award award)
        {
            this.TitleId = award.TitleId;
            this.AwardWon = award.AwardWon;
            this.AwardYear = award.AwardYear;
            this.Award1 = award.Award1;
            this.AwardCompany = award.AwardCompany;
            this.Id = award.Id;

        }

        [DataMember]
        public int TitleId { get; set; }
        [DataMember]
        public bool? AwardWon { get; set; }
        [DataMember]
        public int? AwardYear { get; set; }
        [DataMember]
        public string Award1 { get; set; }
        [DataMember]
        public string AwardCompany { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}