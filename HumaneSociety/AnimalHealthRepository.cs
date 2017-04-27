using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AnimalHealthRepository 
    {
        SqlConnection mydb = new SqlConnection("Server=LAPTOP-MR3G567K;Database=HumaneSociety;Integrated Security=true;");

        public void InsertIntoAnimalHealth(Animal anAnimal)
        {
            try
            {
                    string insertQuery = $"INSERT INTO Health (Shots_Date, Food_Type, Consumption, Dish_Size, Space_Needs, Animal_Id, Age) VALUES ('{anAnimal.ThisHealth.ShotsDate?.ToString("yyyy-MM-dd HH:mm:ss tt") ?? null}','{anAnimal.ThisHealth.FoodType}', {anAnimal.ThisHealth.FoodConsumptionPerWeek}, {anAnimal.ThisHealth.DishSize}, {anAnimal.ThisHealth.SpaceNeeds}, {anAnimal.AnimalId}, {anAnimal.ThisHealth.Age})";
                mydb.Open();
                SqlCommand myAdd = new SqlCommand(insertQuery, mydb);
                myAdd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                mydb.Close();
            }
        }

    }
}
