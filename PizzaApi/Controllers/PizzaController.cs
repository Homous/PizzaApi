using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PizzaApi.Data;
using PizzaApi.Interfaces;
using PizzaApi.Models;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizza db;
        public PizzaController(IPizza db )
        { 
            this.db = db;
        }


        [HttpGet]
        public IActionResult GetAllPizzas()
        {
            return Ok(db.GetPizzas());
        }

        [HttpGet("{id}")]
        public IActionResult GetPizzaById(int id)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return Ok(db.GetPizzasById(id));
        }
        [HttpPost]
        public IActionResult AddPizza(Pizza pizza)
        {
            var PizzaVal = db.AddPizza(pizza);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok("Was Added");
        }
        [HttpPut]
        public IActionResult UpdatePizza(Pizza pizza)
        {
            var PizzaVal = db.UpdatePizzas(pizza);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok("Was Updated");
           
        }
        [HttpDelete]
        public IActionResult DeletePizza(int id)
        {
            var PizzaVal = db.DeletePizza(id);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok("Was Deleted");
        }



    }
}
