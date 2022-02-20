using MySql.Data.MySqlClient;

namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public Task<Pizzaz[]> GetPizzasAsync()
        {
            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=pizzaria;port=3306;password");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pizza", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              Pizzaz pizzaz = new();
            }
        }
    }
}
