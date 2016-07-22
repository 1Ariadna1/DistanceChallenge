using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class StoryLineModel
    {
        public StoryLineModel()
        {

        }

        public StoryLineModel(Data.StoryLine storyLine)
        {
            this.TitleId = storyLine.TitleId;
            this.Type = storyLine.Type;
            this.Language = storyLine.Language;
            this.Description = storyLine.Description;
            this.Id = storyLine.Id;

        }

        [DataMember]
        public int TitleId { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}