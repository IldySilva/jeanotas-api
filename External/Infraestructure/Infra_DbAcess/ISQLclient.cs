
namespace Infraestructure.Infra_DbAcess
{
    public interface IDataAccess
    {
        void SetDatabase(string? db);
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters = null);
        IEnumerable<T> Query<T>(string sql, object? parameters = null);
        Task<int> CommandAsync(params string[] sql);
        T QueryFirstOrDefault<T>(string sql, object? parameters = null);
        Task<int> CommandAsync(string query, object o);
    }
}
