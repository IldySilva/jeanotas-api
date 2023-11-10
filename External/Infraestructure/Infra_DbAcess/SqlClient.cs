using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infraestructure.Infra_DbAcess
{

    public class DataAccess : IDataAccess
    {
        private string? _connectionString;
        private readonly IConfiguration _configuration;
        private const string Dbname = "DataSource";
        private readonly IDbConnection _db;
        public DataAccess(IConfiguration configuration, IDbConnection db)
        {
            _db = db;
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString(Dbname);
        }

        public void SetDatabase(string? empresa)
        {
            string? connectionString = _configuration.GetConnectionString(Dbname) ?? string.Empty;

            _connectionString = connectionString.Replace("Main", empresa);

            _db.ConnectionString = _connectionString;
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<T>(sql, parameters);
            }
        }

        public async Task<int> CommandAsync(string query, object o)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(query, o);
            }

            return 0;
        }

        public async Task<int> CommandAsync(params string[] querys)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (querys.Length > 1)
                {
                    connection.Open();
                    IDbTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        int result = 0;

                        foreach (var query in querys)
                        {
                            result += await connection.ExecuteAsync(query, transaction: transaction);
                        }

                        transaction.Commit();

                        return result;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                    finally
                    {
                        transaction.Dispose();
                        connection.Close();
                    }
                }

                return await connection.ExecuteAsync(querys.FirstOrDefault());
            }
        }

        public IEnumerable<T> Query<T>(string sql, object? parameters = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.Query<T>(sql, parameters);
            }
        }

        public T QueryFirstOrDefault<T>(string sql, object? parameters = null)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        public int ExecuteCommand(params string[] sql)
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (sql.Length > 1)
                {

                    IDbTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        int result = 0;
                        foreach (var item in sql)
                        {
                            result += connection.Execute(item);
                        }
                        transaction.Commit();
                        return result;
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        transaction.Dispose();
                    }

                }
                return connection.Execute(sql.FirstOrDefault());
            }
        }
    }
}

