using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiTest1.Models;


namespace WebApiTest1.Controllers
{
    public class ValuesController : ApiController
    {
        List<Parking> Parkings = new List<Parking>()
        {
            new Parking() {UserId=111,UserName="Ashish",ParkingType="4w",Country="India",State="Karnataka",City="Bangalore",Area="SJP",AreaCode=22,SubArea="Khanalli",SubAreaCode=44,Latitude="12.9177480",Longitute="77.6709550",StartTime="146172832400",EndTime="1461739124000",Price=10,Status=true },
            new Parking() {UserId=112,UserName="Ronil",ParkingType="4w",Country="India",State="Karnataka",City="Bangalore",Area="HSR",AreaCode=23,SubArea="Venkatpura",SubAreaCode=45,Latitude="12.9199540",Longitute="77.6256900",StartTime="1461814724000",EndTime="1461825524000",Price=20,Status=true },
            new Parking() {UserId=113,UserName="Pradeep",ParkingType="4w",Country="India",State="Karnataka",City="Bangalore",Area="MADIWALA",AreaCode=24,SubArea="Maruthi",SubAreaCode=46,Latitude="13.0054100",Longitute="77.65375790",StartTime="1461901124000",EndTime="1461911924000",Price=20,Status=true },
            new Parking() {UserId=114,UserName="Kiran",ParkingType="4w",Country="India",State="Karnataka",City="Bangalore",Area="BOOMANHALLI",AreaCode=25,SubArea="Ashok",SubAreaCode=47,Latitude="12.8983600",Longitute="77.617970",StartTime="1461987524000",EndTime="1461998324000",Price=20,Status=true }
        };

        // GET api/values
        public string Get()
        {
            var json = JsonConvert.SerializeObject(Parkings);
            return json;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Employees
        //public IQueryable<Employee> GetEmployees()
        //{
        //    return db.Employees;
        //}

        // GET api/values/5
        public string Get(int id)
        {
            var parking = Parkings.Find(x => x.UserId == id);

            return JsonConvert.SerializeObject(parking);
            //return "value";
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{

        //}

        // POST: api/Parking
        [ResponseType(typeof(Parking))]
        public IHttpActionResult Post(Parking parking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Parkings.Add(parking);

            return CreatedAtRoute("DefaultApi", new { id = parking.UserId }, parking);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // PUT: api/Parking/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Parking parking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parking.UserId)
            {
                return BadRequest();
            }

            foreach (var userid in Parkings)
            {
                if (userid.UserId == id)
                {
                    userid.Area = parking.Area;
                    userid.AreaCode = parking.AreaCode;
                    userid.City = parking.City;
                    userid.Country = parking.Country;
                    userid.EndTime = parking.EndTime;
                    userid.Latitude = parking.Latitude;
                    userid.Longitute = parking.Longitute;
                    userid.ParkingType = parking.ParkingType;
                    userid.Price = parking.Price;
                    userid.StartTime = parking.StartTime;
                    userid.State = parking.State;
                    userid.Status = parking.Status;
                    userid.SubArea = parking.SubArea;
                    userid.SubAreaCode = parking.SubAreaCode;
                    userid.UserId = parking.UserId;
                    userid.UserName = parking.UserName;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            foreach (var userid in Parkings)
            {
                if (userid.UserId == id)
                {
                    Parkings.Remove(userid);
                }
            }
        }
    }
}
