using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _applicationServiceClient;

        public ClientController(IApplicationServiceClient applicationServiceClient)
        {
            this._applicationServiceClient = applicationServiceClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClient.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClient.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationServiceClient.Add(clientDto);
                return Ok("Cliente Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationServiceClient.Update(clientDto);
                return Ok("Cliente Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClientDto clientDto)
        {
            try
            {
                if (clientDto == null)
                    return NotFound();

                _applicationServiceClient.Remove(clientDto);
                return Ok("Cliente Removido com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
