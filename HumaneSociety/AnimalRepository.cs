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
            try
            {
                int count = 0;
                string insertQuery = BuildInsertString(anAnimal);
                mydb.Open();
                SqlCommand myAdd = new SqlCommand(insertQuery, mydb);
                IAsyncResult result = myAdd.BeginExecuteNonQuery();
                while (!result.IsCompleted)
                {
                    Console.WriteLine("Waiting for DB Write {0}", count++);
                    Thread.Sleep(1000);
                }
                myAdd.EndExecuteNonQuery(result);
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

        private string BuildInsertString(Animal anAnimal)
        {
            string insert = $"INSERT INTO HumaneSociety (Animal_Type, Name, Arrival_Date) VALUES ('{anAnimal.Type}','{anAnimal.Name}', '{anAnimal.Arrival.ToString("yyyy-MM-dd HH:mm:ss tt")}')";
            return insert;
        }
    }


}
