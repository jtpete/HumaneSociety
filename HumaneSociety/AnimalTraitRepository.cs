using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AnimalTraitRepository
    {
        SqlConnection mydb = new SqlConnection("Server=LAPTOP-MR3G567K;Database=HumaneSociety;Integrated Security=true;");

        public void InsertIntoAnimalTraits(Animal anAnimal)
        {
            try
            {
                string insertQuery = $"INSERT INTO Traits (Activity_Level, Color, Weight, Height, Animal_Id) VALUES ({anAnimal.TheseTraits.ActivityLevel},'{anAnimal.TheseTraits.Color}', {anAnimal.TheseTraits.Weight}, {anAnimal.TheseTraits.Height}, {anAnimal.AnimalId})";
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
