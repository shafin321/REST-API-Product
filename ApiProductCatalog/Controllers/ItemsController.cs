using ApiProductCatalog.Entities;
using ApiProductCatalog.Respositrory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProductCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly InMemoryRepository _repo;
        public ItemsController()
        {
            _repo = new InMemoryRepository();
        }
        //Get/Items
        [HttpGet]
        public IEnumerable<Item> GetAllProduct()
        {
            return _repo.GetItems();
        }

        //GET/Items/Id
        [HttpGet("{id}")]
        public ActionResult<Item> getProduct(Guid id)
        {
            var item = _repo.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
