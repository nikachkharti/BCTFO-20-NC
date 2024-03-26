using HotelProject.Data;
using HotelProject.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace HotelProject.Repository
{
    public class ManagerRepository
    {
        public List<Manager> GetManagers()
        {
            List<Manager> result = new();
            const string sqlExpression = "sp_GetAllManagers";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            result.Add(new Manager()
                            {
                                Id = reader.GetInt32(0),
                                FirstName = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                LastName = !reader.IsDBNull(2) ? reader.GetString(2) : string.Empty,
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }
        }
        public void AddManager(Manager manager)
        {
            string sqlExpression = "sp_addManager";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("firstName", manager.FirstName);
                    command.Parameters.AddWithValue("lastName", manager.LastName);

                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void UpdateManager(Manager manager)
        {
            string sqlExpression = "sp_UpdateManager";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("firstName", manager.FirstName);
                    command.Parameters.AddWithValue("lastName", manager.LastName);
                    command.Parameters.AddWithValue("id", manager.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("No manager found with the specified ID.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void DeleteManager(int id)
        {
            string sqlExpression = "sp_DeleteManager";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("No manager found with the specified ID.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
