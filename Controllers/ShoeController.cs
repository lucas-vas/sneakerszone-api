using Microsoft.AspNetCore.Mvc;
using sneakerszone_api.Model;
using sneakerszone_api.Repositories;

namespace sneakerszone_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ShoeRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(ShoeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult AddShoe([FromBody] Shoe shoe)
        {
            ShoeRepository.AddShoe(shoe);
            return Ok("Sapato adicionado.");
        }

        [HttpPut]
        public IActionResult UpdateShoe([FromBody] Shoe shoe)
        {
            ShoeRepository.UpdateShoe(shoe);
            return Ok("Sapato atualizado.");
        }
    }
}