using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class TitleParticipantModel
    {
        public TitleParticipantModel()
        {

        }

        public TitleParticipantModel(Data.TitleParticipant titleParticipant)
        {
            this.Id = titleParticipant.Id;
            this.TitleId = titleParticipant.TitleId;
            this.ParticipantId = titleParticipant.ParticipantId;
            this.IsKey = titleParticipant.IsKey;
            this.RoleType = titleParticipant.RoleType;
            this.IsOnScreen = titleParticipant.IsOnScreen;

            this.Participant = new ParticipantModel(titleParticipant.Participant);
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int TitleId { get; set; }
        [DataMember]
        public int ParticipantId { get; set; }
        [DataMember]
        public bool IsKey { get; set; }
        [DataMember]
        public string RoleType { get; set; }
        [DataMember]
        public bool IsOnScreen { get; set; }

        [DataMember]
        public ParticipantModel Participant { get; set; }
    }

}