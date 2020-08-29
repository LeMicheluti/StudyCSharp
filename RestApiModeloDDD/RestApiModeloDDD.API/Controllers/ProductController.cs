using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProduct _applicationServiceProduct;

        public ProductController(IApplicationServiceProduct applicationServiceProduct)
        {
            this._applicationServiceProduct = applicationServiceProduct;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduct.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduct.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Add(productDto);
                return Ok("Produto Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Update(productDto);
                return Ok("Produto Atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _applicationServiceProduct.Remove(productDto);
                return Ok("Produto Removido com Sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
