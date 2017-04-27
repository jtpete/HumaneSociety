using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AnimalRepository
    {
        SqlConnection mydb = new SqlConnection("Server=LAPTOP-MR3G567K;Database=HumaneSociety;Integrated Security=true;");

        public void InsertAnimal(Animal anAnimal)
        {
            AnimalHealthRepository myAnimalHealth = new AnimalHealthRepository();
            AnimalTraitRepository myAnimalTraits = new AnimalTraitRepository();
            InsertIntoAnimal(anAnimal);
            GetAnimalId(anAnimal);
            myAnimalTraits.InsertIntoAnimalTraits(anAnimal);
            myAnimalHealth.InsertIntoAnimalHealth(anAnimal);
        }
        public void InsertIntoAnimal(Animal anAnimal)
        {
            try
            {
                string insertQuery = $"INSERT INTO Animal (Animal_Type, Name, Arrival_Date, Price) VALUES ('{anAnimal.Type}','{anAnimal.Name}', '{anAnimal.Arrival.Value.ToString("yyyy-MM-dd HH:mm:ss tt")}', {anAnimal.Price})";
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
        public void GetAnimalId(Animal anAnimal)
        {
            try
            {
                mydb.Open();
                string query = $"SELECT Animal_Id FROM Animal WHERE Arrival_Date = '{anAnimal.Arrival.Value.ToString("yyyy-MM-dd HH:mm:ss tt")}'";
                SqlCommand myCmd = new SqlCommand(query, mydb);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    anAnimal.AnimalId = myReader.GetInt32(0);
                }
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
