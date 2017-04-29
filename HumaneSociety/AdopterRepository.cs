using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AdopterRepository
    {
        SqlConnection mydb = new SqlConnection("Server=LAPTOP-MR3G567K;Database=HumaneSociety;Integrated Security=true;");
        public void InsertAnAdoption(Adopter person)
        {
            try
            {
                string insertQuery = $"INSERT INTO Adopter (Name, Email, Phone, Number_Kids, Number_Pets, Adoption_Price, Adoption_Date, Animal_Id) VALUES ('{person.Name}','{person.Email}', '{person.Phone}', {person.NumberOfKids}, {person.NumberOfPets}, {person.AdoptionPrice}, '{person.AdoptionDate.ToString("yyyy-MM-dd HH:mm:ss tt")}', {person.AnimalId})";
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
