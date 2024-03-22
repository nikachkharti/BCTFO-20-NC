using HotelProject.Data;
using HotelProject.Models;
using Microsoft.Data.SqlClient;

namespace HotelProject.Repository
{
    public class ManagerRepository
    {
        public List<Manager> GetManagers()
        {
            List<Manager> result = new();
            const string sqlExpression = "SELECT*FROM Managers";

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
            string sqlExpression = @$"INSERT INTO Managers(FirstName,LastName) VALUES (N'{manager.FirstName}',N'{manager.LastName}')";

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


        //TODO: დაწერეთ მენეჯერის update - ის და მენერჯერის delete - ის ფუნციონალი

        //TODO: შექმენით სასტუმროს ცხრილი sql - ში შემდეგი პარამეტრებით
        //Id INT PK IDENTITY
        //დასახელება NVARCHAR
        //Rating FLOAT
        //Country NVARCHAR
        //City NVARCHAR
        //PhysicalAddress NVARCHAR



    }
}
