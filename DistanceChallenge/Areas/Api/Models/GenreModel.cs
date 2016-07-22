using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class GenreModel
    {

        public GenreModel()
        {

        }

        public GenreModel(Data.Genre genre)
        {
            this.Id = genre.Id;
            this.Name = genre.Name;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}