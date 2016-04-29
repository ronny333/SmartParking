using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest1.Models
{
    public class Parking
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ParkingType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public int AreaCode { get; set; }
        public string SubArea { get; set; }
        public int SubAreaCode { get; set; }
        public string Latitude { get; set; }
        public string Longitute { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool Status { get; set; }
        public float Price { get; set; }
    }
}