using Microsoft.AspNetCore.Mvc;
using SwaggerAPI.Models;
using System.Collections.Generic;

namespace SwaggerAPI.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Realiza o Login
        /// </summary>
        /// <param name="parametro">Email e senha</param>
        /// <response code="200">Login realizado com sucesso</response>
        /// <response code="500">Ocorreu um erro ao realizar o login</response>
        [HttpPost("/login")]
        public JsonResult Login(ParametrosEntrada parametro)
        {
            var retorno = new ParametrosRetorno();

            if (parametro.Email.Equals("aa@gmail.com") && parametro.Senha.Equals("1234"))
            {
                retorno.Codigo = 0;
                retorno.Notificação = "Login com sucesso";
            }
            else
            {
                retorno.Codigo = 1;
                retorno.Notificação = "Usuário ou senha incorreto";
            }
            return new JsonResult(retorno);
        }

        /// <summary>
        /// Obtem lista de produtos
        /// </summary>
        /// <returns>Retorna a lista de produtos</returns>
        [HttpGet("/listaprodutos")]
        public JsonResult ListaProdutos()
        {
            var retorno = new List<ParametrosRetorno>();

            for (int i = 0; i < 20; i++)
            {
                retorno.Add(new ParametrosRetorno
                {
                    Codigo = i,
                    Notificação = string.Concat("Produto - ", i.ToString())
                });
            }

            return new JsonResult(retorno);
        }
    }
}
