using ChartsAPI.Hubs;
using ChartsAPI.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;

namespace ChartsAPI.Subscription
{
    public interface IDatabaseSubscription
    {
        void Configure(string tableName);
    }
    public class DatabaseSubscription<T> : IDatabaseSubscription where T : class, new()
    {
        IConfiguration _configuration;
        IHubContext<SatisHub> _hubContext;
        public DatabaseSubscription(IConfiguration configuration, IHubContext<SatisHub> hubContext)
        {
            _configuration = configuration;
            _hubContext = hubContext;
        }


        SqlTableDependency<T> _tableDependency;
        public void Configure(string tableName)
        {

            _tableDependency = new SqlTableDependency<T>("Server=localhost; Database=SATIS_DB; User Id=sa; Password=MyPass@word; Trusted_Connection=False;", tableName);
            _tableDependency.OnChanged += async (o, e) =>
            {

                SATIS_DBContext context = new SATIS_DBContext();
                var query = context.Personellers.Select(y => new
                {
                    data = context.Satislars.Where(a => a.PersonelId == y.Id).Select(a => a.Fiyat).ToList(),
                    name = y.Adi,

                }).ToList();

                await _hubContext.Clients.All.SendAsync("receiveMessage", query);





            };
            _tableDependency.OnError += (o, e) =>
            {

            };
            _tableDependency.Start();





        }
        ~DatabaseSubscription()
        {
            _tableDependency.Stop();
        }

    }
}
