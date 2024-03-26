using HotelProject.Data;
using HotelProject.Models;
using Microsoft.Data.SqlClient;

namespace HotelProject.Repository
{
    public class HotelRepository
    {
        public List<Hotel> GetHotels()
        {
            List<Hotel> result = new();
            const string sqlExpression = "SELECT*FROM Hotels";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new(sqlExpression, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            result.Add(new Hotel()
                            {
                                Id = reader.GetInt32(0),
                                Name = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                Rating = !reader.IsDBNull(2) ? reader.GetDouble(2) : 0,
                                Country = !reader.IsDBNull(3) ? reader.GetString(3) : string.Empty,
                                City = !reader.IsDBNull(4) ? reader.GetString(4) : string.Empty,
                                PhyisicalAddress = !reader.IsDBNull(5) ? reader.GetString(5) : string.Empty,
                                ManagerId = !reader.IsDBNull(6) ? reader.GetInt32(6) : 0
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

        public void AddHotel(Hotel hotel)
        {
            string sqlExpression = @$"INSERT INTO Hotels(Name,Rating,Country,City,PhyisicalAddress,ManagerId)
                                     VALUES (N'{hotel.Name}',N'{hotel.Rating}',N'{hotel.Country}',N'{hotel.City}',N'{hotel.PhyisicalAddress}',N'{hotel.ManagerId}')";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
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

        public void UpdateHotel(Hotel hotel)
        {
            string sqlExpression = @$"UPDATE Hotels SET
                                     Name = N'{hotel.Name}',
                                     Rating = N'{hotel.Rating}',
                                     Country = N'{hotel.Country}',
                                     City = N'{hotel.City}',
                                     PhyisicalAddress = N'{hotel.PhyisicalAddress}',
                                     ManagerId = N'{hotel.ManagerId}'
                                    WHERE Id = {hotel.Id}";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
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

        public void DeleteHotel(int id)
        {
            string sqlExpression = @$"DELETE FROM Hotels WHERE Id = {id}";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("No hotel found with the specified ID.");
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
