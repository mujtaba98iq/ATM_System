using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsAccessLayerForATM
{
    public class clsAccessATM
    {
        public struct stClient
        {
            public int PersonID;
            public string Balance;
            public string AccNumber;
            public int PinCode;
        }

        public static bool GetClientInfoByAccNumber(int ID, ref stClient Client)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select * from Emploiees where ID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader result = command.ExecuteReader();

                if (result.Read())
                {
                    isFound = true;
                    ID = (int)result["ID"];
                    Client.AccNumber = (string)result["AccNumber"];
                    Client.Balance = (string)result["Balance"];
                    Client.PinCode = (int)result["PinCode"];
                    Client.PersonID = (int)result["PersonID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static int GetIDByUserName(string AccNumber)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select ID from Emploiees where AccNumber=@AccNumber;
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
     

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }
            return ID;
        }

        public static bool WithDraw(string AccNumber, float Ammont)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Emploiees]
                       SET 
                       [Balance] = Balance-@Ammont  
                       WHERE AccNumber=@AccNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
            command.Parameters.AddWithValue("@Ammont", Ammont);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool ChangePinCode(string AccNumber, int NewPinCode)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Emploiees]
                       SET 
                       [PinCode] = @NewPinCode  
                       WHERE AccNumber=@AccNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
            command.Parameters.AddWithValue("@NewPinCode", NewPinCode);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool Deposit(string AccNumber, float Ammont)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"UPDATE [dbo].[Emploiees]
                       SET 
                       [Balance] = Balance+@Ammont  
                       WHERE AccNumber=@AccNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
            command.Parameters.AddWithValue("@Ammont", Ammont);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool Login(string AccNumber, string PinCode)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connection);

            string query = @"select Found=1 from Emploiees where AccNumber=@AccNumber and PinCode=@PinCode;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccNumber", AccNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return isFound;
        }
    }
}
