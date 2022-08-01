using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    internal class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void CreateProduct(string name, double price, int categoryID)
        {
            name = "Divinity Original sin";
            price = 54.99;
            categoryID = 8;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return (IEnumerable<Product>)_connection.Query<Product>("SELECT * FROM products;");
        }
    }
}
