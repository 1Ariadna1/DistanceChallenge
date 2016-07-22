using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class ParticipantModel
    {
        public ParticipantModel()
        {

        }

        public ParticipantModel(Data.Participant participant)
        {
            this.Id = participant.Id;
            this.Name = participant.Name;
            this.ParticipantType = participant.ParticipantType;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ParticipantType { get; set; }
    }
}