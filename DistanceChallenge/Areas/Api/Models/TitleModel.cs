using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class TitleModel
    {

        public TitleModel()
        {

        }

        public TitleModel(Data.Title title)
        {
            this.TitleId = title.TitleId;
            this.TitleName = title.TitleName;
            this.TitleNameSortable = title.TitleNameSortable;
            this.TitleTypeId = title.TitleTypeId;
            this.ReleaseYear = title.ReleaseYear;
            this.ProcessedDateTimeUTC = title.ProcessedDateTimeUTC;

            this.Awards = title.Awards.Select(a => new AwardModel(a)).ToArray();
            this.OtherNames = title.OtherNames.Select(a => new OtherNameModel(a)).ToArray();
            this.StoryLines = title.StoryLines.Select(a => new StoryLineModel(a)).ToArray();
            this.TitleGenres = title.TitleGenres.Select(a => new TitleGenreModel(a)).ToArray();
            this.TitleParticipants = title.TitleParticipants.Select(a => new TitleParticipantModel(a)).ToArray();
        }

        [DataMember]
        public int TitleId { get; set; }
        [DataMember]
        public string TitleName { get; set; }
        [DataMember]
        public string TitleNameSortable { get; set; }
        [DataMember]
        public int? TitleTypeId { get; set; }
        [DataMember]
        public int? ReleaseYear { get; set; }
        [DataMember]
        public DateTime? ProcessedDateTimeUTC { get; set; }

        [DataMember]
        public AwardModel[] Awards { get; set; }
        [DataMember]
        public OtherNameModel[] OtherNames { get; set; }
        [DataMember]
        public StoryLineModel[] StoryLines { get; set; }
        [DataMember]
        public TitleGenreModel[] TitleGenres { get; set; }
        [DataMember]
        public TitleParticipantModel[] TitleParticipants { get; set; }
    }
}