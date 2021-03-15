using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VoThiDieuThuong_5951071105.Models;

namespace VoThiDieuThuong_5951071105.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        //public IEnumerable<StudentInfo> Get()
        //{
        //    var StudentInfList = new List<StudentInfo>();
        //    {
        //        var StudentInfo = new StudentInfo
        //        {
        //            Name = "Vo Thi Dieu Thuong",
        //            MSSV = "5951071105"

        //        }; ;
        //        StudentInfList.Add(StudentInfo);
        //    }
        //    return StudentInfList;
        //}

        public StudentInfo Get()
        {
            return new StudentInfo
            {
               Name= "Võ Thị Diệu Thương",
                MSSV="5951071105"
            }; ;
        }
    }
}
