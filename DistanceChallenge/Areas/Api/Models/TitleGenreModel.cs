using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class TitleGenreModel
    {
        public TitleGenreModel()
        {

        }

        public TitleGenreModel(Data.TitleGenre titleGenre)
        {
            this.Id = titleGenre.Id;
            this.TitleId = titleGenre.TitleId;
            this.GenreId = titleGenre.GenreId;

            this.Genre = new GenreModel(titleGenre.Genre);

        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int TitleId { get; set; }
        [DataMember]
        public int GenreId { get; set; }

        [DataMember]
        public GenreModel Genre { get; set; }
    }
}