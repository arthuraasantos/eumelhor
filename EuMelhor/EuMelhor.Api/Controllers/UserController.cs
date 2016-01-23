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
        public IUserAppService UserAppService;

        public UserController(IUserAppService userAppService)
        {
            UserAppService = userAppService;
        }

        // GET: api/User
        public IEnumerable<UserDto> Get()
        {
            return UserAppService.GetAll();
        }

        // GET: api/User/5
        public UserDto Get(Guid key)
        {
            return UserAppService.GetUser(key);
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
