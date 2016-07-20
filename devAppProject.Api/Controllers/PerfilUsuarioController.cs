using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using devAppProject.Api.Models;
using devAppProject.Business;
using devAppProject.Domain.Contracts.Services;
using devAppProject.Domain.Models;

namespace devAppProject.Api.Controllers
{
    [RoutePrefix("api/perfilUsuario")]
    public class PerfilUsuarioController : ApiController
    {
        private readonly IPerfilUsuarioService _service;
        public PerfilUsuarioController()
        {
            _service = new PerfilUsuarioService();
        }

        [HttpGet]
        [Route("v1/public/GetIdPerfilUsuario/{id}")]
        public Task<HttpResponseMessage> GetIdPerfilUsuario(int id)
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.Get(id);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar encontrar o Id - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPut]
        [Route("v1/public/PutNovoPerfilUsuario")]
        public Task<HttpResponseMessage> PutNovoPerfilUsuario(RegisterPerfilUsuarioViewModel model)
        {
            HttpResponseMessage response;
            try
            {
                var perfil = new PerfilUsuario
                {
                    Tipo = model.Tipo,
                    Descricao = model.Descricao
                };
                _service.Create(perfil);
                response = Request.CreateResponse(HttpStatusCode.OK, "Perfil registrado com sucesso!");
                
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar cadastrar novo perfil - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}
