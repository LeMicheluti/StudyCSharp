using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        public RepositoryClient(SqlContext sqlContext) : base(sqlContext) { }
    }
}
