using System.Collections.Generic;
using KrabStore.Domain.Entities;

namespace KrabStore.WebUI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo pagingInfo { get; set; }
    }
}