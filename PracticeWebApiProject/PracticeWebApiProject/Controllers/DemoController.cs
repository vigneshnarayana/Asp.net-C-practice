using PracticeWebApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeWebApiProject.Controllers
{
    public class DemoController : ApiController
    {
        // GET: api/Demo
        [Route("api/demo")]
        public List<UserMaster> GetUsers()
        {
            List<UserMaster> obj = new List<UserMaster>();
            for (int i = 1; i < 10; i++) {
                var  obj1 = new UserMaster
                {
                    Id = i,
                    Name = "Viki",
                    Age = "36",
                    Department = "ABC"
                };
                obj.Add(obj1);
            }

            

           
            return obj;

        }

        // GET: api/Demo/5
        [HttpPost]
        [Route("api/demo/{id}")]
        public UserMaster Get(int id)
        {
            var obj1 = new UserMaster
            {
                Id = id,
                Name = "Viki"+ id,
                Age = "36"+ id,
                Department = "ABC"+ id
            };
            return obj1;
        }
        [Route("api/UserEntry")]
        public List<UserMaster> Post([FromBody] List<UserMaster> UserEntry)
        {
            List<UserMaster> ob = new List<UserMaster>();

            if (UserEntry != null)
            {

                foreach (UserMaster at in UserEntry)
                {
                    var obj1 = new UserMaster
                    {
                        Id = at.Id,
                        Name = at.Name,
                        Age = at.Age,
                        Department = at.Department
                    };
                    ob.Add(obj1);
                    //b = usrmgt.insertUserDetails(at.UserId, at.UserName, at.UserPassword, at.Location);


                }

            }
            
            return ob;
        }

        // POST: api/Demo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Demo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Demo/5
        public void Delete(int id)
        {
        }
    }
}
