using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using devAppProject.Api.Models;
using devAppProject.Business;
using devAppProject.Common.Configuration;
using devAppProject.Domain.Contracts.Services;
using devAppProject.Domain.Models;


namespace devAppProject.Api.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioService _service = new UsuarioService();

        [HttpGet]
        [Route("v1/public/usuarioid/{id}")]
        public Task<HttpResponseMessage> GetIdUsuario(int id)
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.GetId(id);
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

        [HttpGet]
        [Route("v1/public/usuariocodigo/{codigo}")]
        public Task<HttpResponseMessage> GetCodigoUsuario(string codigo)
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.GetCodigo(codigo.Replace("_","."));
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar encontrar o codigo - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("v1/public/usuarionome/{nome}")]
        public Task<HttpResponseMessage> GetNomeUsuario(string nome)
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.GetNome(nome);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar encontrar o nome - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpGet]
        [Route("v1/public/usuario")]
        public Task<HttpResponseMessage> GetListaUsuario()
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.Get();
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar encontrar lista de usuarios - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPut]
        [Route("v1/public/novousuario")]
        public Task<HttpResponseMessage> PutNovoUsuario(RegisterUsuarioViewModel model)
        {
            HttpResponseMessage response;
            try
            {
                //Padrão para gerar o codigo do usuario
                var strPrimeiroNome = model.Nome.Split(' ');
                var strCodigoUser = Tools.RemoveAccent(strPrimeiroNome[0].ToLower() + "." + strPrimeiroNome[1].ToLower());

                //Registra Usuario
                var user = new Usuario(strCodigoUser, model.Email)
                {
                    IdPerfil = model.IdPerfil,
                    Nome = model.Nome,
                    Sobrenome = model.Sobrenome,
                    Senha = model.Senha,
                    Rg = model.Rg,
                    Cpf = model.Cpf,
                    Email = model.Email,
                    Telefone = model.Telefone,
                    Celular = model.Celular,
                    Facebook = model.Facebook,
                    Twitter = model.Twitter,
                    LinkedIn = model.LinkedIn,
                    Status = 1,
                    Data = DateTime.Now
                };
                _service.Create(user);
                response = Request.CreateResponse(HttpStatusCode.OK, "Usuário registrado com sucesso!");
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar cadastrar novo usuario - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpPost]
        [Route("v1/public/alterausuario")]
        public Task<HttpResponseMessage> PostAlteraUsuario(ChangeUsuarioViewModel model)
        {
            HttpResponseMessage response;
            try
            {
                //Altera Usuario
                var user = new Usuario(model.Codigo, model.Email)
                {
                    Id = model.Id,
                    Nome = model.Nome,
                    Sobrenome = model.Sobrenome,
                    Senha = model.Senha,
                    Telefone = model.Telefone,
                    Celular = model.Celular,
                    Data = DateTime.Now,
                    Status = 1
                };
                _service.Update(user);
                response = Request.CreateResponse(HttpStatusCode.OK, "Usuário alterado com sucesso!");
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar alterar usuario - " + ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        [HttpDelete]
        [Route("v1/public/deletausuario/{id}")]
        public Task<HttpResponseMessage> DeteleUsuario(int id)
        {
            HttpResponseMessage response;
            try
            {
                _service.Delete(id);
                response = Request.CreateResponse(HttpStatusCode.OK, "Usuario excluido com sucesso.");
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao tentar excluir o usuario - " + ex.Message);
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
            
        [HttpGet]
        [Route("v1/public/Authenticate")]
        public Task<HttpResponseMessage> GetAuthenticateUser()
        {
            HttpResponseMessage response;
            try
            {
                var result = _service.Authenticate("lucianocjesus@gmail.com", "290178");
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }

        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
        }
    }
}
