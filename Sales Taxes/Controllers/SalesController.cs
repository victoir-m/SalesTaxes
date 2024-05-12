using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;

namespace Sales_Taxes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISales _sales;

        public SalesController(ISales sales)
        {
            _sales = sales;
        }

        [HttpPost("PurchaseGoods")]
        public async Task<ActionResult<string>> Purchase(List<BasketDto> items)
        {
            string receipt = _sales.Sale(items);

            return Ok(receipt);
        }
    }
}
