using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class RoomRepository
    {
        SqlConnection mydb = new SqlConnection("Server=LAPTOP-MR3G567K;Database=HumaneSociety;Integrated Security=true;");
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            string roomName;
            int size;
            int animalId;
            try
            {
                string insertQuery = $"SELECT Name, Size, Animal_Id FROM Room";
                mydb.Open();
                SqlCommand myCmd = new SqlCommand(insertQuery, mydb);
                myCmd.ExecuteNonQuery();
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {

                    roomName = myReader.GetString(0);
                    size = myReader.GetInt32(1);
                    animalId = myReader.IsDBNull(2)? default(int) : myReader.GetInt32(2);
                    rooms.Add(new Room(roomName, size, animalId));
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
            return rooms;
        }

        public void InsertIntoRooms(string roomId, int size)
        {
            try
            {
                string insertQuery = $"INSERT INTO Room (Name, Size) VALUES ('{roomId}',{size})";
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
        public void UpdateAnimalToRoom(string roomId, int animalId)
        {
            try
            {
                string query = $"UPDATE Room SET Animal_Id = {animalId} WHERE Name = '{roomId}'";
                mydb.Open();
                SqlCommand myUpdate = new SqlCommand(query, mydb);
                myUpdate.ExecuteNonQuery();
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
        public List<DisplayRoom> GetAllRoomsWithAnimalNames()
        {
            List<DisplayRoom> rooms = new List<DisplayRoom>();
            string query = $"SELECT Room.Name, Room.Animal_Id, Animal.Animal_Type, Animal.Name FROM Room LEFT JOIN Animal ON Room.Animal_Id = Animal.Animal_Id";
            DisplayRoom aRoom;
            try
            {
                mydb.Open();
                SqlCommand myCmd = new SqlCommand(query, mydb);
                SqlDataReader mR = myCmd.ExecuteReader();
                string animalName = "";
                string animalType = "";
                int animalId = 0;

                while (mR.Read())
                {

                    if (mR.GetSqlString(3).IsNull)
                        animalName = "";
                    else
                        animalName = mR.GetSqlString(3).ToString();

                    if (mR.GetSqlString(2).IsNull)
                        animalType = "";
                    else
                        animalType = mR.GetSqlString(2).ToString();

                    if (mR.IsDBNull(1))
                        animalId = 0;
                    else
                        animalId = mR.GetInt32(1);

                    aRoom = new DisplayRoom(mR.GetSqlString(0).ToString(), animalName, animalType, animalId);
                    rooms.Add(aRoom);
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
            return rooms;
        }
    }
}
