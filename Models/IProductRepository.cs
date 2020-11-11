using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UNFBooks.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Products { get; }
    }
}
