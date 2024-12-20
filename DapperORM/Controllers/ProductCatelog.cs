using Dapper;
using DapperORM.Modals;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DapperORM.Controllers
{
    public class ProductCatelog : Controller
    {
        private IDbConnection _dbConnection;
        public ProductCatelog(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet("Products")]
        public ActionResult GetProductCatalog()
        {
            try
            {
                // Query the database to get the product catalog
                var productCatalog = _dbConnection.Query<Product>("SELECT * FROM Product");

                // Return the result as an HTTP 200 response
                return Ok(new { Data = productCatalog });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging (replace with your logging framework)
                Console.Error.WriteLine(ex);

                // Return an error response with a 500 status code
                return StatusCode(500, new { Message = "An error occurred while fetching the product catalog.", Details = ex.Message });
            }
        }

    }
}
