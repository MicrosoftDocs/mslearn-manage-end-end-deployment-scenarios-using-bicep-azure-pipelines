using System.Collections.Generic;
using ToyCompany.Website.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ToyCompany.Website.Services
{
    public interface IToyService
    {
        List<Toy> GetToys();
    }

    public class ToyService : IToyService
    {
        private readonly IConfiguration _configuration;

        public ToyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Toy> GetToys()
        {
            var toys = new List<Toy>();

            using (SqlConnection sqlConnection = new SqlConnection(_configuration["SqlDatabaseConnectionString"]))
            {
                sqlConnection.Open();

                var sqlCommand = new SqlCommand("SELECT [Id], [Name], [Description], [Price], [ImageId] FROM [Toys]", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        var toy = new Toy()
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetSqlMoney(3).ToDecimal(),
                            ImageUrl = GetImageUrl(reader.GetString(4))

                        };
                        toys.Add(toy);

                    }
                }
                finally
                {
                    reader.Close();
                }
            }

            return toys;
        }

        private string GetImageUrl(string imageId)
        {
            var storageAccountBlobEndpoint = _configuration["StorageAccountBlobEndpoint"];
            var storageAccountImagesContainerName = _configuration["StorageAccountImagesContainerName"];           

            return $"{storageAccountBlobEndpoint}{storageAccountImagesContainerName}/{imageId}.png";
        }
    }
}
