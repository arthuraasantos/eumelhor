using EuMelhor.AppService.DTO;
using EuMelhor.AppService.Entities;
using EuMelhor.AppService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace EuMelhor.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [ResponseType(typeof(UserDto))]
        public HttpResponseMessage Get(string key)
        {
            try
            {
                Guid userKey;
                Guid.TryParse(key, out userKey);
                var user = UserAppService.GetUser(userKey);
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            catch (Exception)
            {
                Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro ao buscar usuário");
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro inesperado");

        }

        [HttpPost]
        [ResponseType(typeof(string))]
        // POST: api/User
        public HttpResponseMessage Post([FromBody]UserDto newUser)
        {
            try
            {
                var result = UserAppService.CreateUser(newUser);
                return Request.CreateResponse(HttpStatusCode.Created, "Usuário criado com sucesso!");
            }
            catch (Exception)
            {
                Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro ao criar novo usuário");
            }

            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro inesperado");
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
