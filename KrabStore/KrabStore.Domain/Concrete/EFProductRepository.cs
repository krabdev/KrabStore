using KrabStore.Domain.Entities;
using KrabStore.Domain.Abstract;
using System.Linq;

namespace KrabStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
