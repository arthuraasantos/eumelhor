using EuMelhor.AppService.DTO;
using EuMelhor.AppService.Entities;
using EuMelhor.AppService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EuMelhor.Api.Controllers
{
    public class UserController : ApiController
    {
        public UserAppService UserAppService;

        public UserController()
        {
            UserAppService = new UserAppService();
        }

        //// GET: api/User
        //public IEnumerable<UserDto> Get()
        //{
        //    return UserAppService.GetAll();
        //}

        // GET: api/User/5
        [HttpGet]
        public UserDto Get(string key)
        {
            try
            {
                Guid userKey;
                Guid.TryParse(key, out userKey);

                return UserAppService.GetUser(userKey);
            }
            catch (Exception)
            {
               
                throw;
            }
            
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
