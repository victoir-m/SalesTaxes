using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesTaxesBll.Dtos;
using SalesTaxesBll.Interfaces;

namespace Sales_Taxes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly IGoods _goods;

        public GoodsController(IGoods goods)
        {
            _goods = goods;
        }

        [HttpGet("GetGoodsList")]
        public async Task<ActionResult<ItemsDto>> GetGoods()
        {
            var goods =  _goods.GetGoodsList();
            return Ok(goods);
        }

        [HttpGet("GetGood")]
        public async Task<ActionResult<ItemsDto>> GetGood(int Id)
        {
            var good = _goods.GetGood(Id);
            return Ok(good);
        }

    }
}
