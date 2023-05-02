using PizzaApi.Models;

namespace PizzaApi.Interfaces
{
    public interface IPizza
    {
         IEnumerable<Pizza> GetPizzas();
         Pizza GetPizzasById(int id);
         Pizza AddPizza(Pizza pizza);
         Pizza UpdatePizzas(Pizza pizza);
         Pizza DeletePizza(int id);

    }
}
