using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace VoThiDieuThuong_5951071105.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "mssv")]
        public string MSSV { get; set; }

    }
}