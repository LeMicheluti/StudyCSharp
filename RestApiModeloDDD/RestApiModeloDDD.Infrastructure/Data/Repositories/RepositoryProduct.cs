using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext) { }
    }
}
