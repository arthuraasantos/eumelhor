using EuMelhor.AppService.DTO;
using EuMelhor.AppService.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using EuMelhor.Api.Models;


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

        //Metodo para eliminar a possibilidade de retornar XML e identar o JSON
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.Indent = true;

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
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro ao buscar usuário");
            }

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
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro ao criar novo usuário");
            }

        }


        [HttpPut]
        // PUT: api/User/Put
        public HttpResponseMessage Put(UserDTOServiceModel model)
        {
            try
            {
                UserDto u = new UserDto();

                u.FirstName = model.FirstName;
                u.Name = model.Name;
                u.LastName = model.LastName;
                u.UserName = model.UserName;
                u.Link = model.Link;
                u.Gender = model.Gender;
                u.Locale = model.Locale;

                UserAppService.Update(u);
                return Request.CreateResponse(HttpStatusCode.OK, "Registro Atualizado com Sucesso!");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.GatewayTimeout, "Não foi possivel Atualizar o registro");
            }
        }

        //public HttpResponseMessage Put(int id, [FromBody]string value) 
        //{
        //    try
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, "Registro atualizado com sucesso");
        //    }
        //    catch (Exception)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.GatewayTimeout, "Ocorreu um erro ao Atualizar");
        //    }
        //}


        [HttpDelete]
        [ResponseType(typeof(string))]
        // DELETE: api/User/5
        public HttpResponseMessage Delete(string key)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deletado com Sucesso");

                Guid userKey;
                Guid.TryParse(key, out userKey);
                var user = UserAppService.GetUser(userKey);
                UserAppService.Delete(user);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.GatewayTimeout, "Ocorreu um erro ao Deletar");
            }
        }

        [HttpGet]
        [ResponseType(typeof(UserDto))]
        public HttpResponseMessage List<UserDto>()
        {
            try
            {
                var userList = UserAppService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, userList);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocorreu um erro ao buscar a listagem de Usuários");
            }
        }

    }
}
