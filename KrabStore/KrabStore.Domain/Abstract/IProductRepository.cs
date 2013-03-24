using System.Linq;
using KrabStore.Domain.Entities;

namespace KrabStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
