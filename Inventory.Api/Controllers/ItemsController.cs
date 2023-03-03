using Inventory.Api.Contracts.Items.Requests;
using Inventory.Api.Contracts.Items.Responses;
using Inventory.Api.Mapping;
using Inventory.Application.Models;
using Inventory.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Inventory.Api.Controllers
{
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;
        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        [HttpGet]
        [Route("api/items")]
        public ActionResult<IList<GetAllItemsResponse>> GetItems()
        {
            try
            {
                var result = _itemsRepository.GetAll();
                
                return Ok(result.MapToResponse());
            }
            catch (Exception ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError,ex.Message);
            }
        }

        [HttpPost("api/items")]
        public ActionResult<CreateItemResponse> Create(CreateItemRequest request)
        {
            try
            {
                var item = request.MapToItem();
                var result = _itemsRepository.Create(item);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
 
        }

    }
}
