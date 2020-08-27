using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;
        public void Add(ClientDto clientDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClientDto clientDto)
        {
            throw new NotImplementedException();
        }

        public void Update(ClientDto clientDto)
        {
            throw new NotImplementedException();
        }
    }
}
