using Microsoft.AspNetCore.Mvc.ModelBinding;
using PizzaApi.Data;
using PizzaApi.Interfaces;
using PizzaApi.Models;

namespace PizzaApi.Repository
{

    public class PizzaRepository : IPizza
    {
        private readonly AppDbContext db;
        public PizzaRepository(AppDbContext db)
        {
            this.db=db;
        }
        public IEnumerable<Pizza> GetPizzas()
        {
            return db.Pizzas.ToList();
        }

        public Pizza GetPizzasById(int id)
        {
                return db.Pizzas.FirstOrDefault(m => m.Id == id);
        }


        public Pizza AddPizza(Pizza pizza)
        {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return pizza;
        }

        public Pizza UpdatePizzas(Pizza pizza)
        {
                db.Pizzas.Update(pizza);
                db.SaveChanges();
                return pizza;
        }


        public Pizza DeletePizza(int id)
        {
            var PizzaVal = db.Pizzas.FirstOrDefault(m => m.Id == id);
               
                db.Pizzas.Remove(PizzaVal);
                db.SaveChanges();
                return PizzaVal;
        }

    }
}
