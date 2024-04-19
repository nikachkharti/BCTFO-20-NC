using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;

namespace HotelProject.Repository.MicrosoftDataSQLClient
{
    public class RoomRepository : IRoomRepository
    {
        /*
        public async Task<List<Room>> GetRooms()
        {
            List<Room> result = new();
            const string sqlExpression = "sp_GetAllRooms";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        if (reader.HasRows)
                        {
                            result.Add(new Room()
                            {
                                Id = reader.GetInt32(0),
                                Name = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                IsFree = !reader.IsDBNull(2) ? reader.GetBoolean(2) : false,
                                HotelId = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0,
                                DailyPrice = !reader.IsDBNull(4) ? reader.GetDouble(4) : 0
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
                    await connection.CloseAsync();
                }

                return result;
            }

        }
        public async Task<List<Room>> GetRoomsOfHotel(int hotelId)
        {
            List<Room> result = new();
            const string sqlExpression = "sp_GetAllRoomsOfHotel";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("hotelId", hotelId);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        if (reader.HasRows)
                        {
                            result.Add(new Room()
                            {
                                Id = reader.GetInt32(0),
                                Name = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                IsFree = !reader.IsDBNull(2) ? reader.GetBoolean(2) : false,
                                HotelId = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0,
                                DailyPrice = !reader.IsDBNull(4) ? reader.GetDouble(4) : 0
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
                    await connection.CloseAsync();
                }

                return result;
            }

        }
        public async Task AddRoom(Room room)
        {
            string sqlExpression = "sp_AddRoom";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("name", room.Name);
                    command.Parameters.AddWithValue("isFree", room.IsFree);
                    command.Parameters.AddWithValue("hotelId", room.HotelId);
                    command.Parameters.AddWithValue("dailyPrice", room.DailyPrice);

                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("Query didn't effect any data");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

        }
        public async Task DeleteRoom(int id)
        {
            string sqlExpression = "sp_DeleteRoom";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("Query didn't effect any data");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

        }
        public async Task UpdateRoom(Room room)
        {
            string sqlExpression = "sp_UpdateRoom";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id", room.Id);
                    command.Parameters.AddWithValue("name", room.Name);
                    command.Parameters.AddWithValue("isFree", room.IsFree);
                    command.Parameters.AddWithValue("hotelId", room.HotelId);
                    command.Parameters.AddWithValue("dailyPrice", room.DailyPrice);

                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected == 0)
                    {
                        throw new InvalidOperationException("Query didn't effect any data");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

        }
        public async Task<Room> GetSingleRoom(int id)
        {
            Room result = new();
            const string sqlExpression = "sp_GetSingleRoom";

            using (SqlConnection connection = new(ApplicationDbContext.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        if (reader.HasRows)
                        {
                            result.Id = reader.GetInt32(0);
                            result.Name = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty;
                            result.IsFree = !reader.IsDBNull(2) ? reader.GetBoolean(2) : false;
                            result.HotelId = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
                            result.DailyPrice = !reader.IsDBNull(4) ? reader.GetDouble(4) : 0;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }

        }
         */
        public Task AddAsync(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetAllAsync(Expression<Func<Room, bool>> filter, string includePropeties = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetAllAsync(string includePropeties = null)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetAsync(Expression<Func<Room, bool>> filter, string includePropeties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task<Room> Update(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}
