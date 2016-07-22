using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DistanceChallenge.Areas.Api.Models
{
    [DataContract]
    public class OtherNameModel
    {
        public OtherNameModel()
        {

        }

        public OtherNameModel(Data.OtherName otherName)
        {
            this.TitleId = otherName.TitleId;
            this.TitleNameLanguage = otherName.TitleNameLanguage;
            this.TitleNameType = otherName.TitleNameType;
            this.TitleNameSortable = otherName.TitleNameSortable;
            this.TitleName = otherName.TitleName;
            this.Id = otherName.Id;
        }


        [DataMember]
        public int? TitleId { get; set; }
        [DataMember]
        public string TitleNameLanguage { get; set; }
        [DataMember]
        public string TitleNameType { get; set; }
        [DataMember]
        public string TitleNameSortable { get; set; }
        [DataMember]
        public string TitleName { get; set; }
        [DataMember]
        public int Id { get; set; }
    }
}