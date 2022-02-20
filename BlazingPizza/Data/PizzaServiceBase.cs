using MySql.Data.MySqlClient;
using System;

namespace BlazingPizza.Data
{
    public class PizzaServiceBase
    {
        public Task<Pizzaz[]> GetPizzasAsync()
        {
            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=pizzaria;port=3306;password");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pizza", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pizzaz pizzaz = new Pizzaz();
            }
        }
    }
}