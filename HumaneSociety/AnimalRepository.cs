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
        public void UpdateAnimalAdoption(int animalId)
        {
            try
            {
                mydb.Open();
                string query = $"UPDATE Animal SET Adopted_Toggle = 'yes' WHERE Animal_Id = '{animalId}'";
                SqlCommand myCmd = new SqlCommand(query, mydb);
                myCmd.ExecuteNonQuery();
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
        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            string query = $"SELECT * From Animal Full OUTER JOIN Traits ON Traits.Animal_Id = Animal.Animal_Id FULL OUTER JOIN Health ON Health.Animal_Id = Animal.Animal_Id WHERE Animal.Adopted_Toggle IS NULL";
            Animal aAnimal;
            try
            {
                mydb.Open();
                SqlCommand myCmd = new SqlCommand(query, mydb);
                SqlDataReader mR= myCmd.ExecuteReader();
                
                while (mR.Read())
                {
                    aAnimal = new Animal(mR.GetSqlString(2).ToString(), mR.GetSqlString(1).ToString(), double.Parse(mR.GetSqlMoney(4).ToString()), mR.GetDateTime(3), mR.GetSqlString(8).ToString(), mR.GetInt32(9), mR.GetInt32(9), mR.GetInt32(7), mR.GetInt32(19), (((DateTime.Now).Year - (mR.GetDateTime(13)).Year) > 100) ? null : (DateTime?)mR.GetDateTime(13), mR.GetSqlString(14).ToString(), mR.GetInt32(15), mR.GetInt32(16), mR.GetInt32(17), mR.GetInt32(0));
                    animals.Add(aAnimal);
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
            return animals;

        }




    }


}
